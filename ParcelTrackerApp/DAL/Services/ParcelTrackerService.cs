using ParcelTrackerApp.DAL.Interrfaces;
using ParcelTrackerApp.DAL.Services.Repository;
using ParcelTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ParcelTrackerApp.DAL.Services
{
    public class ParcelTrackerService : IParcelTrackerService
    {
        private readonly IParcelTrackerRepository _repository;

        public ParcelTrackerService(IParcelTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Parcel> CreateParcel(Parcel parcel)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteParcelById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Parcel> GetAllParcels()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Parcel> GetParcelById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Parcel> UpdateParcel(Parcel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}