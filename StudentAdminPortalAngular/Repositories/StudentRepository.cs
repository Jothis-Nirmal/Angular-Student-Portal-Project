using Microsoft.EntityFrameworkCore;
using StudentAdminPortalAngular.DataModels;

namespace StudentAdminPortalAngular.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _studentAdminContext;
        public StudentRepository(StudentAdminContext studentAdminContext)
        {
            _studentAdminContext = studentAdminContext;
        }

        public async Task<Student> GetStudentDetailsById(Guid studentId)
        {
            return await _studentAdminContext.student.Include(nameof(Gender)).Include(nameof(Address)).FirstOrDefaultAsync(x=>x.Id == studentId);
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _studentAdminContext.student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();

        }
        //public async Task<Student> GetStudent(Guid studentId)
        //{
        //    var student = await _studentAdminContext.student.FindAsync(studentId);

        //    //return await _studentAdminContext.student
        //    //    .Include(nameof(Gender))
        //    //    .Include(nameof(Address))
        //    //    .FirstOrDefaultAsync(x=>x.Id == studentId);
        //}
    }
}
