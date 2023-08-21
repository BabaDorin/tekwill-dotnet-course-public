using Microsoft.AspNetCore.Mvc;
using StudentManagement.Interfaces;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    [ApiController] // noun + plural
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpPost]
        [Route("students")] // localhost:7090/students
        public IActionResult Add(Student student)
        {
            studentService.Add(student);

            return Ok();
        }

        [HttpGet]
        [Route("students")]
        public IActionResult GetAll()
        {
            var result = studentService.GetAll();

            return Ok(result);
        }

        [HttpGet]
        [Route("students/{studentId}")]
        // => get all students: HTTP GET => /students
        // => get specific student (by id): HTTP GET => /students/5
        public IActionResult GetById(Guid studentId)
        {
            var result = studentService.Get(studentId);

            return Ok(result);
        }

        [HttpPut]
        [Route("students/{studentId}")] // REST
        public IActionResult Update(
            [FromQuery] Guid studentId,
            [FromBody] Student student)
        {
            studentService.Update(studentId, student);

            return Ok();
        }

        [HttpDelete]
        [Route("students/{studentId}")]
        public IActionResult Delete(Guid studentId)
        {
            studentService.Delete(studentId);

            return NoContent();
        }

    }
}
