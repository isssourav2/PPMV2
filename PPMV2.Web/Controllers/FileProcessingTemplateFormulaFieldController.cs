using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.FileProcessingTemplateFormulaFieldRepo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileProcessingTemplateFormulaFieldController : ControllerBase
    {
        private readonly IFileProcessingTemplateFormulaFieldRepository _repo;

        public FileProcessingTemplateFormulaFieldController(IFileProcessingTemplateFormulaFieldRepository repo)
        {
            this._repo= repo;
        }

        // GET: api/<FileProcessingTemplateFormulaFieldController>
        [HttpGet]
        public async Task<IEnumerable<FileProcessingTemplateFormulaField>> Get()
         {
            return await this._repo.GetAll();
        }

        // GET api/<FileProcessingTemplateFormulaFieldController>/5
        [HttpGet("{id}")]
        public async Task<FileProcessingTemplateFormulaField> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<FileProcessingTemplateFormulaFieldController>
        [HttpPost]
        public async Task Post(FileProcessingTemplateFormulaField obj)
        {
            await this._repo.Add(obj);
        }

        // PUT api/<FileProcessingTemplateFormulaFieldController>/5
        [HttpPut]
        public async Task Put(FileProcessingTemplateFormulaField obj)
        {
            await this._repo.Update(obj);
        }

        // DELETE api/<FileProcessingTemplateFormulaFieldController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var data= await this._repo.GetById(id);
            await this._repo.Delete(data);
        }
    }
}
