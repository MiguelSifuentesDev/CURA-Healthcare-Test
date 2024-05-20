using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CURA_Healthcare_Test.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CURA_Healthcare_Test.Tests
{
    public class HomePageTest : TestBase
    {
        [Test, Order(1), Description("Verify that the home page title is \"CURA Healthcare Service")]
        public void VerifyHomePageTitle()
        {
            Assert.That("CURA Healthcare Service" == driver.Title);
        }

        [Test, Order(2), Description("Check if clicking the \"Make Appointment\" button redirects to the login page.")]
        public void NavigateToLoginPage()
        {
            driver.FindElement(By.Id("btn-make-appointment")).Click();
            Assert.That(driver.Url.Contains("profile.php#login"));
        }

        [Test, Order(9), Description("Verify the content of the footer on the home page.")]
        public void VerifyPageFooterContent()
        {
            var footer = driver.FindElement(By.TagName("footer"));
            Assert.That(footer.Text.Contains("CURA Healthcare Service"));
        }
    }
}
