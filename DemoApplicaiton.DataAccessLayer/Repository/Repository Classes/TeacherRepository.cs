using DemoApplicaiton.DataAccessLayer.Repository.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplicaiton.DataAccessLayer.Repository.Repository_Classes
{
    public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(DemoContext demoContext) : base(demoContext)
        {

        }
    }
}
