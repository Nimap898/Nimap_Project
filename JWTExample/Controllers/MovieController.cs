using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication5.Models;
using WebApplication5.Dtos;
using System.Threading.Tasks;
using WebApplication5.Respone;

namespace WebApplication5.Controllers
{
    [Authorize]
    public class MovieController : ApiController
    {
        private ApplicationDbContext _context;
        private readonly IMapper _mapper;

         public MovieController()
         {
             _context = new ApplicationDbContext();
            var mapperCnfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Movie,MovieDto>();
            });
            _mapper = mapperCnfiguration.CreateMapper();
         }
         protected override void Dispose(bool disposing)
         {
             _context.Dispose();
         }

         [HttpGet]
         public async Task<ResponseInfo> Get(int page , int size)
         {
            ResponseInfo result = new ResponseInfo();

            int skipCount = (page - 1) * size;
            var movie =  _context.Movies.OrderBy(c => c.Id).Skip(skipCount).Take(size).ToList();
            var movieInDb =  _mapper.Map<List<Movie>,List<MovieDto>>(movie);
            
            if(movieInDb.Count > 0)
            {
                result.setsuccess(movieInDb);
            }
            return result;
         }

         [HttpPost]
         public IHttpActionResult Post(MovieDto movieDto)
         {
             var moiveDb = _mapper.Map<MovieDto, Movie>(movieDto);


             _context.Movies.Add(moiveDb);
             _context.SaveChanges();

             return Ok(movieDto);
         }
         public IHttpActionResult Get(int id)
         {
             var movieGet = _context
                 .Movies
                 .FirstOrDefault(x => x.Id == id);

            var movieInDb = _mapper.Map<Movie,MovieDto>(movieGet);

             return Ok(movieInDb);
         }

         [HttpPut]
         public IHttpActionResult Update(int id , MovieDto movieDto)
         {
             var movieInDb = _context.Movies.SingleOrDefault(x => x.Id == id);

              _mapper.Map(movieInDb, movieDto);

             return Ok (movieInDb);
         }

         [HttpDelete]    
         public IHttpActionResult Delete(int id) { 

             var moviedelete= _context.Movies.SingleOrDefault(x => x.Id == id);

             _context.Movies.Remove(moviedelete);
             _context.SaveChanges();

             return Ok("successfully Deleted");
         }

    }
}
