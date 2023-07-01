using selenium_csharep.utilities;
using selenium_csharep.pageObjects;

namespace selenium_csharep;

public class Tests : Base
{
    [Test, TestCaseSource("AddTestDataConfig"), Category("Smoke")]
    public void OpenNewAccount(String username, String password)
    {
        LoginPage loginPage = new LoginPage(getDriver());
        HomePage homePage = new HomePage(getDriver());
        AccountPage accountPage = new AccountPage(getDriver());
        loginPage.DoLogin(username, password);
        Assert.IsNotNull(homePage.getPageHeader());
        homePage.moveToAccount();
        //Console.WriteLine(accountPage.getPageTitle());
        accountPage.getPageTitle().Contains( "Open New Account");
        accountPage.openSaveAccount();
        accountPage.getPageTitle().Contains("Account Opened!");
        accountPage.moveToNewAccountId();
        accountPage.getPageTitle().Contains("Account Details");
    }

    public static IEnumerable<TestCaseData> AddTestDataConfig()
    {
        yield return new TestCaseData(getDataParser().extractData("username"), getDataParser().extractData("password"));

    }
}
