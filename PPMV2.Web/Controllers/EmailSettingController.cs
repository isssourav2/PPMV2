using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.EmailSettingRepo;
using PPMV2.Web.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailSettingController : ControllerBase
    {
        private readonly IEmailSettingRepository _repo;
        public EmailSettingController(IEmailSettingRepository repo)
        {
           this._repo = repo;
        }
        // GET: api/<EmailSettingController>
      

        // GET api/<EmailSettingController>/5
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

        // POST api/<EmailSettingController>
        [HttpPost]
        public async Task Post(EmailSetting emailSetting)
        {
            try
            {
                emailSetting.EntryDate = DateTime.Now;
                await this._repo.Add(emailSetting);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<EmailSettingController>/5
        [HttpPut]
        public async Task Put(EmailSetting emailSetting)
        {
            try
            {
                emailSetting.UpdateDate = DateTime.Now;
                await this._repo.Update(emailSetting);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
