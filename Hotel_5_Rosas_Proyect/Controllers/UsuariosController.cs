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

    public class UsuariosController : Controller
    {
        private readonly DA_Hotel_5_Rosas_Usuario _context;

        public UsuariosController(DA_Hotel_5_Rosas_Usuario context)
        {
            _context = context;
        }

        // GET: api/Usuarios/GetUsers
        [HttpGet]
        public async Task<IEnumerable<Entities_Hotel_5_Rosas.Entity_Usuario>> GetUsers()
        {
            return await _context.Set<Entities_Hotel_5_Rosas.Entity_Usuario>().ToListAsync();
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.PK_Usuario == id);
        }
    }
}
