using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication5.Models;
using WebApplication5.Dtos;

namespace WebApplication5.Controllers
{
    public class MovieController : ApiController
    {
        /* private ApplicationDbContext _context;

         public MovieController()
         {
             _context = new ApplicationDbContext();
         }
         protected override void Dispose(bool disposing)
         {
             _context.Dispose();
         }

         [HttpGet]
         public IHttpActionResult Get()
         {
             var movieInDb = _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);
             return Ok(movieInDb);
         }

         [HttpPost]
         public IHttpActionResult Post(MovieDto movieDto)
         {
             var moiveDb = Mapper.Map<MovieDto, Movie>(movieDto);

             _context.Movies.Add(moiveDb);
             _context.SaveChanges();

             return Ok(movieDto);
         }
         public IHttpActionResult Get(int id)
         {
             var movieGet = _context
                 .Movies
                 .Select(Mapper.Map<Movie,MovieDto>)
                 .FirstOrDefault(x => x.Id == id);

             return Ok(movieGet);
         }

         [HttpPut]
         public IHttpActionResult Update(int id , MovieDto movieDto)
         {
             var movieInDb = _context.Movies.SingleOrDefault(x => x.Id == id);

             Mapper.Map(movieInDb, movieDto);

             return Ok (movieInDb);
         }

         [HttpDelete]    
         public IHttpActionResult Delete(int id) { 

             var moviedelete= _context.Movies.SingleOrDefault(x => x.Id == id);

             _context.Movies.Remove(moviedelete);
             _context.SaveChanges();

             return Ok("successfully Deleted");
         }*/

    }
}
