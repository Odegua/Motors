using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Motorsproject.Stepdefinitions
{
    [Binding]
    public sealed class ProductDetailsSteps
    {
        IWebDriver driver;
        IWebElement agreeButton;
        IWebElement postcodeField;
        IWebElement carMake;

        [Given(@"I navigate to Motors homepage")]
        public void GivenINavigateToMotorsHomepage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.motors.co.uk/");
            driver.Manage().Window.Maximize();

            agreeButton = driver.FindElement(By.ClassName("banner_continue--2NyXA"));
            agreeButton.Click();
        }

        [When(@"enter postcode and I select the make of the car")]
        public void WhenEnterPostcodeAndISelectTheMakeOfTheCar()
        {
            postcodeField = driver.FindElement(By.Name("PostCode"));
            postcodeField.SendKeys("M11 2DL");
        }

        [When(@"I select the model of the car")]
        public void WhenISelectTheModelOfTheCar()
        {
            carMake = driver.FindElement(By.Name("Make"));
            SelectElement select = new SelectElement(carMake);
            select.SelectByText("Audi");
        }

        [When(@"I click on the search button")]
        public void WhenIClickOnTheSearchButton()
        {
        }

        [When(@"I click the first car from the result")]
        public void WhenIClickTheFirstCarFromTheResult()
        {
            
        }

        [Then(@"the price of the car is displayed")]
        public void ThenThePriceOfTheCarIsDisplayed()
        {
            
        }

    }
}
