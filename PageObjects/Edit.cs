using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlowHorse.StepDefinition.PageObjects
{


    public class Edit
    {
        readonly IWebDriver driver;

        public Edit(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FindRecord(String description)
        {
            Thread.Sleep(1000);
            var NewCreate = driver.FindElement(By.XPath("//span[text()='Go to the last page']"));
            NewCreate.Click();

            Thread.Sleep(500);
            var tableRow = driver.FindElement(By.XPath("//td[text()='" + description + "']//ancestor::tr"));


            var edit = tableRow.FindElement(By.XPath("//a[text()='Edit']"));
            var delete = tableRow.FindElement(By.XPath("//a[text()='Delete']"));

            edit.Click();
            delete.Click();

            Thread.Sleep(5000);

        }
    }
}