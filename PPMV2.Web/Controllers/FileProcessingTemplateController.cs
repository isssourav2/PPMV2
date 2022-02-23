using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.ApplicationRepo;
using PPMV2.Core.Infrastructure.FileProcessingTemplateRepo;
using PPMV2.Core.Infrastructure.RiskCoreTemplates;
using PPMV2.Core.Infrastructure.TagRepo;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileProcessingTemplateController : ControllerBase
    {
        private readonly IFileProcessingTemplate _repo;
        private IApplicationRepository _apprepo;
        private ITagRepository _tagRepo;
        private IRiskCoreTemplateRepository _riskCoreRepo;

        public FileProcessingTemplateController(IFileProcessingTemplate repo, IApplicationRepository apprepo, ITagRepository tagRepo, IRiskCoreTemplateRepository _riskRepo)
        {
            // _context = context;
            this._repo = repo;
            this._apprepo=apprepo;
            this._tagRepo=tagRepo;
            this._riskCoreRepo = _riskRepo;
        }

        // GET: api/Tag
        [HttpGet]
        public async Task<IEnumerable<FileProcessingTemplates>> Get()
        {
            List<FileProcessingTemplates> FileProcessTems = new List<FileProcessingTemplates>();
            IEnumerable<FileProcessingTemplates> filepTemplates = await this._repo.GetAll();
            foreach (var item in filepTemplates)
            {
                //FileProcessingTemplates temp1 = new FileProcessingTemplates();

                item.Tag = this._tagRepo.GetById(item.TagId).Result.TagName;
                item.Application = this._apprepo.GetById(item.TagId).Result.ApplicationName;
               //item.RiskCoreTemplate = this._riskCoreRepo.GetById(item.RiskCoreTemplateId).Result.Name;
                FileProcessTems.Add(item);
            }
            return FileProcessTems; 
            //return await this._repo.GetAll();
        }

        // GET: api/Tag/5
        [HttpGet("{id}")]
        public async Task<FileProcessingTemplates> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // PUT: api/Tag/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task Put(FileProcessingTemplates tag)
        {
            await this._repo.Update(tag);
        }

        // POST: api/Tag
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task Post(FileProcessingTemplates tag)
        {
            await this._repo.Add(tag);
        }

        // DELETE: api/Tag/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var role = await this._repo.GetById(id);
            await this._repo.Delete(role);
        }
    }
}
