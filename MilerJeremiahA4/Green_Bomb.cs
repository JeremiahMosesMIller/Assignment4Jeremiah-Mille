using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Numerics;
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
            DrawGreen_Bomb();
        }

        void DrawGreen_Bomb()
        {


            float y = 160; 
            Draw.SetFillColor(0, 100, 0);
            Draw.Rectangle(360f, y + Time.DeltaTime * 100f, 80, 80);

            Vector2 BombBody2 = new Vector2(385, 155);
            Draw.SetFillColor(0, 100, 0);
            Draw.Rectangle(385, 155, 30, 10);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(395, 140, 10, 20);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(390, 120, 10, 20);
        }
    }
}
