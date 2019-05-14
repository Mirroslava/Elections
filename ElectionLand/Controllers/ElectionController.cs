using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElectionLand.Models;

namespace ElectionLand.Controllers
{


    public class ElectionController : Controller
    {
        AplicationContext db;
        public ElectionController(AplicationContext context)
        {
            db = context;
        }
      

    }

}

