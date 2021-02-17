using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadApi.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public IFormFile Logo { get; set; }
    }
}
