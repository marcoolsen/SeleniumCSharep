using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace selenium_csharep.utilities
{
	public class waitsHelper
	{
        public WebElement waitForClickablility(By locator, int timeout, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            return (WebElement)wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}

