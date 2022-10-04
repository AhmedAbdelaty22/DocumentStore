using BackEnd.Models;
using BackEnd.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriorityController : ControllerBase
    {
        private readonly IPriorityRepository priorityRepository;

        public PriorityController(IPriorityRepository _prioRepo)
        {
            priorityRepository = _prioRepo;
        }

        [HttpGet("GetAllPriorites")]
        public IActionResult GetAllPriorites()
        {
            List<Priority> documentModel = priorityRepository.GetAll();
            return Ok(documentModel);
        }
    }
}
