using System;

namespace ReadWriteIni
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Hello World!"); 
          INIFile settingsIni = new INIFile (@".\\TestData.ini");
 
            string executionMode = settingsIni.Read ("BrowserName", "BrowserInfo").ToLower ();
            Console.WriteLine (executionMode);
 
            string WebdriverToUse = settingsIni.Read ("WebDriverLocation", "BrowserInfo").ToLower ();
            Console.WriteLine (WebdriverToUse);
            settingsIni.Write("Timeout","400000","BrowserInfo");

            string timeOut = settingsIni.Read ("Timeout", "BrowserInfo");
            Console.WriteLine (timeOut);

            settingsIni.Write("BrowserName","IE","BrowserInfo");

             settingsIni.Write("Url","www.google.com","AppUnderTest");



             
        }
    }
}
