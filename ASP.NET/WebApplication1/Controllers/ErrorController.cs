using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode?}")]
        public IActionResult HttpStatusCodeHandeler(int? statuscode)
        {
            //MoSo: we use the below line for extracting the Original Path
            var statusCodeResult = HttpContext.Features.Get <IStatusCodeReExecuteFeature>() ;
            if (statusCodeResult != null)
                ViewBag.OriginalPath = statusCodeResult.OriginalPath;
            else
                ViewBag.OriginalPath = "Error" + statuscode;

            switch(statuscode)
            {
                case 404:
                    if (statuscode.HasValue)
                    ViewBag.ErrorCode = statuscode;
                    break;
            }
            return View("NotFound");
        }


        [Route("InternalError")]
        [AllowAnonymous]
        public IActionResult Error()
        {
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ExceptionPath = exceptionDetails.Path;
            ViewBag.ExceptionMessage = exceptionDetails.Error.Message;
            ViewBag.stackTrace = exceptionDetails.Error.StackTrace;
            return View();
        }
    }
}
