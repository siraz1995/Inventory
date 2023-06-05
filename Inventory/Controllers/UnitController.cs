using Inventory.Areas.Identity.Data;

using Inventory.Interface.Manager;
using Inventory.Manager;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class UnitController : Controller
    {
        private readonly UnitsManager _unitsManager;
        private InventoryContext _inventoryContext;
        public UnitController(InventoryContext context,UnitsManager unitsManager)
        {
            _inventoryContext = context;
            _unitsManager = unitsManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet] 
        public IActionResult Create() 
        { 
            return View();
        }
    }
}
