using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.PageObjects
{
    class Loginpage
    {
        //driver.FindElement(By.LinkText("Login")
        [FindsBy(How = How.LinkText, Using = "Login")]
        private OpenQA.Selenium.IWebElement login;

        
        public void ClickLogin()
        {
            login.Click();
        }
}