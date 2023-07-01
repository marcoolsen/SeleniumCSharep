using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace selenium_csharep.pageObjects
{
	public class HomePage
	{
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Pageobject factory
        [FindsBy(How = How.Id, Using = "headerPanel")]
        private IWebElement homePageId;

        [FindsBy(How = How.LinkText, Using = "Open New Account")]
        private IWebElement openAccountBtn;

        public IWebElement getPageHeader() {
            return homePageId;

        }

        public void moveToAccount() {
            openAccountBtn.Click();
        }

    }
}

