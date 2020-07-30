using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using MinhaAplicacao.Data;
using MinhaAplicacao.Models;
using MinhaAplicacao.Services;
using Swashbuckle.Swagger.Annotations;

namespace MinhaAplicacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorasController : ControllerBase
    {
        private readonly IEditoraService _service;

        public EditorasController(IEditoraService service)
        {          
            _service = service;
        }

        [HttpGet]
        [SwaggerResponse(200, "Sucesso", typeof(IEnumerable<Editora>))]
        public async Task<IEnumerable<Editora>> Get() => await _service.ListAsync();

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Sucesso", typeof(Editora))]
        public async Task<ActionResult<Editora>> GetById(int id) => await _service.EditoraById(id);

        [HttpPost]
        [SwaggerResponse(201, "Sucesso", typeof(IActionResult))]
        public async Task<ActionResult<Editora>> CreateEditora(Editora editora) => await _service.CreateEditora(editora);
           
    }
}
