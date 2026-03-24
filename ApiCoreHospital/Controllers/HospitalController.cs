using ApiCoreHospital.Models;
using ApiCoreHospital.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCoreHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private RepositoryHospital repo;

        public HospitalController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hospital>>> Get()
        {
            return await this.repo.GetHospitalesAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hospital>> FindHospital(int id)
        {
            return await this.repo.FindHospitalIdAsync(id);
        }
    }
}
