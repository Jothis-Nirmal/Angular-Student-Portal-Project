using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortalAngular.DataModels;
using StudentAdminPortalAngular.Repositories;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StudentAdminPortalAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
       private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentsController(IStudentRepository studentRepository,IMapper mapper)
        { 
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        [HttpGet]
       
        public async Task <List<Student>> GetStudentsAsync()
        {
            var students= await _studentRepository.GetStudentsAsync();


            //mapping without using auto mapper package.
            //var domineModelStudents= new List<Student>();

            //foreach (var student in students)
            //{
            //    domineModelStudents.Add(new Student { 

            //       Id = student.Id,
            //       FirstName = student.FirstName,
            //       LastName = student.LastName,
            //       DateOfBearth = student.DateOfBearth,
            //       Email = student.Email,
            //       Mobile = student.Mobile,
            //       ProfileImageUrl = student.ProfileImageUrl,
            //       GenderId = student.GenderId,

            //       Address = new Address()
            //       { 
            //          Id = student.Address.Id,
            //          PhysicalAddress = student.Address.PhysicalAddress,
            //          PostalAddress = student.Address.PostalAddress,
            //       },
            //        Gender = new Gender()
            //        {
            //          Id=student.Gender.Id,
            //          Descreption = student.Gender.Descreption,

            //        }

            //    });
            //}
            return  _mapper.Map<List<Student>>(students);

        }

        [HttpGet("Get Student By Id")]
        public async Task<IActionResult> GetStudent( Guid studentID) 
        {
            var student = await _studentRepository.GetStudentDetailsById(studentID);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(await _studentRepository.GetStudentDetailsById(studentID));
            }
            //return Ok(await _studentRepository.GetStudentDetailsById(studentID));
        }
    }
}
