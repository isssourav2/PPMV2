using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.FManipulation;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileManipulationController : ControllerBase
    {
        private readonly IFileManipulationRepository _repo;


        public FileManipulationController(IFileManipulationRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<FileManipulationController>
        [HttpGet]
        public async Task<IEnumerable<FileManipulation>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET api/<FileManipulationController>/5
        [HttpGet("{id}")]
        public async Task<FileManipulation> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<FileManipulationController>
        [HttpPost]
        public async Task Post(FileManipulation FileManipulation)
        {
            // FileManipulation.IsActive = true;
            //FileManipulation.CreatedDate = DateTime.Now;
            await this._repo.Add(FileManipulation);
        }

        // PUT api/<FileManipulationController>/5
        [HttpPut]
        public async Task Put(FileManipulation FileManipulation)
        {

            //FileManipulation.IsActive = true;
            //FileManipulation.EntryDate = DateTime.Now;
            // FileManipulation.UpdatedDate = DateTime.Now;
            await this._repo.Update(FileManipulation);
        }

        // DELETE api/<FileManipulationController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var FileManipulation = await this._repo.GetById(id);
            await this._repo.Delete(FileManipulation);
        }
    }
}
