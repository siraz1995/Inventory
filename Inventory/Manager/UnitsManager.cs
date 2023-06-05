using System.Collections.Generic;
using Inventory.Interface.Manager;
using Inventory.Models;
using Inventory.Interface.Manager;
using Inventory.Models;
using Inventory.Repository;
using Inventory.Areas.Identity.Data;

namespace Inventory.Manager
{
    public class UnitsManager : BaseManager<Unit>, IUnitsManager
    {
        public UnitsManager(InventoryContext db) : base(new BaseRepository<Unit>(db))
        {
        }

        public Unit GetUnitById(int id)
        {
            return GetFirstOrDefault(x => x.Id==id);
        }

        public ICollection<Unit> GetUnit()
        {
            return Get(x =>true);
        }
    }
}
