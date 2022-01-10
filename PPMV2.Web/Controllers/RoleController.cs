#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Repository;
using PPMV2.Core.Infrastructure.RoleRepo;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _repo;


        public RoleController(IRoleRepository repo)
        {
           // _context = context;
           this._repo = repo;
        }

        // GET: api/Roles
        [HttpGet]
        public async Task<IEnumerable<Role>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET: api/Roles/5
        [HttpGet("{id}")]
        public async Task<Role> Get(int id)
        {            
            return await this._repo.GetById(id);
        }

        // PUT: api/Roles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task Put(int id, Role role)
        {
            role.UpdateDate= DateTime.Now;
            await this._repo.Update(role);
        }

        // POST: api/Roles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task Post(Role role)
        {
            role.IsActive= true;
            role.EntryDate= DateTime.Now;
            await this._repo.Add(role);
        }

        // DELETE: api/Roles/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var role = await this._repo.GetById(id);
            await this._repo.Delete(role);
        }
        
    }
}
