using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.FPassword;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilePasswordController : ControllerBase
    {
        private readonly IFilePasswordRepository _repo;


        public FilePasswordController(IFilePasswordRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<FilePasswordController>
        [HttpGet]
        public async Task<IEnumerable<FilePassword>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET api/<FilePasswordController>/5
        [HttpGet("{id}")]
        public async Task<FilePassword> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<FilePasswordController>
        [HttpPost]
        public async Task Post(FilePassword FilePassword)
        {
           // FilePassword.IsActive = true;
            //FilePassword.CreatedDate = DateTime.Now;
            await this._repo.Add(FilePassword);
        }

        // PUT api/<FilePasswordController>/5
        [HttpPut]
        public async Task Put(FilePassword FilePassword)
        {

            //FilePassword.IsActive = true;
            //FilePassword.EntryDate = DateTime.Now;
            // FilePassword.UpdatedDate = DateTime.Now;
            await this._repo.Update(FilePassword);
        }

        // DELETE api/<FilePasswordController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var FilePassword = await this._repo.GetById(id);
            await this._repo.Delete(FilePassword);
        }
    }
}
