using EmployeePortal.Models.Logic;
using EmployeePortal.Models.LogicImplementation;
using Logger;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePortal.Models
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILog _ILog;
        //private readonly IPathProvider _pathProvider;

        public CustomExceptionFilter()
        {
            _ILog = Log.GetIntance;
            //_pathProvider = pathProvider;

        }
        public override void OnException(ExceptionContext context)
        {

            var path = Directory.GetCurrentDirectory();
            _ILog.Exception(context.Exception.ToString(), path);
            context.ExceptionHandled = true;
            base.OnException(context);
        }
    }
}
