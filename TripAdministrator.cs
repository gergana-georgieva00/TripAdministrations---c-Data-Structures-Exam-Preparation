using System;
using System.Collections.Generic;

namespace TripAdministrations
{
    public class TripAdministrator : ITripAdministrator
    {
        private Dictionary<string, Trip> tripsById = new Dictionary<string, Trip>();
        private Dictionary<string, Company> companiesByNames = new Dictionary<string, Company>();

        public void AddCompany(Company c)
        {
            if (companiesByNames.ContainsKey(c.Name))
            {
                throw new ArgumentException();
            }

            companiesByNames.Add(c.Name, c);
        }

        public void AddTrip(Company c, Trip t)
        {
            if (!companiesByNames.ContainsKey(c.Name))
            {
                throw new ArgumentException();
            }

            c.Trips.Add(t);
            t.Company = c;
        }

        public bool Exist(Company c)
            => companiesByNames.ContainsKey(c.Name);

        public bool Exist(Trip t)
            => tripsById.ContainsKey(t.Id);

        public void RemoveCompany(Company c)
        {
            if (!companiesByNames.ContainsKey(c.Name))
            {
                throw new ArgumentException();
            }

            var trips = companiesByNames[c.Name].Trips;
            companiesByNames.Remove(c.Name);

            foreach (var trip in trips)
            {
                tripsById.Remove(trip.Id);
            }
        }

        public IEnumerable<Company> GetCompanies()
            => companiesByNames.Values;

        public IEnumerable<Trip> GetTrips()
            => tripsById.Values;

        public void ExecuteTrip(Company c, Trip t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompaniesWithMoreThatNTrips(int n)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trip> GetTripsWithTransportationType(Transportation t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trip> GetAllTripsInPriceRange(int lo, int hi)
        {
            throw new NotImplementedException();
        }
    }
}
