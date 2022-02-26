using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.EmailSettingRepo;
using PPMV2.Web.Utility;
using PPMV2.Web.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailSettingController : ControllerBase
    {
        private readonly IEmailSettingRepository _repo;
        private string key = "zB064QlTzhrrNqBlGh5ibIzdYGsqHleZ";
        public EmailSettingController(IEmailSettingRepository repo)
        {
            this._repo = repo;
        }
        // GET: api/<EmailSettingController>


        // GET api/<EmailSettingController>/5
        [HttpGet]
        public async Task<EmailSetting>Get()
        {
            EmailSetting emailSetting = new EmailSetting();
            try
            {
                //var response = new ViewModel.Response();
                //response.Message = this._repo.GetAll().Result.FirstOrDefault() != null ? this._repo.GetAll().Result.FirstOrDefault().Id : 0;
                //response.TotalCount = this._repo.GetAll().Result.ToList().Count();
                //return response;
               
                var data = await this._repo.GetAll();

                if(data.Count()>0)
                {
                    emailSetting.Id = data.FirstOrDefault().Id;
                    emailSetting.From = data.FirstOrDefault().From;
                    emailSetting.Host = data.FirstOrDefault().Host;
                    emailSetting.Port = data.FirstOrDefault().Port;
                    emailSetting.UserName = data.FirstOrDefault().UserName;
                    emailSetting.To = data.FirstOrDefault().To;
                }
                //emailSetting.Enabled = data.FirstOrDefault()..Enabled;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return emailSetting;
        }

        //[HttpGet("GetEmailSetting")]
        //public async Task<EmailSetting> GetEmailSetting()
        //{
        //    try
        //    {
        //        return await this._repo.GetAll().Result.FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        // POST api/<EmailSettingController>
        [HttpPost]
        public async Task Post(EmailSetting emailSettings)
        {
            try
            {
                emailSettings.Password = EncryptDecrypt.Instance.Encrypts(emailSettings.Password, key);

                await this._repo.Add(emailSettings);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<EmailSettingController>/5
        [HttpPut]
        public async Task Put(EmailSetting emailSettings)
        {
            try
            {
                //emailSetting.UpdatedDate = DateTime.Now;
                emailSettings.Password = EncryptDecrypt.Instance.Encrypts(emailSettings.Password, key);
                await this._repo.Update(emailSettings);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
