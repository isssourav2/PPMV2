using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.ApplicationRepo;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationRepository _repo;

        public ApplicationController(IApplicationRepository repo)
        {
            this._repo = repo;
        }

        // GET: api/Applications
        [HttpGet]
        public async Task<IEnumerable<Application>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET: api/Applications/5
        [HttpGet("{id}")]
        public async Task<Application> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // PUT: api/Applications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task Put(Application Application)
        {
           // Application.UpdatedDate = DateTime.Now;
            await this._repo.Update(Application);
        }
        //get user by Application Id
        //[HttpGet("GetUserByApplicationId/{Applicationid}")]
        //public async Task<Message> GetUsrByApplicationId(int Applicationid)
        //{
        //    return await this..GetUserCountByApplicationId(Applicationid);
        //}
        // POST: api/Applications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task Post(Application Application)
        {
            try
            { 
                //Application.IsActive = true;
                //Application.CreatedDate = DateTime.Now;
                await this._repo.Add(Application);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE: api/Applications/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var Application = await this._repo.GetById(id);
            await this._repo.Delete(Application);
        }
    }
}
