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
            throw new NotImplementedException();
        }

        public void AddTrip(Company c, Trip t)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Company c)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Trip t)
        {
            throw new NotImplementedException();
        }

        public void RemoveCompany(Company c)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trip> GetTrips()
        {
            throw new NotImplementedException();
        }

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
