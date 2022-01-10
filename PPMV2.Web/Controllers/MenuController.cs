using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.MenuRepo;

namespace PPMV2.Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuRepository _repo;


        public MenuController(IMenuRepository repo)
        {
            // _context = context;
            this._repo = repo;
        }

        // GET: api/Tag
        [HttpGet]
        public async Task<IEnumerable<MenuMaster>> Get()
        {
            return await this._repo.GetAll();
        }
    }
}
