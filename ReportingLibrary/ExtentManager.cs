using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PageObjectModel.Source.Utilities;

namespace PageObjectModel.ReportingLibrary
{
     class ExtentManager
    {
        /*private static ExtentReports extent;
        private static String projectName = Constants.PROJECT_NAME;
        private static String reportName = Constants.REPORT_NAME;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentReports GetExtent()
        {
            if (extent == null)
            {
                try
                {
                    extent = new ExtentReports();
                    extent.AttachReporter(GetHtmlReporter());
                    if (Constants.IS_REPORT_SERVER_ENABLED)
                    {
                        extent.AttachReporter(KlovReporter());
                    }
                    extent.AnalysisStrategy = AnalysisStrategy.Test;
                    extent.AddSystemInfo("Project", projectName);
                    extent.AddSystemInfo("Developer", Constants.DEVELOPER_NAME);
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            return extent;
        }

      /* private static ExtentHtmlReporter GetHtmlReporter()
        {
            String path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            String actualPath = path.Substring(0, path.LastIndexOf("bin"));
            String projectPath = new Uri(actualPath).LocalPath;
            Directory.CreateDirectory(projectPath.ToString() + "html-report");
            String reportPath = projectPath + "html-report\\ExtentReport.html";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);

            htmlReporter.Config.DocumentTitle = reportName;
            htmlReporter.Config.ReportName = reportName;
           // if (!Constants.REPORT_THEME.ToLower().Equals("dark"))
                htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
           // else
                htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
          //  return htmlReporter;
        }

        private static ExtentKlovReporter KlovReporter()
        {
            ExtentKlovReporter klov = new ExtentKlovReporter();
            klov.InitMongoDbConnection("localhost", 27017);
            klov.ProjectName = projectName;
            klov.ReportName = reportName;
            klov.InitKlovServerConnection(Constants.REPORT_URL);
            return klov;
        }*/
    }
}
