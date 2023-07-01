using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace selenium_csharep.pageObjects
{
	public class LoginPage
	{
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        //Pageobject factory
        [FindsBy(How = How.CssSelector, Using = "input[name='username']")]
        private IWebElement username;

        [FindsBy(How = How.CssSelector, Using = "input[name='password']")]
        private IWebElement password;

        [FindsBy(How = How.CssSelector, Using = "input.button")]
        private IWebElement loginBtn;

        public void DoLogin(string user, string pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            loginBtn.Click();
        }

        public IWebElement getUserName()

        {
            return username;
        }
    }
}

