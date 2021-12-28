using Avatrade.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Utils
{
    public class ScreenshotManager
    {
        public static void MakeScreenShot()
        {
            Screenshot ss = ((ITakesScreenshot)DriverManager.GetDriver()).GetScreenshot();
            string path = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");

            try
            {
                ss.SaveAsFile(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName +
                    "/Avatrade/Logs/" + path + ".png", ScreenshotImageFormat.Png);

                Logger.WriteToLog("Screenshot was maken");
            }
            catch (Exception e)
            {
                Logger.WriteToLog(e, "Screenshot wasn't maken");
                throw;
            }
        }
    }
}
