using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Classes
{
    class Enemy : ICharacter
    {
        public string Name { get; set; }
        public int CurrentHealthPoints { get; set; }
        public int MaxHealthPoints { get; set; }
        public IWeapon EquippedWeapon { get; set; }
        public List<IArmor> EquippedArmors { get; set; }

        public Enemy()
        {
            EquippedArmors = new List<IArmor>();

            Name = "Bob";
            CurrentHealthPoints = 50;
            MaxHealthPoints = 50;

            var swordMinDamage = new Random().Next(5, 10);
            var swordMaxDamage = new Random().Next(swordMinDamage, swordMinDamage + 5);
            var shieldDefense = new Random().Next(1, 3);
            var chestplateDefense = new Random().Next(1, 4);

            Sword sword = new Sword(swordMinDamage, swordMaxDamage, 17, 25);
            Shield shield = new Shield(shieldDefense, 22, 30);
            Chestplate chestplate = new Chestplate(chestplateDefense, 15, 25);

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
