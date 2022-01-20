using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.SourceRepo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SourceController : ControllerBase
    {
        private readonly ISourceRepository _repo;
        

        public SourceController(ISourceRepository sourceRepository)
        {
            _repo = sourceRepository;
        }

        // GET: api/<SourceController>
        [HttpGet]
        public async Task<IEnumerable<Source>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET api/<SourceController>/5
        [HttpGet("{id}")]
        public async Task<Source> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<SourceController>
        [HttpPost]
        public async Task Post(Source source)
        {
            source.IsActive = true;
            source.EntryDate = DateTime.Now;
            await this._repo.Add(source);
        }

        // PUT api/<SourceController>/5
        [HttpPut]
        public async Task Put(Source source)
        {
            
            source.IsActive=true;
            //source.EntryDate = DateTime.Now;
            source.UpdateDate = DateTime.Now;
            await this._repo.Update(source);
        }

        // DELETE api/<SourceController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var source = await this._repo.GetById(id);
            await this._repo.Delete(source);
        }
    }
}
