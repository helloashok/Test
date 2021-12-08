using AutoMapper;
using Data;
using Intermediate.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Dtos;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeQualificationRepository _employeeQualificationRepository;
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeRepository employeeRepository,
            IUnitofWork unitofWork,
            IMapper mapper,
            IEmployeeQualificationRepository employeeQualificationRepository)
        {
            _employeeRepository = employeeRepository;
            _unitofWork = unitofWork;
            _mapper = mapper;
            _employeeQualificationRepository = employeeQualificationRepository;
        }




        [HttpPost("addEmployee")]
        public ActionResult<Boolean> AddEmployee(AddEmployeeDto employee)
        {
           var Employee= _mapper.Map<AddEmployeeDto, Employee>(employee);
            _employeeRepository.Add(Employee);
             foreach( var item in employee.EmployeeQualificationDtos)
            {
                item.EmployeeId = Employee.id;
            }

           var employeeQualifications= _mapper.Map<List<AddEmployeeQualificationDto>, List<EmployeeQualification>>(employee.EmployeeQualificationDtos);

            _employeeQualificationRepository.AddRange(employeeQualifications);

            _unitofWork.Complete();
            return true;
        }


        [HttpGet("getEmployee")]
        public ActionResult<List<GetEmployeeDto>> GetEmployee()
        {
          var employeeList=   _employeeRepository.GetAll();
          var employees=    _mapper.Map<List<Employee>, List<GetEmployeeDto>>(employeeList);
            return employees;
           
        }

        
    }
}
