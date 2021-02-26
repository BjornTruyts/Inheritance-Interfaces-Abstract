using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Oefening_Inheritance.Classes
{
    public class Triangle : Figure
    {
        public Triangle()
        {

        }

        public Triangle(Point centerpoint)
        {
            Centerpoint = centerpoint;
        }
    }
}
