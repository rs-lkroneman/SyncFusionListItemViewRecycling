using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;

namespace AppiumTest;

public class Tests
{
    private IOSDriver driver;

    [OneTimeSetUp]
    public void Setup()
    {
        var serverUri = new Uri(Environment.GetEnvironmentVariable("APPIUM_HOST") ?? "http://127.0.0.1:4723/");
        var driverOptions = new AppiumOptions
        {
            AutomationName = AutomationName.iOSXcuiTest,
            PlatformName = "iOS",
            DeviceName = "iPhone 15 Pro Max",
        };
        
        // This can be found in the ApplicationId set in the .csproj file
        driverOptions.AddAdditionalAppiumOption("bundleId", "com.companyname.syncfusionlistitemviewrecycling");
        // NoReset assumes the app com.google.android is preinstalled on the emulator
        driverOptions.AddAdditionalAppiumOption("noReset", true);
        driver = new IOSDriver(serverUri, driverOptions, TimeSpan.FromSeconds(180));
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }
    
    [OneTimeTearDown]
    public void TearDown()
    {
        driver.Dispose();
    }

    [Test]
    public void ItFindsHelloWold()
    {
        // Arrange
        driver.FindElement(By.XPath("//*[@name=\"OK\"]")).Click();
        // var helloWorldElement = driver.FindElement(By.Id("CounterButton"));
        // helloWorldElement.Click();
        // helloWorldElement.Click();
        // helloWorldElement.Click();
        // helloWorldElement.Click();
        // helloWorldElement.Click();
        // helloWorldElement.Click();
    }
}