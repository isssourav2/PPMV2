using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.FProcessingTemplateDMSApplication;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileProcessingTemplateDMSApplicationController : ControllerBase
    {
        private readonly IFileProcessingTemplateDMSApplicationRepository _repo;


        public FileProcessingTemplateDMSApplicationController(IFileProcessingTemplateDMSApplicationRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<FileProcessingTemplateDMSApplicationController>
        [HttpGet]
        public async Task<IEnumerable<FileProcessingTemplateDMSApplication>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET api/<FileProcessingTemplateDMSApplicationController>/5
        [HttpGet("{id}")]
        public async Task<FileProcessingTemplateDMSApplication> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<FileProcessingTemplateDMSApplicationController>
        [HttpPost]
        public async Task Post(FileProcessingTemplateDMSApplication FileProcessingTemplateDMSApplication)
        {
            // FileProcessingTemplateDMSApplication.IsActive = true;
            //FileProcessingTemplateDMSApplication.CreatedDate = DateTime.Now;
            await this._repo.Add(FileProcessingTemplateDMSApplication);
        }

        // PUT api/<FileProcessingTemplateDMSApplicationController>/5
        [HttpPut]
        public async Task Put(FileProcessingTemplateDMSApplication FileProcessingTemplateDMSApplication)
        {

            //FileProcessingTemplateDMSApplication.IsActive = true;
            //FileProcessingTemplateDMSApplication.EntryDate = DateTime.Now;
            // FileProcessingTemplateDMSApplication.UpdatedDate = DateTime.Now;
            await this._repo.Update(FileProcessingTemplateDMSApplication);
        }

        // DELETE api/<FileProcessingTemplateDMSApplicationController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var FileProcessingTemplateDMSApplication = await this._repo.GetById(id);
            await this._repo.Delete(FileProcessingTemplateDMSApplication);
        }
    }
}
