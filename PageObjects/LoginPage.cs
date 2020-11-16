using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICTestProjectNov2020.PageObjects
{
    public class LoginPage
    {
        readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LogIn()

        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Link of website : Horse Portal - Navigate to the House Portal It's Url

            //Username 
            var username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");



            var password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");



            var loginBtn = driver.FindElement(By.CssSelector("input[type=submit]"));
            loginBtn.Click();



            //var dropwdowns = driver.FindElements(By.CssSelector("li[class=dropdown] a[data-toggle=dropdown]"));

            //var isHariPresent = false;

            //foreach (var dropdown in dropwdowns)

            //{
            //    if (dropdown.Text == "Hello hari!")
            //    {
            //        isHariPresent = true;
            //        break;
            //    }
            //}

            //Assert.IsTrue(isHariPresent);
        }






    }
}
