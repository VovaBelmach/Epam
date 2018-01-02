using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace Framework.Pages
{
    class MainPages
    {
        private const string BASE_URL = "https://www.aircanada.com/ca/en/aco/home.html";
        private IWebDriver driver;

        int i;

        [FindsBy(How = How.Id, Using = "origin_focus_0")]
        private IWebElement clickFrom;

        [FindsBy(How = How.Id, Using = "origin_0")]
        private IWebElement inputFrom;

        [FindsBy(How = How.Id, Using = "flightLocationListOrginId0_locationListItem_0")]
        private IWebElement listFrom;

        [FindsBy(How = How.Id, Using = "destination_label_0")]
        private IWebElement clickTo;

        [FindsBy(How = How.Id, Using = "destination_0")]
        private IWebElement inputTo;

        [FindsBy(How = How.Id, Using = "flightLocationListDestinationId0_locationListItem_0")]
        private IWebElement listTo;

        [FindsBy(How = How.Id, Using = "departureDateLabel")]
        private IWebElement blockDepart;

        [FindsBy(How = How.Id, Using = "fligthDepartureDate")]
        private IWebElement dateBlockDepart;

        [FindsBy(How = How.Id, Using = "returnDateLabel")]
        private IWebElement blockReturn;

        [FindsBy(How = How.Id, Using = "fligthReturnDate")]
        private IWebElement dateBlockReturn;

        [FindsBy(How = How.Id, Using = "passengersInputLabel")]
        private IWebElement inputPassenger;

        [FindsBy(How = How.Id, Using = "btnAdultCountSub")]
        private IWebElement removeAdult;

        [FindsBy(How = How.Id, Using = "btnChildCountAdd")]
        private IWebElement inputChild;

        [FindsBy(How = How.Id, Using = "btnAdultCountAdd")]
        private IWebElement inputAdult;

        [FindsBy(How = How.Id, Using = "btnYouthCountAdd")]
        private IWebElement inputYouths;

        [FindsBy(How = How.Id, Using = "btnInfantCountAdd")]
        private IWebElement inputInfants;

        [FindsBy(How = How.Id, Using = "oneWay")]
        private IWebElement inputOneWay;

        [FindsBy(How = How.Id, Using = "multiCity")]
        private IWebElement inputMultiCity;

        [FindsBy(How = How.Id, Using = "btnRemoveTrip")]
        private IWebElement removeTrip;

        [FindsBy(How = How.XPath, Using = "//*[@id='bookingMagnetForm']/fieldset/div[3]/div[1]/div[3]/div[1]")]
        private IWebElement blockDepartMultiCity;

        [FindsBy(How = How.Id, Using = "departure_0")]
        private IWebElement departMultiCity;

        [FindsBy(How = How.Id, Using = "origin_1")]
        private IWebElement inputFromMultiCity;

        [FindsBy(How = How.Id, Using = "flightLocationListOrginId1")]
        private IWebElement listFromMultiCity;

        [FindsBy(How = How.Id, Using = "origin_focus_1")]
        private IWebElement clickFromMultiCity;

        [FindsBy(How = How.Id, Using = "destination_1")]
        private IWebElement inputToMultiCity;

        [FindsBy(How = How.Id, Using = "flightLocationListDestinationId1")]
        private IWebElement listToMultiCity;

        [FindsBy(How = How.Id, Using = "destination_label_1")]
        private IWebElement clickToMultiCity;

        [FindsBy(How = How.XPath, Using = "//*[@id='bookingMagnetForm']/fieldset/div[3]/div[2]/div[3]/div[1]")]
        private IWebElement toBlockDepartMultiCity;

        [FindsBy(How = How.Id, Using = "departure_1")]
        private IWebElement toDepartMultiCity;

        [FindsBy(How = How.Id, Using = "enCAEdition")]
        private IWebElement selectLanguage;

        [FindsBy(How = How.XPath, Using = "//input[@class='search-active-magnet btn btn-primary']")]
        private IWebElement buttonSubmit;

        [FindsBy(How = How.XPath, Using = "//*[@id='bookingMagnetNtpErrorId_0']/div")]
        private IWebElement errorAirport;

        [FindsBy(How = How.XPath, Using = "//*[@id='bookingMagnetPopupErrorId_0']/div")]
        private IWebElement errorDateReturn;

        [FindsBy(How = How.Id, Using = "childErrorContentId")]
        private IWebElement errorNameAirport;

        [FindsBy(How = How.XPath, Using = "//*[@id='fligthPaxErrorId_0']")]
        private IWebElement errorPassenger;

        [FindsBy(How = How.XPath, Using = "//*[@id='fligthPaxErrorId_0']")]
        private IWebElement errorChildren;

        [FindsBy(How = How.XPath, Using = "//*[@id='fligthPaxErrorId_0']")]
        private IWebElement errorInfants;

        [FindsBy(How = How.XPath, Using = "//*[@id='bookingMagnetNtpErrorId_0']/div/div")]
        private IWebElement errorDateDeparn;

        [FindsBy(How = How.XPath, Using = "//*[@id='bookingMagnetPopupErrorId_0']")]
        private IWebElement errorFareType;

        [FindsBy(How = How.XPath, Using = "//*[@id='bookingMagnetNtpErrorId_0']/div/div")]
        private IWebElement errorMultiCity;

        [FindsBy(How = How.XPath, Using = "//*[@id='bookingMagnetPopupErrorId_0']/div[1]")]
        private IWebElement errorBookingInfants;

        public MainPages(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ButtonSearch()
        {
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonSubmit);
        }

        public void SelectLanguage()
        {
            selectLanguage.Click();
        }

        public void FillingFrom(string from)
        {
            clickFrom.Click();
            inputFrom.SendKeys(from);
            listFrom.Click();
        }

        public void FillingFromInvalid(string from)
        {
            clickFrom.Click();
            inputFrom.SendKeys(from);
        }

        public void FillingTo(string to)
        {
            clickTo.Click();
            inputTo.SendKeys(to);
            listTo.Click();
        }

        public void FillingDepartDate(string departDate)
        {
            blockDepart.Click();
            dateBlockDepart.SendKeys(departDate);
        }

        public void FillingReturnDate(string returnDate)
        {
            blockReturn.Click();
            dateBlockReturn.SendKeys(returnDate);
        }

        public void FillingInvalidChildrenSending()
        {
            inputPassenger.Click();
            removeAdult.Click();
            inputChild.Click();
        }

        public void FillingPassengers()
        {
            inputPassenger.Click();
        }

        public void InputChildren()
        {
            for (i = 0; i < 9; i++)
            {
                inputChild.Click();
            }
        }

        public void InputInfants()
        {
            for (i = 0; i < 2; i++)
            {
                inputInfants.Click();
            }
        }

        public void ChooseOneWay()
        {
            inputOneWay.Click();
        }

        public void InputYesterdayDepartDay()
        {
            blockDepart.Click();
            dateBlockDepart.SendKeys(Keys.Left);
            dateBlockDepart.SendKeys(Keys.Enter);
        }

        public void ChooseMultiCity()
        {
            inputMultiCity.Click();
        }

        public void RemoveTrip()
        {
            removeTrip.Click();
        }

        public void FillingMultiCityDepartDate(string departDate)
        {
            blockDepartMultiCity.Click();
            departMultiCity.SendKeys(departDate);
        }

        public void FillingMulticityFrom(string to)
        {
            clickFromMultiCity.Click();
            inputFromMultiCity.SendKeys(to);
            listFromMultiCity.Click();
        }

        public void FillingMulticityTo(string from)
        {
            clickToMultiCity.Click();
            inputToMultiCity.SendKeys(from);
            listToMultiCity.Click();
        }

        public void FillingMultiCityDepartDateReturn(string departDate)
        {
            toBlockDepartMultiCity.Click();
            toDepartMultiCity.SendKeys(departDate);
        }

        public void FillingReturnMultiCityDepartDate(string returnDate)
        {
            toBlockDepartMultiCity.Click();
            toDepartMultiCity.SendKeys(returnDate);
        }

        public void InputPassenger()
        {
            inputAdult.Click();

            for (i = 0; i < 3; i++)
            {
                inputYouths.Click();
            }

            for (i = 0; i < 2; i++)
            {
                inputChild.Click();
            }

            for (i = 0; i < 2; i++)
            {
                inputInfants.Click();
            }
        }

        public bool GetErrorAirport(string error)
        {
            return errorAirport.Text == error;
        }

        public bool GetErrorDate(string error)
        {
            return errorDateReturn.Text == error;
        }

        public bool GetErrorNameAirport(string error)
        {
            return errorNameAirport.Text == error;
        }

        public bool GetErrorPassenger(string error)
        {
            return errorPassenger.Text == error;
        }

        public bool GetErrorChildren(string error)
        {
            return errorChildren.Text.Contains(error);
        }

        public bool GetErrorInfants(string error)
        {
            return errorInfants.Text == error;
        }

        public bool GetErrorDateDepart(string error)
        {
            return errorDateDeparn.Text == error;
        }

        public bool GetErrorFareType(string error)
        {
            return errorFareType.Text == error;
        }

        public bool GetErrorMultiCity(string error)
        {
            return errorMultiCity.Text == error;
        }

        public bool GetErrorBookingInfants(string error)
        {
            return errorBookingInfants.Text.Contains(error);
        }
    }
}
