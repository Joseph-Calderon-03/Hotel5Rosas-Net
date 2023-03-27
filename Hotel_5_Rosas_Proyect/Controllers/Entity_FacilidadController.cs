﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entities_Hotel_5_Rosas;
using Hotel_5_Rosas_Proyect.Data;
using System.Web.Http.Cors;

namespace Hotel_5_Rosas_Proyect.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET, POST, PUT, DELETE, OPTIONS")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Entity_FacilidadController : Controller
    {
        private readonly DA_Hotel_5_Rosas_Facilidad _context;

        public Entity_FacilidadController(DA_Hotel_5_Rosas_Facilidad context)
        {
            _context = context;
        }

        // GET: Entity_Facilidad
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entity_Facilidad.ToListAsync());
        }

        // GET: api/Entity_Facilidad/GetTipo
        [HttpGet]
        public async Task<IEnumerable<Entities_Hotel_5_Rosas.Entity_Facilidad>> GetTipo()
        {
            return await _context.Set<Entities_Hotel_5_Rosas.Entity_Facilidad>().ToListAsync();
        }

        private bool Entity_FacilidadExists(int id)
        {
            return _context.Entity_Facilidad.Any(e => e.PK_Facilidad == id);
        }
    }
}