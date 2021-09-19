using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestSELENIUM
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el objeto para que maneje el navegador
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.Manage().Window.Maximize(); //**


        }
    }
}
