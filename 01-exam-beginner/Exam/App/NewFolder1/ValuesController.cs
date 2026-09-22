using LinqWhereCountEfBeginner;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace App.NewFolder1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly StudentQueryService _studentQueryService;

        public ValuesController(AppDbContext dbContext)
        {
            _studentQueryService = new StudentQueryService(dbContext);
        }

        [HttpGet("SuccessfulStudents")]

        public async Task<IActionResult> GetSuccessfulStudents()
        {
            List<Student> students = await _studentQueryService.GetSuccessfulStudentsAsync();

            return Ok(students);
        }
        [HttpGet("FailedStudents")]

        public async Task<IActionResult> CountFailedStudent()
        {
            int count = await _studentQueryService.CountFailedStudentsAsync();

            return Ok(count);
        }
        [HttpGet("ActiveStudents")]

        public async Task<IActionResult> ActiveStudentsAsync()
        {
            List<Student> students = await _studentQueryService.GetActiveStudentsAsync();

            return Ok(students);
        }
        [HttpGet("CountStudentsInCity")]

        public async Task<IActionResult> CountStudentsInCity(string city)
        {
            int students = await _studentQueryService.CountStudentsInCityAsync(city);

            return Ok(students);
        }
    }
}
