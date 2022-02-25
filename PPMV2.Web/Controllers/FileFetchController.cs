using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.FFetch;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileFetchController : ControllerBase
    {
        private readonly IFileFetchRepository _repo;


        public FileFetchController(IFileFetchRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<FileFetchController>
        [HttpGet]
        public async Task<IEnumerable<FileFetch>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET api/<FileFetchController>/5
        [HttpGet("{id}")]
        public async Task<FileFetch> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<FileFetchController>
        [HttpPost]
        public async Task Post(FileFetch FileFetch)
        {
            // FileFetch.IsActive = true;
            //FileFetch.CreatedDate = DateTime.Now;
            await this._repo.Add(FileFetch);
        }

        // PUT api/<FileFetchController>/5
        [HttpPut]
        public async Task Put(FileFetch FileFetch)
        {

            //FileFetch.IsActive = true;
            //FileFetch.EntryDate = DateTime.Now;
            // FileFetch.UpdatedDate = DateTime.Now;
            await this._repo.Update(FileFetch);
        }

        // DELETE api/<FileFetchController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var FileFetch = await this._repo.GetById(id);
            await this._repo.Delete(FileFetch);
        }
    }
}
