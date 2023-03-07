using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using DWSIM.Interfaces;
using DWSIM.ExtensionMethods;

namespace DWSIM.Analytics
{
    public class AnalyticsProvider : IAnalyticsProvider
    {

        public AnalyticsProvider()
        {
            if (!LocalSettings.Initialized)
            {
                // sets the assembly resolver to find remaining DWSIM libraries on demand
                AppDomain currentDomain = AppDomain.CurrentDomain;
                currentDomain.AssemblyResolve += new ResolveEventHandler(LoadFromNestedFolder);
                LocalSettings.Initialized = true;
            }
        }

        private FormMain mainform;

        public void SetMainForm(object f)
        {
            mainform = (FormMain)f;
        }

        public void Initialize()
        {

            mainform.UIThread(() =>
            {
                var f2 = new Form2();
                f2.mainform = mainform;
                var x = mainform.Location.X + mainform.Width - f2.Width - 40;
                var y = mainform.Location.Y + mainform.Height - f2.Height - 40;
                f2.Location = new System.Drawing.Point(x, y);
                f2.Show();
                f2.TransferControls();
                f2.UpdateText();
#if !DEBUG
                if (!Properties.Settings.Default.ShouldAsk) f2.Close();
#endif
            });

            // enable analytics

            var countryCode = RegionInfo.CurrentRegion.TwoLetterISORegionName;
            AppCenter.SetCountryCode(countryCode);

            System.Threading.Tasks.Task.Run(() =>
            {
                AppCenter.Start(Global.AppCenterKey,
                                typeof(Microsoft.AppCenter.Analytics.Analytics),
                                typeof(Crashes));
                Crashes.SetEnabledAsync(Properties.Settings.Default.Enabled);
                AppCenter.SetEnabledAsync(Properties.Settings.Default.Enabled);
            });

            Microsoft.AppCenter.Crashes.Crashes.GetErrorAttachments = (report) =>
            {
                var email = Properties.Settings.Default.EmailAddress;
                if (email != "")
                    return new ErrorAttachmentLog[] { ErrorAttachmentLog.AttachmentWithText(email, "useremail.txt") };
                else
                    return null;
            };

            FlowsheetSolver.FlowsheetSolver.FlowsheetCalculationFinished += (esender, eargs, data2) =>
            {
                try
                {
                    if (data2 is double)
                    {
                        var datadict = new Dictionary<string, string>();
                        datadict.Add("Time Taken (s)", data2.ToString());
                        Microsoft.AppCenter.Analytics.Analytics.TrackEvent("Flowsheet Calculation Finished", datadict);
                    }
                    else
                    {
                        Microsoft.AppCenter.Analytics.Analytics.TrackEvent("Flowsheet Calculation Finished with Errors");
                        var errorlist = (List<Exception>)data2;
                        foreach (var er in errorlist)
                        {
                            Crashes.TrackError(er);
                        }
                    }
                }
                catch
                { }
            };

            FlowsheetSolver.FlowsheetSolver.CalculationError += (esender, eargs, data2) =>
            {
                try
                {
                    var calcargs = (FlowsheetSolver.CalculationArgs)esender;
                    if (data2 != null)
                    {
                        var datadict = new Dictionary<string, string>();
                        datadict.Add("Object Type", calcargs.ObjectType.ToString());
                        Crashes.TrackError((Exception)data2, datadict);
                    }
                }
                catch
                { }
            };

        }

        static Assembly LoadFromNestedFolder(object sender, ResolveEventArgs args)
        {
            string assemblyPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "analytics", new AssemblyName(args.Name).Name + ".dll");
            if (!File.Exists(assemblyPath))
            {
                return null;
            }
            else
            {
                Assembly assembly = Assembly.LoadFrom(assemblyPath);
                return assembly;
            }
        }

        void IAnalyticsProvider.RegisterEvent(string name, string description, Dictionary<string, string> data)
        {
            if (data == null) data = new Dictionary<string, string>();
            data.Add("Description", description);
            if (Properties.Settings.Default.Enabled) Microsoft.AppCenter.Analytics.Analytics.TrackEvent(name, data);
        }

        void IAnalyticsProvider.RegisterError(string name, string description, Exception ex, Dictionary<string, string> data)
        {
            if (data == null) data = new Dictionary<string, string>();
            data.Add("Description", description);
            if (Properties.Settings.Default.Enabled) Crashes.TrackError(ex, data);
        }

    }
}
