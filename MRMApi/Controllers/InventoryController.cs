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
    [Authorize]
    public class InventoryController : ControllerBase
    {
        [Authorize(Roles = "Manager,Admin")]
        public List<InventoryModel> Get()
        {
            InventoryData data = new InventoryData();

            return data.GetInventory();
        }

        [Authorize(Roles = "Admin")]
        public void Post(InventoryModel item)
        {
            InventoryData data = new InventoryData();

            data.SaveInventoryRecord(item);
        }
    }
}
