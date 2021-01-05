using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    public class ErrorController : Controller
    {
        [Route("{statusCode?}")]
        public IActionResult Error(int? statuscode)
        {
            //MoSo: we use the below line for extracting the Original Path
            var statusCodeResult = HttpContext.Features.Get <IStatusCodeReExecuteFeature>() ;
            ViewBag.OriginalPath = statusCodeResult.OriginalPath;
            switch(statuscode)
            {
                case 404:
                    ViewBag.ErrorCode = statuscode;
                    break;
           
                      
            }
            return View("NotFound");
        }
    }
}
