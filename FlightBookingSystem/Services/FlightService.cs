using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightBookingSystem.Models;

namespace FlightBookingSystem.Services
{
    public class FlightService
    {
        private List<Flight> flights;

        public FlightService()
        {
            // Initialize with some dummy data
            flights = new List<Flight>
            {
                new Flight { Id = 1, Airline = "Airline A", Origin = "City A", Destination = "City B", DepartureTime = DateTime.Now.AddHours(2), ArrivalTime = DateTime.Now.AddHours(5), Price = 200 },
                new Flight { Id = 2, Airline = "Airline B", Origin = "City B", Destination = "City C", DepartureTime = DateTime.Now.AddHours(3), ArrivalTime = DateTime.Now.AddHours(6), Price = 300 },
                new Flight { Id = 3, Airline = "Airline C", Origin = "City A", Destination = "City C", DepartureTime = DateTime.Now.AddHours(4), ArrivalTime = DateTime.Now.AddHours(7), Price = 400 }
            };
        }

        public Task<List<Flight>> SearchFlightsAsync(string origin, string destination, DateTime departureDate, DateTime returnDate)
        {
            var result = flights.Where(f => f.Origin == origin && f.Destination == destination && f.DepartureTime.Date == departureDate.Date).ToList();
            return Task.FromResult(result);
        }

        public Task<Flight> GetFlightByIdAsync(int flightId)
        {
            var flight = flights.FirstOrDefault(f => f.Id == flightId);
            return Task.FromResult(flight);
        }

        public Task<bool> BookFlightAsync(int flightId, User user)
        {
            // Implement booking logic here
            return Task.FromResult(true);
        }
    }
}
