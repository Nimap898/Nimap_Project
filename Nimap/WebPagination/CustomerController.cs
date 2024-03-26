using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Net;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using WebApplication5.Models;
using WebApplication5.Dtos;
using AutoMapper.QueryableExtensions;
using WebApplication5.App_Start;
using System.Threading.Tasks;
using WebApplication5.Respone;


namespace WebApplication5.Controllers
{
 
    public class CustomerController : ApiController
    {
       private ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDto>();
                // Add other mappings as needed
            });
            _mapper = mapperConfiguration.CreateMapper();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

     

        public async Task<ResponseInfo> Get(int page,int size)
        {
            ResponseInfo result = new ResponseInfo();

            int skipCount = (page - 1) * size;
            var customer = await _context.Customers.OrderBy(c => c.Id).Skip(skipCount).Take(size).ToListAsync();
            var customerDb = _mapper.Map<List<Customer> ,List<CustomerDto>>(customer);

            if (customerDb.Count > 0)
            {
                 result.setsuccess(customerDb);
            }
            
                return result;
            
        }
        [HttpPost]
        public IHttpActionResult Create(CustomerDto customerDto)
        {

            var customer = _mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id; // Update the ID of the DTO with the generated ID
            return CreatedAtRoute("DefaultApi", new { id = customerDto.Id }, customerDto);


        }

        [HttpGet]
        public IHttpActionResult Get(int id) {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var customerget = _mapper.Map<Customer, CustomerDto>(customer);
            return Ok(customer);
        }

        [HttpPut]
        public IHttpActionResult Update(int id,CustomerDto customerDto) {

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            _mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();

            return Ok();

        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c=>c.Id == id);
            _context.Customers.Remove(customerInDb);

            _context.SaveChanges();

            return Ok("successfully Deleted");
        }

    }
}
