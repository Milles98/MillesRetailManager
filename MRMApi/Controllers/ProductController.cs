using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MRMDataManager.Library.DataAccess;
using MRMDataManager.Library.Models;
using System.Collections.Generic;

namespace MRMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Cashier")]
    public class ProductController : ControllerBase
    {
        public List<ProductModel> Get()
        {
            ProductData data = new ProductData();

            return data.GetProducts();
        }
    }
}
