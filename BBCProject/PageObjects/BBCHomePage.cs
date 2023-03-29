using BBCProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCProject.PageObjects
{
     class BBCHomePage:BaseTest
     {

        private By sportMenu = By.XPath("//*[@id=\"header-content\"]/nav/div[1]/div/div[2]/ul[2]/li[3]/a/span");


        public void ClickSportMenu()
        {
            driver.FindElement(sportMenu).Click();


       
        }
        public bool SportPagelsDisplayed()
        {
            return driver.Url.Contains("www.bbc.co.uk/sport");

        }
     }


   


}
