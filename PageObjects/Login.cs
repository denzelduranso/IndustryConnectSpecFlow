using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowHorse.StepDefinition.PageObjects
{
    public class Login
    {



        readonly IWebDriver driver;

            public Login(IWebDriver driver)
            {
                this.driver = driver;
            }
            public void LogIn()

        { 
            //driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Link of website : Horse Portal - Navigate to the House Portal It's Url

            //Username 
            var username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");


            var password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");



            var loginBtn = driver.FindElement(By.CssSelector("input[type=submit]"));
            loginBtn.Click();
        }
    }
}
