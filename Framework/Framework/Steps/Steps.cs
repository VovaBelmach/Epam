using OpenQA.Selenium;
using System;
using Framework.Pages;

namespace Framework.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void SearchCaseOne(string from, string to, string departDate, string returnDate)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            mainPage.OpenPage();
            mainPage.SelectLanguage();
            mainPage.FillingFrom(from);
            mainPage.FillingTo(to);
            mainPage.FillingDepartDate(departDate);
            mainPage.FillingReturnDate(returnDate);
            mainPage.ButtonSearch();
        }

        public void SearchCaseTwo(string from, string to, string departDate, string returnDate)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            mainPage.OpenPage();
            mainPage.SelectLanguage();
            mainPage.FillingFrom(from);
            mainPage.FillingTo(to);
            mainPage.FillingDepartDate(departDate);
            mainPage.FillingReturnDate(returnDate);
            mainPage.ButtonSearch();
        }

        public void SearchCaseThree(string from, string to, string departDate, string returnDate)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            mainPage.OpenPage();
            mainPage.SelectLanguage();
            mainPage.FillingFromInvalid(from);
            mainPage.FillingTo(to);
            mainPage.FillingDepartDate(departDate);
            mainPage.FillingReturnDate(returnDate);
            mainPage.ButtonSearch();
        }

        public void SearchCaseFour(string from, string to, string departDate, string returnDate)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            mainPage.OpenPage();
            mainPage.SelectLanguage();
            mainPage.FillingFrom(from);
            mainPage.FillingTo(to);
            mainPage.FillingDepartDate(departDate);
            mainPage.FillingReturnDate(returnDate);
            mainPage.FillingInvalidChildrenSending();
        }

        public void SearchCaseFive(string from, string to, string departDate, string returnDate)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            mainPage.OpenPage();
            mainPage.SelectLanguage();
            mainPage.FillingFrom(from);
            mainPage.FillingTo(to);
            mainPage.FillingDepartDate(departDate);
            mainPage.FillingReturnDate(returnDate);
            mainPage.FillingPassengers();
            mainPage.InputChildren();
        }

        public void SearchCaseSex(string from, string to, string departDate, string returnDate)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            mainPage.OpenPage();
            mainPage.SelectLanguage();
            mainPage.FillingFrom(from);
            mainPage.FillingTo(to);
            mainPage.FillingDepartDate(departDate);
            mainPage.FillingReturnDate(returnDate);
            mainPage.FillingPassengers();
            mainPage.InputInfants();
        }

        public void SearchCaseSeven(string from, string to)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            mainPage.OpenPage();
            mainPage.SelectLanguage();
            mainPage.ChooseOneWay();
            mainPage.FillingFrom(from);
            mainPage.FillingTo(to);
            mainPage.InputYesterdayDepartDay();
            mainPage.ButtonSearch();
        }

        public void SearchCaseEight(string from, string to, string departDate)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            mainPage.OpenPage();
            mainPage.SelectLanguage();
            mainPage.ChooseMultiCity();
            mainPage.RemoveTrip();
            mainPage.FillingFrom(from);
            mainPage.FillingTo(to);
            mainPage.FillingMultiCityDepartDate(departDate);
            mainPage.ButtonSearch();
        }

        public void SearchCaseNine(string from, string to, string departDate)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            mainPage.OpenPage();
            mainPage.SelectLanguage();
            mainPage.ChooseMultiCity();
            mainPage.FillingFrom(from);
            mainPage.FillingTo(to);
            mainPage.FillingMultiCityDepartDate(departDate);
            mainPage.FillingMulticityFrom(to);
            mainPage.FillingMulticityTo(from);
            mainPage.FillingMultiCityDepartDateReturn(departDate);
            mainPage.ButtonSearch();
        }

        public void SearchCaseTen(string from, string to, string departDate, string returnDate)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            mainPage.OpenPage();
            mainPage.SelectLanguage();
            mainPage.ChooseMultiCity();
            mainPage.FillingFrom(from);
            mainPage.FillingTo(to);
            mainPage.FillingMultiCityDepartDate(departDate);
            mainPage.FillingMulticityFrom(to);
            mainPage.FillingMulticityTo(from);
            mainPage.FillingMultiCityDepartDateReturn(returnDate);
            mainPage.FillingPassengers();
            mainPage.InputPassenger();
            mainPage.ButtonSearch();
        }

        public bool GetErrorAirport(string errorMessage)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            return mainPage.GetErrorAirport(errorMessage);
        }

        public bool GetErrorDate(string errorMessage)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            return mainPage.GetErrorDate(errorMessage);
        }

        public bool GetErrorNameAirport(string errorMessage)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            return mainPage.GetErrorNameAirport(errorMessage);
        }

        public bool GetErrorPassenger(string errorMessage)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            return mainPage.GetErrorPassenger(errorMessage);
        }

        public bool GetErrorChildren(string errorMessage)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            return mainPage.GetErrorChildren(errorMessage);
        }

        public bool GetErrorInfants(string errorMessage)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            return mainPage.GetErrorInfants(errorMessage);
        }

        public bool GetErrorDateDepart(string errorMessage)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            return mainPage.GetErrorDateDepart(errorMessage);
        }

        public bool GetErrorFareType(string errorMessage)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            return mainPage.GetErrorFareType(errorMessage);
        }

        public bool GetErrorMultiCity(string errorMessage)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            return mainPage.GetErrorMultiCity(errorMessage);
        }

        public bool GetErrorBookingInfants(string errorMessage)
        {
            Pages.MainPages mainPage = new Pages.MainPages(driver);
            return mainPage.GetErrorBookingInfants(errorMessage);
        }

    }
}
