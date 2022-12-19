using AutoMapper;
using StudentAdminPortalAngular.DataModels;
using DataModels = StudentAdminPortalAngular.DomaneModels;

namespace StudentAdminPortalAngular.Profiles
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>();

            CreateMap<DataModels.Gender, Gender>();

            CreateMap<DataModels.Address, Address>();
        }

    }
}
