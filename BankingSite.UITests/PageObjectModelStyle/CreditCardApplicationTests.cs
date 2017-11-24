using System;
using NUnit.Framework;
using BankingSite.UITests.DemoStuff;
using WatiN.Core;

namespace BankingSite.UITests.PageObjectModelStyle
{
    [TestFixture]    
    public class CreditCardApplicationTests
    {
        [Test]
        [STAThread]
        [Category("smoke")]
        public void ShouldShowCorrectApplicantDetailsOnSuccessPage()
        {
              using (var browser = new IE(UiAutomationSettings.ApplyPageUrl))
            {
                var applyPage = browser.Page<ApplyForCreditCardPage>();

                applyPage.ApplyForCreditCard(name: "Jason", age: "30", airlineNumber: "A1234567");

                Assert.That(browser.Url.Contains("ApplicationAccepted.aspx"));

                var acceptedPage = browser.Page<AcceptedPage>();

                Assert.That(acceptedPage.Document.Url.Contains("ApplicationAccepted.aspx"));

                Assert.That(acceptedPage.Name, Is.EqualTo("Jason"));
            }
        }


        public void ShouldShowSuccessPageForValidApplication()
        {
            using(var browser = new IE("https://localhost:62727/Pages/ApplyForCreditCard.aspx"))
            {

                browser.AutoClose = false;
                BrowserDemoHelper.BringToFront(browser);
                browser.TextField(Find.ById("Name")).TypeText("Mark");
                browser.TextField(Find.ById("Age")).TypeText("30");
                browser.TextField(Find.ById("AirlineRewardNumber")).TypeText("A1234567");

                browser.Button(Find.ById("ApplyNow")).Click();

                Assert.That(browser.Url.Contains("ApplicationAccepted.aspx"));

            }
        }


        [Test]
        [STAThread]
        public void ShouldShowValidationErrors()
        {
            using (var browser = new IE(UiAutomationSettings.ApplyPageUrl))
            {
                var applyPage = browser.Page<ApplyForCreditCardPage>();

                applyPage.ApplyForCreditCard(name: "Bob", age: "30", airlineNumber: "BadNumber");
                
                Assert.That(browser.Text.Contains("Airline membership number is invalid"));
            }
        }

        [Test]
        [STAThread]
        public void DummyTest1()
        {
            Assert.Pass();
        }

        [Test]
        [STAThread]
        public void DummyTest2()
        {
            Assert.Pass();
        }

        [Test]
        [STAThread]
        public void DummyTest3()
        {
            Assert.Pass();
        }

        [Test]
        [STAThread]
        public void DummyTest4()
        {
            Assert.Pass();
        }
    }
}
