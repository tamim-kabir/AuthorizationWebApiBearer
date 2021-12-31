using ApplicationData.DTOs;
using ApplicationData.Models.StudentsModels;
using AutoMapper;

namespace ApplicationDataAccess.MapingProfile
{
    public class ModelMapingProfile : Profile
    {
        public ModelMapingProfile()
        {
            //Source --> Destination
            CreateMap<Student, StudentDTO>();
            //Destiation --> Source 
            CreateMap<StudentDTO, Student>();
        }
    }
}
