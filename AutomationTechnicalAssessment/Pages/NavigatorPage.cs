using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTechnicalAssessment.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;

namespace AutomationTechnicalAssessment.Pages
{
    internal class NavigatorPage
    {
        private readonly IWebDriver driver;

        public NavigatorPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        IWebElement ModulesHeaderOption => driver.FindElement(By.XPath("//a[contains(text(),'Modules')]"));
        IWebElement RMMOption => driver.FindElement(By.XPath("//a[contains(text(),'Repertoire Management Module')]"));
        IWebElement AdditionalFeatures => driver.FindElement(By.XPath("//h2[contains(text(),'Additional Features')]/parent::div/div/span"));
        IWebElement ProductSupportedTab => driver.FindElement(By.XPath("//div[@class='vc_tta-tabs-container']/descendant::a/span[contains(text(),'Products Supported')]"));

        // Find Modules Header Option and Click to Expand
        public void ClickOnModulesHeaderOption()
        {
            ActionMethods.ClickElement(driver, ModulesHeaderOption);
            Thread.Sleep(1000);
        }

        // Find Repertoire Management Module Option in Modules dropdown and Click to Select
        public void ClickOnRepertoireManagementModuleOption()
        {
            ActionMethods.ClickElement(driver, RMMOption);
            Thread.Sleep(1000);
        }
       
        // Find and Scroll to the Additional Features Section 
        public void ScrollToAdditionalFeaturesSection()
        {
            ActionMethods.ScrollToElementUsingJS(driver, AdditionalFeatures);
            Thread.Sleep(1000);
        }

        // Find Products Supported Tab and Click to Select
        public void ClickOnProductsSupportedTab()
        {
            ActionMethods.ClickElement(driver, ProductSupportedTab);
            Thread.Sleep(1000);
        }

       
    }
}
