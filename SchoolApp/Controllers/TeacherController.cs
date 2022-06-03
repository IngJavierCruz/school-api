using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp.Data.Models;
using SchoolApp.Business;
using SchoolApp.Models;

namespace SchoolApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Teacher> GetAll()
        {
            return TeacherLB.GetAll();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var Teacher = TeacherLB.GetById(id);
            if (Teacher != null)
            {
                return Ok(new ResponseApi()
                {
                    data = TeacherLB.GetById(id),
                    success = true,
                    message = "Consulta con éxito"
                });
            }
            return NotFound(new ResponseApi()
            {
                success = false,
                message = string.Format("Maestro con el id = {0} no encontrado", id)
            });
        }

        [HttpPost]
        public IActionResult Insert(Teacher Teacher)
        {
            if (ModelState.IsValid)
            {
                return Ok(new ResponseApi()
                {
                    data = TeacherLB.Insert(Teacher),
                    success = true,
                    message = "Maestro creado con éxito"
                });
            }
            return BadRequest(new ResponseApi()
            {
                success = false,
                message = "Solicitud incorrecta"
            });
        }

        [HttpPut]
        public IActionResult Update(Teacher Teacher)
        {
            if (ModelState.IsValid)
            {
                return Ok(new ResponseApi()
                {
                    data = TeacherLB.Update(Teacher),
                    success = true,
                    message = "Maestro actualizado con éxito"
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
            var Teacher = TeacherLB.GetById(id);
            if (Teacher != null)
            {
                TeacherLB.DeleteById(id);
                return Ok(new ResponseApi()
                {
                    success = true,
                    message = "Maestro eliminado con éxito"
                });
            }
            return NotFound(new ResponseApi()
            {
                success = false,
                message = string.Format("Maestro con el id = {0} no encontrado", id)
            });
        }

    }
}
