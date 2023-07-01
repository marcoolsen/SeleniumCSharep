using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using selenium_csharep.utilities;

namespace selenium_csharep.pageObjects
{
	public class AccountPage
	{
        private IWebDriver driver;

        waitsHelper waits = new waitsHelper();

        public AccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        //Pageobject factory
        [FindsBy(How = How.TagName, Using = "h1")]
        private IWebElement pageTitle;

        [FindsBy(How = How.CssSelector, Using = "#type")]
        private IWebElement accountTypeDD;

        [FindsBy(How = How.TagName, Using = "input")]
        private IWebElement openBtn;

        [FindsBy(How = How.CssSelector, Using = "#newAccountId")]
        private IWebElement newAccountId;


        public string getPageTitle() {
            return pageTitle.Text.Trim();
        }


        public void openSaveAccount()
        {
            var selectElement = new SelectElement(accountTypeDD);
            selectElement.SelectByIndex(1);
            waits.waitForClickablility(By.TagName("input"), 10, driver);
            openBtn.Click();
        }

        public void moveToNewAccountId() {
            waits.waitForClickablility(By.CssSelector("newAccountId"), 10, driver);
            newAccountId.Click();
        }
    }
}

