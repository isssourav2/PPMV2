using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.MenuwithRoleRepo;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuwithRoleController : ControllerBase
    {
        private readonly IMenuwithRoleRepository _repo;


        public MenuwithRoleController(IMenuwithRoleRepository repo)
        {
            // _context = context;
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<RoleMenuMapping>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET: api/RoleMenuMapping/5
        [HttpGet("{id}")]
        public async Task<RoleMenuMapping> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // PUT: api/RoleMenuMapping/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task Put(int id, RoleMenuMapping roleMenuMapping)
        {
            await this._repo.Update(roleMenuMapping);
        }

        // POST: api/RoleMenuMapping
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task Post(RoleMenuMapping roleMenuMapping)
        {
            await this._repo.Add(roleMenuMapping);
        }

        // DELETE: api/RoleMenuMapping/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var role = await this._repo.GetById(id);
            await this._repo.Delete(role);
        }
    }
}
