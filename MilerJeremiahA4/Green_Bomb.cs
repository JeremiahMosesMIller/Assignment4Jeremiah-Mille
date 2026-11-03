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

            float y = 20;
           y += Time.DeltaTime *  160f;
            Vector2 BombLocation1 = new Vector2(360, y + Time.DeltaTime * 100f);
            Vector2 BombBody1 = new Vector2(80, 80);
            Vector2 BombLocation2 = new Vector2(385, 155);
            Vector2 BombBody2 = new Vector2(30, 10);
            Vector2 BombBody3 = new Vector2(10, 20);
            Vector2 BombLocation3 = new Vector2(395, 140);
            Vector2 BombLocation4 = new Vector2(390, 120);






            Draw.SetFillColor(0, 100, 0);
            Draw.Rectangle(BombLocation1,BombBody1);

            Draw.SetFillColor(0, 100, 0);
            Draw.Rectangle(BombLocation2,BombBody2);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(BombLocation3, BombBody3);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(BombLocation4, BombBody3);
        }
    }
}
