using System.Collections.Generic;
using Inventory.Models;
using Inventory.Models;

namespace Inventory.Interface.Manager
{
   interface IUnitsManager : IBaseManager<Unit>
    {
        ICollection<Unit> GetUnit();
        Unit GetUnitById(int id);
    }
}
