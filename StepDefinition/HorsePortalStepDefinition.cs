using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowHorse.StepDefinition.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowHorse.StepDefinition
{
    [Binding]
    public class HorsePortalStepDefinition
    {
        IWebDriver driver;


        [BeforeScenario(Order =0)]
        public void Setup()
        {
            
            var options = new ChromeOptions();
            options.AddArgument("---headless");

            
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);



        }

        [BeforeScenario(Order = 1)]

        [Given(@"I navigate to the Portal")]
        public void GivenINavigateToThePortal()
        {

            //var headless = new ChromeOptions();
            //headless.AddArguments({"--silent-launch",
            //                        "--no-startup-window",
            //                            "no-sandbox",
            //                            "headless",});

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            
            

        }
        [BeforeScenario(Order = 2)]

        [When(@"I add credentials to the Login Page and click submit btn")]
        public void WhenIAddCredentialsToTheLoginPageAndClickSubmitBtn()
        {
            var logInPage = new Login(driver);
            logInPage.LogIn();
        }



        [BeforeScenario(Order = 3)]

        [Then(@"I create a TM Record")]
        public void ThenICreateATMRecord()
        {
            var randomNumber = new Random();
            var code = "Code_" + randomNumber.Next(0, 999);

            var randomDescription = new Random();
            var description = "Desc_" + randomDescription.Next(0, 999);

            var CreateNewPage = new Create(driver);
            CreateNewPage.CreateNewPage(code, description);
        }
        [BeforeScenario(Order = 4)]

        [Then(@"Edit the last new created TM Record")]
        public void ThenEditTheLastNewCreatedTMRecord(String code)
        {
            Thread.Sleep(5000);

            var NewCreate = new Edit(driver);
            NewCreate.FindRecord(code);

        }


        [AfterScenario]

        public void CloseDriver()
        {

            driver.Close();
            driver.Dispose();
        }




    }
    }




