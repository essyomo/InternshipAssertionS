using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Homework.Utilies
{
    [Binding]
    public sealed class Hooks
    {
         ChromeDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
          //ChromeDriver driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
