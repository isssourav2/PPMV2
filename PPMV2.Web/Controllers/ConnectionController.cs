using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.ConnectionRepo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionController : ControllerBase
    {
        private readonly IConnectionRepository _repo;
        public ConnectionController(IConnectionRepository repo)
        {
            this._repo = repo;
        }
        // GET: api/<ConnectionController>
        [HttpGet]
        public async Task<IEnumerable<Connection>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET api/<ConnectionController>/5
        [HttpGet("{id}")]
        public async Task<Connection> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<ConnectionController>
        [HttpPost]
        public async Task Post(Connection connection)
        {
            try
            {
                //Application.IsActive = true;
                //Application.CreatedDate = DateTime.Now;
                await this._repo.Add(connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<ConnectionController>/5
        [HttpPut]
        public async Task Put(Connection connection)
        {
            try
            {
                //Application.IsActive = true;
                //Application.CreatedDate = DateTime.Now;
                await this._repo.Update(connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<ConnectionController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            try
            {
                var Connection = await this._repo.GetById(id);
                await this._repo.Delete(Connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
