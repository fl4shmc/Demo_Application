using AutoMapper;
using DTO.EntityDTO;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Teacher, TeacherDTO>().ReverseMap();
        }
    }
}
