using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Classes
{
    class Player : ICharacter
    {
        public string Name { get; set; }
        public int CurrentHealthPoints { get; set; }
        public int MaxHealthPoints { get; set; }
        public IWeapon EquippedWeapon { get; set; }
        public List<IArmor> EquippedArmors { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }

        public Player()
        {
            InventoryItems = new List<InventoryItem>();
            EquippedArmors = new List<IArmor>();

            CurrentHealthPoints = 50;
            MaxHealthPoints = 50;

            Sword sword = new Sword(5, 7, 17, 25);
            Shield shield = new Shield(2, 22, 30);
            Chestplate chestplate = new Chestplate(3, 15, 25);

            InventoryItems.Add(sword);
            InventoryItems.Add(new Dagger(2, 4, 12, 15));

            InventoryItems.Add(shield);
            InventoryItems.Add(chestplate);

            InventoryItems.Add(new HealthPotion(4));

            EquippedWeapon = sword;
            EquippedArmors.Add(shield);
            EquippedArmors.Add(chestplate);
        }

        public int DoDamage()
        {
            var damage = new Random().Next(EquippedWeapon.MinimumDamage, EquippedWeapon.MaximumDamage);

            Console.WriteLine($"* {Name} swung his weapon and hits for {damage} damage *");

            return damage;
        }

        public void TakeDamage(int amount)
        {
            int damage = amount;
            int negatedDamage = 0;

            foreach (var armor in EquippedArmors)
            {
                damage -= armor.Defense;
            }

            negatedDamage = amount - damage;

            if (damage < 0) damage = 0;

            CurrentHealthPoints -= damage;

            Console.WriteLine($"{Name} took {damage} damage ({negatedDamage} negated by armor).    | {CurrentHealthPoints}/{MaxHealthPoints} HP left.");
        }
    }
}
