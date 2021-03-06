﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DattingAppf.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext Context;

        public ValuesController(DataContext context)
        {        
            Context = context;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var value = await Context.Values.ToListAsync();

            return Ok(value);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Getvalue(int id)
        {
            return Ok(await Context.Values.FirstOrDefaultAsync(x => x.Id == id)) ;

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}