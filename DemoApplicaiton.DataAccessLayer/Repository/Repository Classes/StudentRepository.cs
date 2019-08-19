using DemoApplicaiton.DataAccessLayer.Repository.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DemoApplicaiton.DataAccessLayer.Repository.Repository_Classes
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(DemoContext demoContext) : base(demoContext)
        {
           
        }
    }
}
