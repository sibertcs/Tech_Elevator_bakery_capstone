﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApi.DAL;
using SampleApi.Models;
using SampleApi.Models.Account;
using SampleApi.Providers.Security;

namespace SampleApi.Controllers
{
    /// <summary>
    /// Creates a new cake controller used to get a list of cakes/create new cake
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CakeController : ControllerBase
    {
        private ICakeInfoDAO cakeDao;

        
        public CakeController(ICakeInfoDAO cakeDao)
        {
            this.cakeDao = cakeDao;
        }

        [HttpGet]
        public List<Cake> GetAllCakes()
        {
            return cakeDao.GetAllCakes();
        }

        /// <summary>
        /// Creates a new standard cake in the database
        /// </summary>
        /// <param name="cake"></param>
        /// <returns></returns>
        [HttpPost]
        public void Create([FromBody] Cake cake)
        {
            cakeDao.AddCake(cake);
            
        }
    }
}