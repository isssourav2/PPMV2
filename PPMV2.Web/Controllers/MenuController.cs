using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.MenuRepo;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository _repo;


        public MenuController(IMenuRepository repo)
        {
            // _context = context;
            this._repo = repo;
        }

        // GET: api/Menu
        [HttpGet]
        public async Task<IEnumerable<MenuMaster>> Get()
        {
            return await this._repo.GetAll();
        }
    }
}
