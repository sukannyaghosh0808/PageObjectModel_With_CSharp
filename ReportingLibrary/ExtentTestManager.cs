using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.ReportingLibrary
{
     class ExtentTestManager
    {
        /*
        public static ThreadLocal<ExtentTest> extentTest = new ThreadLocal<ExtentTest>();
        public static ExtentReports extent = ExtentManager.GetExtent();
        public static ExtentTest test;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest GetTest()
        {
            return extentTest.Value;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest CreateTest(String name, String description, String deviceId)
        {
            test = extent.CreateTest(name, name).AssignCategory(description);
            extentTest.Value = test;
            return GetTest();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest CreateTest(String name, String description)
        {
            return CreateTest(name, description, Thread.CurrentThread.Name);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest CreateTest(String name)
        {
            return CreateTest(name, "Sample Test");
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void Logger(String message)
        {
            GetTest().Log(Status.Info, message + "<br>");
        }
        */
    }
}
