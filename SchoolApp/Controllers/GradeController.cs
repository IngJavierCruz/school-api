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
    public class GradeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new ResponseApi()
            {
                data = GradeLB.GetAll(),
                success = true,
                message = "Consulta con éxito"
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var Grade = GradeLB.GetById(id);
            if (Grade != null)
            {
                return Ok(new ResponseApi()
                {
                    data = GradeLB.GetById(id),
                    success = true,
                    message = "Consulta con éxito"
                });
            }
            return NotFound(new ResponseApi()
            {
                success = false,
                message = string.Format("Grado con el id = {0} no encontrado", id)
            });
        } 
        
        [HttpPost]
        public IActionResult Insert(Grade Grade)
        {
            if (ModelState.IsValid)
            {
                return Ok(new ResponseApi()
                {
                    data = GradeLB.Insert(Grade),
                    success = true,
                    message = "Grado creado con éxito"
                });
            }
            return BadRequest(new ResponseApi()
            {
                success = false,
                message = "Solicitud incorrecta"
            });
        }

        [HttpPut]
        public IActionResult Update(Grade Grade)
        {
            if (ModelState.IsValid)
            {
                return Ok(new ResponseApi()
                {
                    data = GradeLB.Update(Grade),
                    success = true,
                    message = "Grado actualizado con éxito"
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
            var Grade = GradeLB.GetById(id);
            if (Grade != null)
            {
                GradeLB.DeleteById(id);
                return Ok(new ResponseApi()
                {
                    success = true,
                    message = "Grado eliminado con éxito"
                });
            }
            return NotFound(new ResponseApi()
            {
                success = false,
                message = string.Format("Grado con el id = {0} no encontrado", id)
            });
        }
    }
}
