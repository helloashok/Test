using AutoMapper;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Dtos;

namespace Test.ApiHelper
{
    public class Mapper:Profile
    {
       public Mapper()
        {
            CreateMap<AddEmployeeDto, Employee>().ForMember(destination => destination.EmpName, opt => opt.MapFrom(src => src.EmpName))
                 .ForMember(destination => destination.EntryBy, opt => opt.MapFrom(src => src.EntryBy))
                 .ForMember(destination => destination.DOB, opt => opt.MapFrom(src => src.DOB))
                 .ForMember(destination => destination.Gender, opt => opt.MapFrom(src => src.Gender.ToUpper()))
                 
                 .ForMember(destination => destination.Salary, opt => opt.MapFrom(src => src.Salary));

            CreateMap<AddEmployeeQualificationDto, EmployeeQualification>().ForMember(destination => destination.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
               .ForMember(destination => destination.QualificationListId, opt => opt.MapFrom(src => src.QualificationId))
               .ForMember(destination => destination.Marks, opt => opt.MapFrom(src => src.Marks));





            CreateMap<Employee, GetEmployeeDto>().ForMember(destination => destination.EmpName, opt => opt.MapFrom(src => src.EmpName))
                .ForMember(destination => destination.EmployeeId, opt => opt.MapFrom(src => src.id));
                
         



        }
    }
}
