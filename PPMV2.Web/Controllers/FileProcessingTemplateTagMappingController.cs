using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.FProcessingTemplateTagMapping;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileProcessingTemplateTagMappingController : ControllerBase
    {
        private readonly IFileProcessingTemplateTagMappingRepository _repo;


        public FileProcessingTemplateTagMappingController(IFileProcessingTemplateTagMappingRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<FileProcessingTemplateTagMappingController>
        [HttpGet]
        public async Task<IEnumerable<FileProcessingTemplateTagMapping>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET api/<FileProcessingTemplateTagMappingController>/5
        [HttpGet("{id}")]
        public async Task<FileProcessingTemplateTagMapping> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<FileProcessingTemplateTagMappingController>
        [HttpPost]
        public async Task Post(FileProcessingTemplateTagMapping FileProcessingTemplateTagMapping)
        {
            // FileProcessingTemplateTagMapping.IsActive = true;
            //FileProcessingTemplateTagMapping.CreatedDate = DateTime.Now;
            await this._repo.Add(FileProcessingTemplateTagMapping);
        }

        // PUT api/<FileProcessingTemplateTagMappingController>/5
        [HttpPut]
        public async Task Put(FileProcessingTemplateTagMapping FileProcessingTemplateTagMapping)
        {

            //FileProcessingTemplateTagMapping.IsActive = true;
            //FileProcessingTemplateTagMapping.EntryDate = DateTime.Now;
            // FileProcessingTemplateTagMapping.UpdatedDate = DateTime.Now;
            await this._repo.Update(FileProcessingTemplateTagMapping);
        }

        // DELETE api/<FileProcessingTemplateTagMappingController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var FileProcessingTemplateTagMapping = await this._repo.GetById(id);
            await this._repo.Delete(FileProcessingTemplateTagMapping);
        }
    }
}
