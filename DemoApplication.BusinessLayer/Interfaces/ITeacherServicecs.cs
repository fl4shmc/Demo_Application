using DTO.EntityDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.BusinessLayer.Interfaces
{
    public interface ITeacherServicecs
    {
        List<TeacherDTO> GetAll();
        Task<List<TeacherDTO>> Search(string searchTerm);
        Task<TeacherDTO> GetById(int id);
        Task Create(TeacherDTO entity);
        Task Update(int id, TeacherDTO entity);
        Task Delete(int id);
    }
}
