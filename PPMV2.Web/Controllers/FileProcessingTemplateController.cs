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

                //item.Tag = this._tagRepo.GetById(item.TagId).Result.TagName;
                //item.Application = this._apprepo.GetById(item.TagId).Result.ApplicationName;
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
            var filesTemplate=await this._repo.GetById(id);
            var tags= _tagRepo.GetAll().Result.Where(x=>x.TagId== filesTemplate.TagId).ToList();
            var applications = _apprepo.GetAll().Result.Where(x => x.ApplicationId == filesTemplate.ApplicationId).ToList();
            filesTemplate.Tags = new List<Tag>();
            filesTemplate.Applications = new List<Application>();
            filesTemplate.Tags= tags;
            filesTemplate.Applications= applications;

            return filesTemplate;
        }

        // GET: api/Tag/5
        [HttpGet("DUPLICATEVALIDATION")]
        public async Task<Message> Get(string FileProcessingTemplateName)
        {
            Message mes = new Message();
            var MES= this._repo.GetAll().Result.FirstOrDefault(X=>X.FileProcessingTemplateName== FileProcessingTemplateName);
            if (MES != null)
            {
                mes.isValidation = true;
                mes.validation = "FileProcessingTemplate Name already in use.";
            }
            else
            {
                mes.isValidation = false;
                mes.validation = "";
            }
            return mes;
        }

        // PUT: api/Tag/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<Message> Put(FileProcessingTemplates fileProcessingTemplates)
        {
            Message mes = new Message();
            var MES = this._repo.GetAll().Result.FirstOrDefault(X => X.FileProcessingTemplateName == fileProcessingTemplates.FileProcessingTemplateName);
            if(MES == null)
            {
                await this._repo.Update(fileProcessingTemplates);
                //  await this._repo.Add(fileProcessingTemplates);
                mes.message = fileProcessingTemplates.Id.ToString();
                mes.isValidation = false;
                mes.Count = 1;
            }
            else
            {
                mes.isValidation = true;
                mes.validation = "FileProcessingTemplate Name already in use.";
            }
            return mes;
        }




        // POST: api/Tag
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Message> Post(FileProcessingTemplates fileProcessingTemplates)
        {
            Message mes = new Message();
            var MES = this._repo.GetAll().Result.FirstOrDefault(X => X.FileProcessingTemplateName == fileProcessingTemplates.FileProcessingTemplateName);
            if (MES == null)
            {
                await this._repo.Add(fileProcessingTemplates);
                mes.message = fileProcessingTemplates.Id.ToString();
                mes.isValidation = false;
                mes.Count = 1;
            }
            else
            {
                mes.isValidation = true;
                mes.validation = "FileProcessingTemplate Name already in use.";
            }
            return mes;
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
