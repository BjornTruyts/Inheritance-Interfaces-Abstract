using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interfaces
{
    interface IDurability
    {
        public int CurrentDurability { get; set; }
        public int MaxDurability { get; set; }
    }
}
