using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CURA_Healthcare_Test.Utils;
using OpenQA.Selenium;

namespace CURA_Healthcare_Test.Tests
{
    public class LoginTests : TestBase
    {
        [Test, Order(3), Description("Ensure that a user can log in with valid credentials")]
        public void SuccessfulLogin() { 
            driver.FindElement(By.Id("btn-make-appointment")).Click();
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.Id("btn-login")).Click();
            Assert.That(driver.Url.Contains("appointment"));
        }
        [Test, Order(4), Description("Verify that an error message is displayed when login with invalid credentials.")]
        public void UnsuccessfulLogin()
        {
            driver.FindElement(By.Id("btn-make-appointment")).Click();
            driver.FindElement(By.Id("txt-username")).SendKeys("Wrong User");
            driver.FindElement(By.Id("txt-password")).SendKeys("WrongPassword");
            driver.FindElement(By.Id("btn-login")).Click();
            Assert.That(driver.FindElement(By.ClassName("text-danger")).Displayed);

        }
        [Test, Order(7), Description("Ensure that a logged-in user can log out.")]
        public void LogoutFromApplication()
        {
            driver.FindElement(By.Id("btn-make-appointment")).Click();
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.Id("btn-login")).Click();
            driver.FindElement(By.Id("menu-toggle")).Click();
            driver.FindElement(By.XPath("//nav[@id='sidebar-wrapper']//a[text()='Logout']")).Click();
            Assert.That(driver.FindElement(By.Id("btn-make-appointment")).Displayed);
        }
    }
}
