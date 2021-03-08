using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interfaces
{
    interface IWeapon
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
    }
}
