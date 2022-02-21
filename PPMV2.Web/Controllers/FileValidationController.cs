using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.FileValid;

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileValidationController : ControllerBase
    {
        private readonly IFileValidationRepository _repo;

        public FileValidationController(IFileValidationRepository repo)
        {
            this._repo = repo;
        }

        // GET: api/FileValidations
        [HttpGet]
        public async Task<IEnumerable<FileValidation>> Get()
        {
            try
            {
                return await this._repo.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/FileValidations/5
        [HttpGet("{id}")]
        public async Task<FileValidation> Get(int id)
        {
            try
            {
                return await this._repo.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/FileValidations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task Put(FileValidation FileValidation)
        {
            try
            {
                // FileValidation.UpdatedDate = DateTime.Now;
                await this._repo.Update(FileValidation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public async Task Post(FileValidation FileValidation)
        {
            try
            {
                //FileValidation.IsActive = true;
                //FileValidation.CreatedDate = DateTime.Now;
                await this._repo.Add(FileValidation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE: api/FileValidations/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            try
            {
                var FileValidation = await this._repo.GetById(id);
                await this._repo.Delete(FileValidation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
