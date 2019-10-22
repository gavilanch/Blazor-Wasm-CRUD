using BlazorCRUDApp.Server.Helpers;
using BlazorCRUDApp.Shared.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PeopleController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PeopleController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Person>>> Get([FromQuery] PaginationDTO pagination, 
            [FromQuery] string name)
        {
            var queryable = context.People.AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                queryable = queryable.Where(x => x.Name.Contains(name));
            }
            await HttpContext.InsertPaginationParameterInResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }

        [HttpGet("{id}", Name ="GetPerson")]
        [AllowAnonymous]
        public async Task<ActionResult<Person>> Get(int id)
        {
            return await context.People.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Person person)
        {
            context.Add(person);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetPerson", new { id = person.Id }, person);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Person person)
        {
            context.Entry(person).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var person = new Person { Id = id };
            context.Remove(person);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
