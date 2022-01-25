using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.SchedulerSettingRepo;
using PPMV2.Web.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulerSettingController : ControllerBase
    {
        private readonly ISchedulerSettingRepository _repo;
        public SchedulerSettingController(ISchedulerSettingRepository repo)
        {
            this._repo = repo;
        }
       

        // GET api/<SchedulerSettingController>/5
        [HttpGet]
        public async Task<Response> Get()
        {
            try
            {
                var response = new Response();
                response.Message = this._repo.GetAll().Result.FirstOrDefault() != null ? this._repo.GetAll().Result.FirstOrDefault().Id : 0;
                response.TotalCount = this._repo.GetAll().Result.ToList().Count();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST api/<SchedulerSettingController>
        [HttpPost]
        public async Task Post(SchedulerSetting schedulerSetting)
        {
            try
            {
                schedulerSetting.EntryDate = DateTime.Now;
                await this._repo.Add(schedulerSetting);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<SchedulerSettingController>/5
        [HttpPut]
        public async Task Put(SchedulerSetting schedulerSetting)
        {
            try
            {
                schedulerSetting.UpdateDate = DateTime.Now;
                await this._repo.Update(schedulerSetting);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
    }
}
