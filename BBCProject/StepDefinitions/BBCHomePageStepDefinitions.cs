using BBCProject.Hooks;
using BBCProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BBCProject.StepDefinitions
{
    [Binding]
    public class BBCHomePageStepDefinitions : BaseTest
    {
        BBCHomePage bBCHomePage = new BBCHomePage();

        [Given(@"a user navigate to the website ""([^""]*)""")]
        public void GivenAUserNavigateToTheWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        [When(@"a user click on sport menu")]
        public void WhenAUserClickOnSportMenu()
        {
            bBCHomePage.ClickSportMenu();
        }

        [Then(@"sport page is displayed")]
        public void ThenSportPageIsDisplayed()
        {
            Assert.IsTrue(bBCHomePage.SportPagelsDisplayed());
        }

    }

}
