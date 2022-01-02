using System;
using System.Collections.Generic;
using Xunit;

namespace FlightPlanner.Tests
{
    public class PlanYourFlightTests
    {
        [Fact]
        public void GetListOfCities_StringArrayOfCities_ShouldReturnListOfUniqueCities()
        {
            //Arrange
            var cities = new[] {"Riga -> Moscow", " Moscow -> Barcelona", "Moscow -> Paris"};
            var expected = new List<string>() {"Riga", "Moscow", "Barcelona", "Paris"};

            //Act
            var actual = PlanYourFlight.GetListOfCities(cities);
            
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void GetPossibleDestinations_Moscow_StringArrayOfCities_ShouldReturnListOfPossibleDestinationsFromMoscow()
        {
            //Arrange
            var departureCity = "Moscow";
            var cities = new[] { "Riga -> Moscow", " Moscow -> Barcelona", "Moscow -> Paris", "Paris -> London" };
            var expected = new List<string>() { "Barcelona", "Paris" };

            //Act
            var actual = PlanYourFlight.GetPossibleDestinations(departureCity, cities);

            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
