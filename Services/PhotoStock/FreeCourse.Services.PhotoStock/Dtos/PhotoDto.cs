using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.PhotoStock.Dtos
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoDto : ControllerBase
    {
        public string Url { get; set; }
    }
}
