using AutoMapper;
using DemoApplicaiton.DataAccessLayer.Repository.Interfaces;
using DemoApplication.BusinessLayer.Interfaces;
using DTO.EntityDTO;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.BusinessLayer.Services
{
    public class TeacherService : ITeacherServicecs
    {
        private readonly IMapper _mapper;
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this._teacherRepository = teacherRepository;
        }

        public async Task Create(TeacherDTO entity)
        {
            var teacher = _mapper.Map<Teacher>(entity);
            await _teacherRepository.Create(teacher);

            try
            {
                this._teacherRepository.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task Delete(int id)
        {
            await this._teacherRepository.Delete(id);
            this._teacherRepository.SaveChanges();
        }


        public List<TeacherDTO> GetAll()
        {
            List<Teacher> teacherList = this._teacherRepository.GetAll();
            List<TeacherDTO> teacherDTOList = new List<TeacherDTO>();

            foreach (var teacher in teacherList)
            {
                teacherDTOList.Add(_mapper.Map<TeacherDTO>(teacher));
            }
            return teacherDTOList;
        }


        public async Task<TeacherDTO> GetById(int id)
        {
            Teacher teacher = await _teacherRepository.GetById(id);
            var teacherDTO = _mapper.Map<TeacherDTO>(teacher);

            return teacherDTO;
        }


        public async Task Update(int id, TeacherDTO entity)
        {
            Teacher teacherById = await _teacherRepository.GetById(id);
            teacherById.Name = entity.Name;
            teacherById.PhoneNumber = entity.PhoneNumber;
            teacherById.Email = entity.Email;
            await _teacherRepository.Update(teacherById);

            try
            {
                this._teacherRepository.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public async Task<List<TeacherDTO>> Search(string searchTerm)
        {
            Expression<Func<Teacher, bool>> expression = t => t.Name.Contains(searchTerm);
            List<Teacher> teacherList = await _teacherRepository.Search(expression);
            List<TeacherDTO> teacherDTOList = new List<TeacherDTO>();

            foreach (var teacher in teacherList)
            {
                teacherDTOList.Add(_mapper.Map<TeacherDTO>(teacher));
            }
            return teacherDTOList;
        }
    }
}
