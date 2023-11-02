using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ctrlspec.Repository;
using ctrlspec.Services;
using Microsoft.AspNetCore.Authorization;
using ctrlspec.Models; // Add the Authorization namespace

namespace ctrlspec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize] // Apply authorization to this controller

    public class ClientController : ControllerBase
    {
        private readonly IClient _context;
        private readonly ApplicationService _applicationService;

        public string? C_Id { get; private set; }
        public string? AppId { get; private set; }

        public ClientController(IClient context, ApplicationService applicationService)
        {
            _context = context;
            _applicationService = applicationService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var admins = await _context.GetAll();
            if (admins == null)
            {
                return NotFound();
            }
            return Ok(admins);
        }

        [HttpGet("{Id}")]
        [Authorize(Roles = "Client")]
        public async Task<ActionResult<Application>> GetByID(int Id)
        {
            var app = await _context.GetByID(Id);
            if (app == null)
            {
                return NotFound();
            }
            return Ok(app);
        }

        [HttpPost]
        public async Task<ActionResult<Application>> AddApplications(Application application)
        {
            var add = await _context.Add(application);

            if (add == null) // Change "application" to "add" for the null check
            {
                return BadRequest();
            }
            return Ok(add);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> Update(int Id, Application application)
        {
            var app = await _context.Update(Id, application);
            return CreatedAtAction(nameof(GetByID), new { id = application.C_Id }, app);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            await _context.Delete(Id);
            return Ok();
        }

        // Route for getting client data by appId
        [HttpGet("clientdata/{C_Email}")]
        //[Authorize(Roles = "Client")]

        public async Task<IActionResult> GetClientData(string C_Email)
        {
            var clientData = await _applicationService.GetClientDataByClientIdAsync(C_Email);

            if (clientData == null)
            {
                return NotFound(); // Client data not found
            }

            return Ok(clientData); // Return client data
        }

    }
}
