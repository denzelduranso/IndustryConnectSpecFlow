using ICTestProjectNov2020.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ICTestProjectNov2020
{
    public class Tests
    {
        //It will run before the actual test will run.

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);


        }

        //initialize chrome driver
        //Alocate memory to the chrome


        [Test]
        public void VerifyUserCanLogInIntoIC()
        {

            var logInPage = new LoginPage(driver);
            logInPage.LogIn();



            // var code = "New Justice2";

            var randomNumber = new  Random();
            var code = "Code_" + randomNumber.Next(0, 999);

            var randomDescription = new Random();
            var description = "Desc_" + randomDescription.Next(0, 999);

            var CreateNewPage = new CreateNew(driver);
            CreateNewPage.CreateNewPage(code, description);


            var NewCreate = new EditPage(driver);
            NewCreate.FindRecord(code);

        }

        


        [TearDown]
        public void CloseDriver()
        {

            driver.Close();
            driver.Dispose();
        }


    }
}