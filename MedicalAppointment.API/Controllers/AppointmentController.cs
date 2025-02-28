using MedicalAppointment.Persistence.Interfaces.Appointments;
using Microsoft.AspNetCore.Mvc;


namespace MedicalAppointment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentsRepository _Repository;
        public AppointmentController(IAppointmentsRepository Repository)
        {
            _Repository = Repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _Repository.GetAllAsync();
            return StatusCode(StatusCodes.Status200OK , new {value = result});
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _Repository.GetEntityByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, new { value = result });
        }


        [HttpPost]
        public async Task<IActionResult> Post(Domain.Entities.Appointments.Appointments appointments)
        {
            var result = await _Repository.SaveEntityAsync(appointments);
            return StatusCode(StatusCodes.Status200OK, new { value = result });
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
