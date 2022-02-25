using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.FundSch;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundSchedulerController : ControllerBase
    {
        private readonly IFundSchedulerRepository _repo;
        public FundSchedulerController(IFundSchedulerRepository repo)
        {
            this._repo = repo;
        }
        // GET: api/<FundSchedulerController>
        [HttpGet]
        public async Task<IEnumerable<FundScheduler>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET api/<FundSchedulerController>/5
        [HttpGet("{id}")]
        public async Task<FundScheduler> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<FundSchedulerController>
        [HttpPost]
        public async Task Post(FundScheduler FundScheduler)
        {
            try
            {
                //Application.IsActive = true;
                //Application.CreatedDate = DateTime.Now;
                await this._repo.Add(FundScheduler);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<FundSchedulerController>/5
        [HttpPut]
        public async Task Put(FundScheduler FundScheduler)
        {
            try
            {
                //Application.IsActive = true;
                //Application.CreatedDate = DateTime.Now;
                await this._repo.Update(FundScheduler);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<FundSchedulerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            try
            {
                var FundScheduler = await this._repo.GetById(id);
                await this._repo.Delete(FundScheduler);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
