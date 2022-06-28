using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signup.Pages
{
    internal class Signuppage


    {
        

        public IWebDriver WebDriver { get; }

        public Signuppage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }


        public IWebElement loginlnk => WebDriver.FindElement(By.LinkText("Sign In"));
        public IWebElement singuplnk => WebDriver.FindElement(By.CssSelector("#loginForm > div.form-group.text-center > div > a:nth-child(1)"));


        public IWebElement submit => WebDriver.FindElement(By.CssSelector("#root > div > div.container-fluid.ct-user-container > div > form > div > div:nth-child(2) > div.col-12 > button"));


        public IWebElement lnkavab => WebDriver.FindElement(By.CssSelector("#root > div > div.container-fluid.ct-user-container > div > form > div > div.col-md-6.col-sm-12.row.first-field-set > div.profile-image-container > div > div.avatar-selector > img:nth-child(2)"));

        public IWebElement emaillink => WebDriver.FindElement(By.Id("email"));

        public IWebElement page => WebDriver.FindElement(By.CssSelector("#root > div > div.container-fluid.ct-user-container"));

        public bool iselementexist() => lnkavab.Displayed;

        public void ClickLogin()
        {
            loginlnk.Click();
        }

        public void signup()
        {
            singuplnk.Click();
        }

        public void submitlnk()
        {
            submit.Click();
        }

        public void fieldclick()
        {
            
            
           page.Click();
            emaillink.SendKeys("hellopkr");
        }




       
    }
}
