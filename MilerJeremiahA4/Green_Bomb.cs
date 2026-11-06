using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{

    
    public class Green_Bomb
    {
        float x = 0;
        float y = 160;
        float speed = 50f;
        void RandomizeNewBomb()
        {
            x = MohawkGame2D.Random.Float(20, 800);
            speed = y += Time.DeltaTime * 100-300f;
        }
       

       
        //so I'm not sure what it's called exactly, but keeping a float or int up here seems to make things move, granted I do the time deltatime thing.
        public void Setup()
        {
             
        }

       
        public void Update()
        {   
            DrawGreen_Bomb();
        }

        void DrawGreen_Bomb()
        {

           

            y += Time.DeltaTime * 400f;
            x += Time.DeltaTime * 0f;


            Vector2 BombLocation1 = new Vector2(x + 360, 165f + y);
            Vector2 BombBody1 = new Vector2(80, 80);
            Vector2 BombLocation2 = new Vector2(x + 385, 160f + y);
            Vector2 BombBody2 = new Vector2(30, 10);
            Vector2 BombBody3 = new Vector2(10, 20);
            Vector2 BombLocation3 = new Vector2(x + 395, 140f + y);
            Vector2 BombLocation4 = new Vector2(x + 390, 120f + y);
           



            Draw.SetFillColor(0, 100, 0);
            Draw.Rectangle(BombLocation1,BombBody1);

            Draw.SetFillColor(0, 100, 0);
            Draw.Rectangle(BombLocation2,BombBody2);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(BombLocation3, BombBody3);

            Draw.SetFillColor(100, 30, 30);
            Draw.Rectangle(BombLocation4, BombBody3);

            if ( y > 620)
            {
                
                y = -200;
                RandomizeNewBomb();

            }
        }
    }
}
