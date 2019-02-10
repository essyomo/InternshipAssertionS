using System;
using TechTalk.SpecFlow;

namespace Homework.StepDefinitions
{
    [Binding]
    public class RegistrationStepsSteps
    {
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter fisrtname")]
        public void WhenIEnterFisrtname()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter lastname")]
        public void WhenIEnterLastname()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter wrong password ""(.*)""")]
        public void WhenIEnterWrongPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I confirm password ""(.*)""")]
        public void WhenIConfirmPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be  register")]
        public void ThenIShouldBeRegister()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should not be registered")]
        public void ThenIShouldNotBeRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
