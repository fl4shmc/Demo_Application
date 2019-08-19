using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DemoApplication.BusinessLayer.Interfaces;
using DTO.EntityDTO;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStudentService _studentService;

        public StudentController(IMapper mapper, IStudentService studentService)
        {
            this._mapper = mapper;
            this._studentService = studentService;         
        }


        [HttpGet("getall")]
        public ActionResult<List<StudentDTO>> GetAll()
        {
            var result = _studentService.GetAll().ToList();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await this._studentService.GetById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] StudentDTO studentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else if(studentDTO == null)
            {
                return BadRequest();
            }
            await _studentService.Create(studentDTO);
            return Ok();
        }


        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            await _studentService.Delete(id);
            return Ok();
        }


        [HttpPut("update")]
        public async Task<IActionResult> Update(int Id, [FromBody] StudentDTO studentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else if(studentDTO == null)
            {
                return BadRequest();
            }
            await _studentService.Update(Id, studentDTO);
            return Ok();
        }


        [HttpGet("search")]
        public async Task<IActionResult> Search(string searchTerm)
        {
            var result = await _studentService.Search(searchTerm);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}