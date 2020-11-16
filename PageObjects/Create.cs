using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlowHorse.StepDefinition.PageObjects
{
    public class Create
    {
        readonly IWebDriver driver;

        public Create(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CreateNewPage(String code, String description)
        {
            var dropddownAdmin = driver.FindElement(By.XPath("//a[@class='dropdown-toggle' and text()='Administration ']"));
            dropddownAdmin.Click();


            var TimeAndMaterials = driver.FindElement(By.XPath("//a[text()='Time & Materials']"));
            TimeAndMaterials.Click();

            var CreateNew = driver.FindElement(By.XPath("//a[@class='btn btn-primary']"));
            CreateNew.Click();





            ////var dropdownTime = new SelectElement(driver.FindElement(By.XPath("//span[@class='k-widget k-dropdown k-header text-box single-line']")));
            ////dropdownTime.SelectByValue("Time");


            Thread.Sleep(1000);
            var Code = driver.FindElement(By.CssSelector("input[id=Code]"));
            Code.SendKeys(code);

            Thread.Sleep(1000);
            var Desc = driver.FindElement(By.CssSelector("input[id=Description]"));
            Desc.SendKeys(description);

            /*var PricePerUnit = driver.FindElement(By.CssSelector("input[id=Price]"));
            PricePerUnit.SendKeys("5001");*/

            Thread.Sleep(1000);
            var Save = driver.FindElement(By.CssSelector("input[id=SaveButton]"));
            Save.Click();

        }
    }
}
