using DemoApplicaiton.DataAccessLayer;
using DTO.EntityDTO;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.BusinessLayer.Interfaces
{
    public interface IStudentService
    {
        List<StudentDTO> GetAll();
        Task<List<StudentDTO>> Search(string searchTerm);
        Task<StudentDTO> GetById(int id);
        Task Create(StudentDTO entity);
        Task Update(int id, StudentDTO entity);
        Task Delete(int id);
    }
}
