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

    public class Entity_AdministradorController : Controller
    {
        private readonly DA_Hotel_5_Rosas_Administrador _context;

        public Entity_AdministradorController(DA_Hotel_5_Rosas_Administrador context)
        {
            _context = context;
        }

        // GET: Entity_Administrador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entity_Administrador.ToListAsync());
        }

        // GET: api/Entity_Administrador/GetTipo
        [HttpGet]
        public async Task<IEnumerable<Entities_Hotel_5_Rosas.Entity_Administrador>> GetTipo()
        {
            return await _context.Set<Entities_Hotel_5_Rosas.Entity_Administrador>().ToListAsync();
        }

        private bool Entity_AdministradorExists(int id)
        {
            return _context.Entity_Administrador.Any(e => e.PK_Administrador == id);
        }
    }
}