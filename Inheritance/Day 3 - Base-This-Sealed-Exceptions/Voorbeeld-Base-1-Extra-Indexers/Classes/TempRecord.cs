using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Base_1_Extra_Indexers.Classes
{
    public class TempRecord
    {
        public float[] temps = new float[10]
        {
            56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
            61.3F, 65.9F, 62.1F, 59.2F, 57.5F
        };

        public float this[int index]
        {
            get { return temps[index]; }
            set { temps[index] = value; }
        }
    }
}
