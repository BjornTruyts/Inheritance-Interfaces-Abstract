using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interfaces
{
    interface ICharacter
    {
        public string Name { get; set; }
        public int CurrentHealthPoints { get; set; }
        public int MaxHealthPoints { get; set; }
        public IWeapon EquippedWeapon { get; set; }
        public List<IArmor> EquippedArmors { get; set; }
        void TakeDamage(int amount);
        int DoDamage();
    }
}
