using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTechnicalAssessment.Utilities
{
    public class ActionMethods
    {
        // Action method to Click on Element
        public static void ClickElement(IWebDriver driver, IWebElement element)
        {
            element.Click();
        }

        // Action Method to Scroll to Element
        public static void ScrollToElementUsingJS(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
            js.ExecuteScript("window.scrollBy(0,-50)", "");
        }


    }
}
