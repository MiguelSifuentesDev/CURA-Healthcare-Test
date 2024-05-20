using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CURA_Healthcare_Test.Utils
{
    public class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup() {
            var driverPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Drivers");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://katalon-demo-cura.herokuapp.com/");
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
