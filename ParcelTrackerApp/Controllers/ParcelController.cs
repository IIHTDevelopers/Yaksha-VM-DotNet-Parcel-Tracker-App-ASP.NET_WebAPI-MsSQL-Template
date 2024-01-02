using ParcelTrackerApp.DAL.Interrfaces;
using ParcelTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ParcelTrackerApp.Controllers
{
    public class ParcelController : ApiController
    {
        private readonly IParcelTrackerService _service;
        public ParcelController(IParcelTrackerService service)
        {
            _service = service;
        }
        public ParcelController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Parcel/CreateParcel")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateParcel([FromBody] Parcel model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Parcel/UpdateParcel")]
        public async Task<IHttpActionResult> UpdateParcel([FromBody] Parcel model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Parcel/DeleteParcel")]
        public async Task<IHttpActionResult> DeleteParcel(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Parcel/GetParcelById")]
        public async Task<IHttpActionResult> GetParcelById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Parcel/GetAllParcels")]
        public async Task<IEnumerable<Parcel>> GetAllParcels()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
