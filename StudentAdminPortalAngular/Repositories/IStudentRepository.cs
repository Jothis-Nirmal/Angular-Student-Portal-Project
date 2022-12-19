using StudentAdminPortalAngular.DataModels;

namespace StudentAdminPortalAngular.Repositories
{
    public interface IStudentRepository
    {
       Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentDetailsById(Guid studentId);
    }
}
