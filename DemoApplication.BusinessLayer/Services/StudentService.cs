using AutoMapper;
using DemoApplicaiton.DataAccessLayer.Repository.Interfaces;
using DemoApplication.BusinessLayer.Interfaces;
using DTO.EntityDTO;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.BusinessLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            this._studentRepository = studentRepository;
            this._mapper = mapper;
        }

        public List<StudentDTO> GetAll()
        {
            List<Student> studentList = this._studentRepository.GetAll().ToList();
            List<StudentDTO> studentDTOList = new List<StudentDTO>();

            foreach (var student in studentList)
            {
                studentDTOList.Add(_mapper.Map<StudentDTO>(student));
            }
            return studentDTOList;
        }

        public async Task<StudentDTO> GetById(int id)
        {
            Student student = await _studentRepository.GetById(id);
            var studentDTO = _mapper.Map<StudentDTO>(student);

            return studentDTO;
        }

        public async Task Create(StudentDTO entity)
        {
            var student = _mapper.Map<Student>(entity);
            await _studentRepository.Create(student);

            try
            {
               this._studentRepository.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }        
        }

        public async Task Update(int id, StudentDTO entity)
        {
            Student studentById = await _studentRepository.GetById(id);
            studentById.Name = entity.Name;
            studentById.Age = entity.Age;
            studentById.Address = entity.Address;
            studentById.Program = entity.Program;
            studentById.TeacherId = entity.TeacherId;
            await _studentRepository.Update(studentById);

            try
            {
               this._studentRepository.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task Delete(int id)
        {
            await this._studentRepository.Delete(id);
            this._studentRepository.SaveChanges();
        }


        public async Task<List<StudentDTO>> Search(string searchTerm)
        {
            Expression<Func<Student, bool>> expression = u => u.Name.Contains(searchTerm);
            List<Student> studentList = await _studentRepository.Search(expression);
            List<StudentDTO> studentDTOList = new List<StudentDTO>();

            foreach (var student in studentList)
            {
                studentDTOList.Add(_mapper.Map<StudentDTO>(student));
            }
            return studentDTOList;
        }
    }
}
