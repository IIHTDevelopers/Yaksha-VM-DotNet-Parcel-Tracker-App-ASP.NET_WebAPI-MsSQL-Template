﻿using ParcelTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelTrackerApp.DAL.Services.Repository
{
    public interface IParcelTrackerRepository
    {
        List<Parcel> GetAllParcels();
        Task<Parcel> CreateParcel(Parcel parcel);
        Task<Parcel> GetParcelById(long id);
        Task<bool> DeleteParcelById(long id);
        Task<Parcel> UpdateParcel(Parcel model);
    }
}

