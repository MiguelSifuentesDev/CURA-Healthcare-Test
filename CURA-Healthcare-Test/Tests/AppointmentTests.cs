using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CURA_Healthcare_Test.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CURA_Healthcare_Test.Tests
{
    public class AppointmentTests : TestBase
    {
        [Test, Order(5), Description("Verify that a logged-in user can make an appointment.")]
        public void MakeAnAppointment() {
            driver.FindElement(By.Id("btn-make-appointment")).Click();
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.Id("btn-login")).Click();

            new SelectElement(driver.FindElement(By.Id("combo_facility"))).SelectByText("Hongkong CURA Healthcare Center");
            driver.FindElement(By.Id("chk_hospotal_readmission")).Click();
            driver.FindElement(By.Id("radio_program_medicaid")).Click();
            driver.FindElement(By.Id("txt_visit_date")).SendKeys("20/05/2024");
            driver.FindElement(By.Id("txt_comment")).SendKeys("Regular check-up");
            driver.FindElement(By.Id("btn-book-appointment")).Click();

            Assert.That(driver.FindElement(By.XPath("//div[@class='container']//h2")).Text.Contains("Appointment Confirmation"));

        }

        [Test, Order(8), Description("Check the options available in the facilities dropdown on the appointment page.")]
        public void VerifyFacilitiesDropdownOptions()
        {
            driver.FindElement(By.Id("btn-make-appointment")).Click();
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.Id("btn-login")).Click();

            var facilitiesDropdown = new SelectElement(driver.FindElement(By.Id("combo_facility")));
            var options = facilitiesDropdown.Options;
            Assert.That(3 == options.Count);
            Assert.That("Tokyo CURA Healthcare Center" == options[0].Text);
            Assert.That("Hongkong CURA Healthcare Center" == options[1].Text);
            Assert.That("Seoul CURA Healthcare Center" == options[2].Text);
        }

        [Test, Order(10), Description("Check the validation for the appointment date field.")]
        [Ignore("The datepiker auto-format the date to (dd/mm/yyyy)")]
        public void VerifyAppointmentDateFormatValidation()
        {
            driver.FindElement(By.Id("btn-make-appointment")).Click();
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.Id("btn-login")).Click();

            driver.FindElement(By.Id("txt_visit_date")).SendKeys("2024-99-99");
            driver.FindElement(By.Id("btn-book-appointment")).Click();
            var validationMessage = driver.FindElement(By.ClassName("form-control-feedback")).Text;
            Assert.That(validationMessage.Contains("Please enter a valid date"));
        }
    }
}
