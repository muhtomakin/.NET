using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Entities.Concrete;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class ProductsController : ControllerBase
    {
        ICarService _carService;

        public ProductsController(ICarService carService)
        {
            _carService = carService;
        }
    }
}