using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp.Data.Models;
using SchoolApp.Business;
using System.Net;
using SchoolApp.Models;

namespace SchoolApp.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new ResponseApi()
            {
                data = StudentLB.GetAll(),
                success = true,
                message = "Consulta con éxito"
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var student = StudentLB.GetById(id);
            if (student != null)
            {
                return Ok(new ResponseApi()
                {
                    data = StudentLB.GetById(id),
                    success = true,
                    message = "Consulta con éxito"
                });
            }
            return NotFound(new ResponseApi()
            {
                success = false,
                message = string.Format("Estudiante con el id = {0} no encontrado", id)
            });
        } 
        
        [HttpPost]
        public IActionResult Insert(Student student)
        {
            if (ModelState.IsValid)
            {
                return Ok(new ResponseApi()
                {
                    data = StudentLB.Insert(student),
                    success = true,
                    message = "Estudiante creado con éxito"
                });
            }
            return BadRequest(new ResponseApi()
            {
                success = false,
                message = "Solicitud incorrecta"
            });
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                return Ok(new ResponseApi()
                {
                    data = StudentLB.Update(student),
                    success = true,
                    message = "Estudiante actualizado con éxito"
                });
            }
            return BadRequest(new ResponseApi()
            {
                success = false,
                message = "Solicitud incorrecta"
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(Guid id)
        {
            var student = StudentLB.GetById(id);
            if (student != null)
            {
                StudentLB.DeleteById(id);
                return Ok(new ResponseApi()
                {
                    success = true,
                    message = "Estudiante eliminado con éxito"
                });
            }
            return NotFound(new ResponseApi()
            {
                success = false,
                message = string.Format("Estudiante con el id = {0} no encontrado", id)
            });
        }
    }
}
