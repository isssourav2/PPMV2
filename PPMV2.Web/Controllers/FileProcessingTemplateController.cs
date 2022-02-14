using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.FileProcessingTemplateRepo;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileProcessingTemplateController : ControllerBase
    {
        private readonly IFileProcessingTemplate _repo;


        public FileProcessingTemplateController(IFileProcessingTemplate repo)
        {
            // _context = context;
            this._repo = repo;
        }

        // GET: api/Tag
        [HttpGet]
        public async Task<IEnumerable<FileProcessingTemplates>> Get()
        {
            return await this._repo.GetAll();
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
