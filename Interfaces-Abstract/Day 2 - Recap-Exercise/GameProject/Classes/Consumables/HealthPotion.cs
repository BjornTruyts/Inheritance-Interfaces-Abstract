using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Classes
{
    class HealthPotion : InventoryItem, IConsumable
    {
        public int Quantity { get; set; }

        public HealthPotion(int quantity)
        {
            Quantity = quantity;
        }

        public override string GetDetails()
        {
            return $"Health Potion ({Quantity})";
        }
    }
}
