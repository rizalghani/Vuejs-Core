using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIJ.Data;
using SIJ.Models;

namespace SIJ.Controllers
{
    public class BugController : ControllerBase
    {
        private readonly SIJDB _context;

        public BugController(SIJDB context)
        {
            _context = context;
        }

        [Route("/bug")]
        [HttpGet]
        public IActionResult Get()
        {
            var model = _context.Bugs;
            return Ok(model);
        }

        [Route("/bug/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            var model = _context.Bugs.Find(id);
            return Ok(model);
        }

        [Route("/bug")]
        [HttpPost]
        public IActionResult Post(Bug model)
        {
            _context.Bugs.Add(model);
            _context.SaveChanges();

            return Ok(model);
        }

        [Route("/bug")]
        [HttpPut]
        public IActionResult Put(Bug model)
        {
            var bug = _context.Bugs.Find(model.Id);
            bug.Name = model.Name;
            bug.Description = model.Description;

            _context.Bugs.Update(bug);
            _context.SaveChanges();

            return Ok(model);
        }

        [Route("/bug")]
        [HttpDelete]
        public IActionResult Delete(Bug model)
        {
            var bug = _context.Bugs.Find(model.Id);

            _context.Bugs.Remove(bug);
            _context.SaveChanges();

            return Ok(model);
        }
    }
}
