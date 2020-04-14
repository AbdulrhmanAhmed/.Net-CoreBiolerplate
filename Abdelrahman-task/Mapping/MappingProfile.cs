using Abdelrahman_task.Core.Models;
using Abdelrahman_task.Dto;
using Abdelrahman_task.Dto.FucaltyDto;
using AutoMapper;
using System;

namespace Abdelrahman_task.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>()
                       .ForMember(x => x.Age, opt => opt.MapFrom(c => DateTime.Now.Year-c.BirthDate.Year))
                       .ForMember(x => x.FucaltyName, opt => opt.MapFrom(c =>c.Fucalty.Name))
                ;
            CreateMap<CreateStudentDto, Student>();
            CreateMap<UpdateStudentDto, Student>();
            // Fucalties
            CreateMap<Fucalty, FuclatyDto>();
            CreateMap<FuclatyDto, Fucalty>();


        }
    }
}
