using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Classes
{
    class Sword : InventoryItem, IWeapon, IDurability
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int CurrentDurability { get; set; }
        public int MaxDurability { get; set; }

        public Sword(int minDamage, int maxDamage, int currentDurability, int totalDurability)
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
            CurrentDurability = currentDurability;
            MaxDurability = totalDurability;
        }

        public override string GetDetails()
        {
            return $"Sword      | {MinimumDamage} damage  | {CurrentDurability}/{MaxDurability} durability";
        }
    }
}
