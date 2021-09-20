using MediaFlowServer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaFlowServer.Controllers
{
    public class MetadataController : Controller
    {
        public IActionResult Index([FromQuery] string fileName)
        {
            return View(new MetadataViewModel { FileName = fileName });
        }
    }
}
