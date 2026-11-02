using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilerJeremiahA4
{
    public class Green_Bomb
    {
        public void Setup()
        {

        }

        public void Update()
        {

        }

        void DrawGreen_Bomb()
        {
            

            Draw.SetFillColor(0, 100, 0);
            Draw.Circle(400, 200f, 40);

            Draw.SetFillColor(0, 100, 0);
            Draw.Rectangle(385, 155, 30, 10);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(395, 140, 10, 20);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(390, 120, 10, 20);
        }
    }
}
