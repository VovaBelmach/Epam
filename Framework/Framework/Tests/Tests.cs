using System;
using NUnit.Framework;

namespace Framework.Tests
{
    class Tests
    {
        private static Steps.Steps steps = new Steps.Steps();
        string from = "Calgary";
        string invalidFrom = "Calgaryy";
        string to = "Moscow";
        string departDate = DateTime.Today.ToShortDateString();
        string returnDate = DateTime.Today.AddDays(4).ToShortDateString();
        string returnDateEmpty = string.Empty;
        string yesterday = DateTime.Today.AddDays(-1).ToShortDateString();

        private const string missing_airport_error_message = "The departure and arrival airports you've selected " +
            "are one and the same. Please review your selection and try again.";
        private const string missing_airport_date_return_message = "The dates you've selected don't appear to be " +
            "valid. Please make any necessary corrections and try your search again.";
        private const string airporn_name_error_message = "We can't seem to locate the point of origin you've entered. " +
            "Please try again. Note: When you enter a country, state, province or city name in the search field, " +
            "a choice of airports will be displayed.";
        private const string missing_passenger_message = "Children under age 8 must travel with an adult age 16 or older." +
            " Children ages 8 to 11 can travel alone but you'll need to contact Air Canada Reservations at least 48 " +
            "hours before departure to purchase their ticket and request our Unaccompanied Minor service.";
        private const string missing_children_message = "You have selected more than 9 passengers.";
        private const string missing_infants_message = "Only one infant per adult is permitted. You have " +
            "indicated that 2 children are travelling with 1 adult(s). Please make any necessary corrections " +
            "before proceeding.";
        private const string missing_airport_date_depart_message = "The departure date/time has to be at least" +
            " 2 hours before departure. Please verify your entry and try again.";
        private const string missing_fary_type_message = "Please select a fare type from the drop-down " +
            "menu located directly beneath your flights.";
        private const string missing_multicity_message = "The return date/time has to be at least 2 hours " +
            "before departure. Please verify your entry and try again.";
        private const string missing_booking_infants_message = "To include an infant in your booking, please call " +
            "Air Canada Reservations after you've booked your flight online (this applies to international flights as " +
            "well as travel to/from the U.S).";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void TestInvalidArrivalAirport()
        {
            steps.SearchCaseOne(from, from, departDate, returnDate);
            Assert.IsTrue(steps.GetErrorAirport(missing_airport_error_message));
        }

        [Test]
        public void TestInvalidReturnDate()
        {
            steps.SearchCaseTwo(from, to, departDate, returnDateEmpty);
            Assert.IsTrue(steps.GetErrorDate(missing_airport_date_return_message));
        }

        [Test]
        public void TestInvalidAirport()
        {
            steps.SearchCaseThree(invalidFrom, to, departDate, returnDate);
            Assert.IsTrue(steps.GetErrorNameAirport(airporn_name_error_message));
        }

        [Test]
        public void TestInvalidChildrenSending()
        {
            steps.SearchCaseFour(from, to, departDate, returnDate);
            Assert.IsTrue(steps.GetErrorPassenger(missing_passenger_message));
        }

        [Test]
        public void TestInvalidNumberOfPassengers()
        {
            steps.SearchCaseFive(from, to, departDate, returnDate);
            Assert.IsTrue(steps.GetErrorChildren(missing_children_message));
        }

        [Test]
        public void TestInvalidNumberOfInfantsPerAdult()
        {
            steps.SearchCaseSex(from, to, departDate, returnDate);
            Assert.IsTrue(steps.GetErrorInfants(missing_infants_message));
        }

        [Test]
        public void TestInvalidDepartDate()
        {
            steps.SearchCaseSeven(from, to);
            Assert.IsTrue(steps.GetErrorDateDepart(missing_airport_date_depart_message));
        }

        [Test]
        public void TestInvalidFareType()
        {
            steps.SearchCaseEight(from, to, departDate);
            Assert.IsTrue(steps.GetErrorFareType(missing_fary_type_message));
        }

        [Test]
        public void TestInvalidDate()
        {
            steps.SearchCaseNine(from, to, departDate);
            Assert.IsTrue(steps.GetErrorMultiCity(missing_multicity_message));
        }

        [Test]
        public void TestIncludeInfants()
        {
            steps.SearchCaseTen(from, to, departDate, returnDate);
            Assert.IsTrue(steps.GetErrorBookingInfants(missing_booking_infants_message));
        }
    }
}
