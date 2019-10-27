using D_Blood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using D_Blood.Dtos;

namespace D_Blood.Controllers.Api
{
    public class RegisterDonorController : ApiController
    {

        private ApplicationDbContext _context;
        public RegisterDonorController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpGet]
        public IHttpActionResult GetDonors()
        {
            var donorsDtos = _context.RegisterDonors.ToList()
                .Select(Mapper.Map <RegisterDonor, RegisterDonorDto>);
            return Ok(donorsDtos);
        }

        public IHttpActionResult GetDonor(int id)
        {
            var dr = _context.RegisterDonors.SingleOrDefault(d => d.Id == id);
            if (dr == null)
                return NotFound();
            return Ok(Mapper.Map<RegisterDonor, RegisterDonorDto>(dr));
        }

        public IHttpActionResult AddDonor(RegisterDonorDto rdto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var dr = Mapper.Map<RegisterDonorDto, RegisterDonor>(rdto);
            _context.RegisterDonors.Add(dr);
            _context.SaveChanges();

            rdto.Id = dr.Id;
            return Created(new Uri(Request.RequestUri + "/" + dr.Id), rdto);
        }
    }
}
