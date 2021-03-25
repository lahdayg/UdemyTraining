using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using UdemyTestProject.PageObject;

namespace UdemyTestProject.StepDefinition
{
    [Binding]
    public class SignUpSteps
    {
        SignUpPage signUpPage;

        public SignUpSteps()
        {
            signUpPage = new SignUpPage();
        }









        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            signUpPage.NavigateToWebsite();

        }
        
        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            signUpPage.EnterUsername();
        }
        
        [Given(@"I enter my Email")]
        public void GivenIEnterMyEmail()
        {
            signUpPage.EnterEmail();
        }
        
        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            signUpPage.EnterPasword();
        }
        
        [When(@"I click on Sign up")]
        public void WhenIClickOnSignUp()
        {
            signUpPage.ClickSignUpButton();
        }
        
        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(signUpPage.IsPopularTagsDisplayed);
        }
    }
}
