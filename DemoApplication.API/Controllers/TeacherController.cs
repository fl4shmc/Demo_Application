using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DemoApplicaiton.DataAccessLayer.Repository.Interfaces;
using DemoApplication.BusinessLayer.Interfaces;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class TeacherController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITeacherServicecs _teacherServices;

        public TeacherController(IMapper mapper, ITeacherServicecs teacherServicecs)
        {
            this._mapper = mapper;
            this._teacherServices = teacherServicecs;
        }


        [HttpGet("getall")]
        public ActionResult<List<TeacherDTO>> GetAll()
        {
            var result = _teacherServices.GetAll().ToList();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await this._teacherServices.GetById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            await _teacherServices.Delete(id);
            return Ok();
        }


        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] TeacherDTO teacherDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else if (teacherDTO == null)
            {
                return BadRequest();
            }
            await _teacherServices.Create(teacherDTO);
            return Ok();
        }


        [HttpPut("update")]
        public async Task<IActionResult> Update(int Id, [FromBody] TeacherDTO teacherDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else if (teacherDTO == null)
            {
                return BadRequest();
            }
            await _teacherServices.Update(Id, teacherDTO);
            return Ok();
        }


        [HttpGet("search")]
        public async Task<IActionResult> Search(string searchTerm)
        {
            var result = await _teacherServices.Search(searchTerm);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


    }
}