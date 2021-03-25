using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyTestProject.Utilities;

namespace UdemyTestProject.PageObject
{
    class SignUpPage
    {

        public SignUpPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));

        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement signUp => driver.FindElement(By.CssSelector("body > div.ng-scope > div > div > div > div > div > form > fieldset > button"));

        IWebElement popularTags => driver.FindElement(By.XPath("//p[text()='Popular Tags']"));







        public void EnterUsername()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            username.SendKeys("UdemyTest" + randomInt);
        }

        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            email.SendKeys("udemy" + randomInt + "@yahoo.com");
        }

        public void EnterPasword()
        {
            password.SendKeys("PasswordSecure");
        }

        public void ClickSignUpButton()
        {
            signUp.Click();
        }

        public bool IsPopularTagsDisplayed()
        {
            return popularTags.Displayed;
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/register");
        }








    }
}
