using System;
using TechTalk.SpecFlow;

namespace Homework.StepDefinitions
{
    [Binding]
    public class LoginStepsSteps
    {
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can login to the site")]
        public void ThenICanLoginToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
