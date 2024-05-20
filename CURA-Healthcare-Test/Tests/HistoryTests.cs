using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CURA_Healthcare_Test.Utils;
using OpenQA.Selenium;

namespace CURA_Healthcare_Test.Tests
{
    public class HistoryTests : TestBase
    {
        [Test, Order(6), Description("Check if the user can view their appointment history.")]
        public void VerifyAppointmentHistory()
        {
            driver.FindElement(By.Id("btn-make-appointment")).Click();
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.Id("btn-login")).Click();

            driver.FindElement(By.Id("menu-toggle")).Click();
            driver.FindElement(By.XPath("//nav[@id='sidebar-wrapper']//a[text()='History']")).Click();
            Assert.That(driver.Url.Contains("history"));
        }
    }
}
