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
    public class Entity_OfertaTemporadaController : Controller
    {
        private readonly DA_Hotel_5_Rosas_OfertaTemporada _context;

        public Entity_OfertaTemporadaController(DA_Hotel_5_Rosas_OfertaTemporada context)
        {
            _context = context;
        }

        // GET: api/Entity_OfertaTemporada/GetSeasonalsOffers
        [HttpGet]
        public async Task<IEnumerable<Entities_Hotel_5_Rosas.Entity_OfertaTemporada>> GetSeasonalsOffers()
        {
            return await _context.Set<Entities_Hotel_5_Rosas.Entity_OfertaTemporada>().ToListAsync();
        }

        private bool Entity_OfertaTemporadaExists(int id)
        {
            return _context.Entity_OfertaTemporada.Any(e => e.PK_Oferta_Temporada == id);
        }
    }
}
