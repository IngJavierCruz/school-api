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
    public class StudentsGradeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new ResponseApi()
            {
                data = StudentGradeLB.GetAll(),
                success = true,
                message = "Consulta con éxito"
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var StudentsGrade = StudentGradeLB.GetById(id);
            if (StudentsGrade != null)
            {
                return Ok(new ResponseApi()
                {
                    data = StudentGradeLB.GetById(id),
                    success = true,
                    message = "Consulta con éxito"
                });
            }
            return NotFound(new ResponseApi()
            {
                success = false,
                message = string.Format("Registro con el id = {0} no encontrado", id)
            });
        } 
        
        [HttpPost]
        public IActionResult Insert(StudentsGrade StudentsGrade)
        {
            if (ModelState.IsValid)
            {
                return Ok(new ResponseApi()
                {
                    data = StudentGradeLB.Insert(StudentsGrade),
                    success = true,
                    message = "Registro creado con éxito"
                });
            }
            return BadRequest(new ResponseApi()
            {
                success = false,
                message = "Solicitud incorrecta"
            });
        }

        [HttpPut]
        public IActionResult Update(StudentsGrade StudentsGrade)
        {
            if (ModelState.IsValid)
            {
                return Ok(new ResponseApi()
                {
                    data = StudentGradeLB.Update(StudentsGrade),
                    success = true,
                    message = "Registro actualizado con éxito"
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
            var StudentsGrade = StudentGradeLB.GetById(id);
            if (StudentsGrade != null)
            {
                StudentGradeLB.DeleteById(id);
                return Ok(new ResponseApi()
                {
                    success = true,
                    message = "Registro eliminado con éxito"
                });
            }
            return NotFound(new ResponseApi()
            {
                success = false,
                message = string.Format("Registro con el id = {0} no encontrado", id)
            });
        }
    }
}
