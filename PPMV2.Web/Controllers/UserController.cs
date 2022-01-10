using Microsoft.AspNetCore.Mvc;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.UserRepo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PPMV2.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repo;

        public UserController(IUserRepository repo)
        {
            //Repo Object
            this._repo = repo; 
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await this._repo.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await this._repo.GetById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task Post(User user)
        {
            user.IsActive = true;
            user.EntryDate = DateTime.Now;
            await this._repo.Add(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, User user)
        {
            user.UpdateDate = DateTime.Now;
            await this._repo.Update(user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var user = await this._repo.GetById(id);
            await this._repo.Delete(user);
        }
    }
}
