using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Classes
{
    class Chestplate : InventoryItem, IArmor, IDurability
    {
        public int CurrentDurability { get; set; }
        public int MaxDurability { get; set; }
        public int Defense { get; set; }

        public Chestplate(int defense, int currentDurability, int totalDurability)
        {
            Defense = defense;
            CurrentDurability = currentDurability;
            MaxDurability = totalDurability;
        }

        public override string GetDetails()
        {
            return $"Chestplate | {Defense} defense  | {CurrentDurability}/{MaxDurability} durability";
        }
    }
}
