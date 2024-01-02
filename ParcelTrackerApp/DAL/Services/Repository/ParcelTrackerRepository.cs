using ParcelTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ParcelTrackerApp.DAL.Services.Repository
{
    public class ParcelTrackerRepository : IParcelTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public ParcelTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Parcel> CreateParcel(Parcel parcel)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteParcelById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Parcel> GetAllParcels()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Parcel> GetParcelById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }       

        public async Task<Parcel> UpdateParcel(Parcel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}