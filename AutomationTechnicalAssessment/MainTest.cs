using System.Collections.ObjectModel;
using AutomationTechnicalAssessment.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V128.FedCm;
using OpenQA.Selenium.DevTools.V128.Network;
using OpenQA.Selenium.Remote;

namespace AutomationTechnicalAssessment
{
    public class Tests
    {

        private IWebDriver driver;
              

        [Test]
        public void MatchingEngineTest() 
        {
            // Creating a new instance of the Webdriver 
            IWebDriver driver = new ChromeDriver();

            // Navigate to the URL and maximize browser window
            driver.Navigate().GoToUrl("https://www.matchingengine.com");
            driver.Manage().Window.Maximize();

            // Initialize the Page Calss to use methods here
            NavigatorPage navigatorPage = new NavigatorPage(driver);

            // Call methods from Navigator Page class to execute tests
            navigatorPage.ClickOnModulesHeaderOption();
            navigatorPage.ClickOnRepertoireManagementModuleOption();
            navigatorPage.ScrollToAdditionalFeaturesSection();
            navigatorPage.ClickOnProductsSupportedTab();
            Thread.Sleep(2000);
            
            // Assert List of Products under Products Supported Section
            IList<IWebElement> webElements = new List<IWebElement>();
            webElements = driver.FindElements(By.XPath("//h3[contains(text(),'There are several types of Product Supported:')]/parent::div/descendant::ul/li/span"));
            List<string> productList = ["Cue Sheet / AV Work", "Recording", "Bundle", "Advertisement"];
            for (int i = 1; i <= webElements.Count; i++)
            {
                By product = By.XPath("(//h3[contains(text(),'There are several types of Product Supported:')]/parent::div/descendant::ul/li/span)[" + i + "]");
                Assert.That(driver.FindElement(product).Text.Trim(), Is.EqualTo(productList[i - 1]));
                Console.WriteLine(productList[i - 1] + " has been asserted");
            }

            // Terminate the Browser session on completion of Tests
            driver.Quit();
        }  
  
    }
}