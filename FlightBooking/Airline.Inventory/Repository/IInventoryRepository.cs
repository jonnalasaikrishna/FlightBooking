﻿using Airline.Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airline.Inventory.Repository
{
    public interface IInventoryRepository
    {
        void PlanInventory(Inventorys inventory);
        List<Inventorys> ShowInventories();
        void CancelInventory(int id);
    }
}
