using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Signup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Signup.Steps
{
    [Binding]
    internal class Signup
    {
        Signuppage signupt = null;

        [Given(@"open page")]
        public void GivenOpenPage()
        {
            IWebDriver WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl("https://www.executeautomation.com/");
            signupt = new Signuppage(WebDriver);
            //
            //
        }
        [Given(@"select sigin")]
        public void GivenSelectSigin()
        {
            signupt.ClickLogin();
        }

        [Given(@"select signuplink")]
        public void GivenSelectSignuplink()
        {
            signupt.signup();
        }


        [Given(@"click on submit button")]
        public void GivenClickOnSubmitButton()
        {
            signupt.submitlnk();
        }

        [Given(@"click on email field and enter something")]
        public void GivenClickOnEmailFieldAndEnterSomething()
        {
            signupt.fieldclick();
        }


        [Then(@"validation prompt appear")]
        public void ThenValidationPromptAppear()
        {

           
            Assert.That(signupt.iselementexist(),Is.True);
        }

    }
}
