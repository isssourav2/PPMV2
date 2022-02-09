using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.RiskCoreTemplates;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiskCoreTemplateController : ControllerBase
    {

        private readonly IRiskCoreTemplateRepository _repo;
        public RiskCoreTemplateController(IRiskCoreTemplateRepository repo)
        {
            this._repo = repo;
        }
        // GET: api/<RiskCoreTemplateController>
        [HttpGet]
        public async Task<IEnumerable<RiskCoreImportTemplate>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET api/<RiskCoreTemplateController>/5
        [HttpGet("{id}")]
        public async Task<RiskCoreImportTemplate> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<RiskCoreTemplateController>
        [HttpPost]
        public async Task Post(RiskCoreImportTemplate riskCoreImportTemplate)
        {
            try
            {
                //Application.IsActive = true;
                //Application.CreatedDate = DateTime.Now;
                await this._repo.Add(riskCoreImportTemplate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<RiskCoreTemplateController>/5
        [HttpPut]
        public async Task Put(RiskCoreImportTemplate riskCoreImportTemplate)
        {
            await this._repo.Update(riskCoreImportTemplate);
        }

        // DELETE api/<RiskCoreTemplateController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var riskCoreImportTemplate = await this._repo.GetById(id);
            await this._repo.Delete(riskCoreImportTemplate);
        }
    }
}
