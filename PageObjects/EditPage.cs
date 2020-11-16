using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace ICTestProjectNov2020.PageObjects
{
    public class EditPage
    {
        readonly IWebDriver driver;

        public EditPage(IWebDriver driver)
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



            //class RandomNumberSample

            //static void Main(string[] args)
            //{
            //var generator = new RandomCode();
            //var randomNumber = driver.FindElement(By.Id("Code" + "generator.RandomNumber(5, 100"));


            //var randomString = generator.RandomString(10);
            //var ra



        }
      


    }
}
