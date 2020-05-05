using EmployeePortal.Models.Logic;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePortal.Models.LogicImplementation
{
    public class PathProvider : IPathProvider
    {
        //private static readonly Lazy<PathProvider> pathProviderInstance = new Lazy<PathProvider>(() => new PathProvider());
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PathProvider(IWebHostEnvironment webHostEnvironment )
        {
            _webHostEnvironment = webHostEnvironment;
        }
        
        public string MapPath()
        {
            var filePath = _webHostEnvironment.WebRootPath;
            return filePath;
        }
    }
}
