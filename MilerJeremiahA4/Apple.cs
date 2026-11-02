using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MilerJeremiahA4
{
    public  class Apple
    {
        float y = 20f;
        public void Setup()
        {
           int x = MohawkGame2D.Random.Integer(0, 800);
            
        }

        public void Speed()
        {
            MohawkGame2D.Random.Float(y -= Time.DeltaTime * 100f, y -= Time.DeltaTime * 200f);
        }

        public void Update()
        {
            
        }
    

            void DrawApple()
        {
            
        
            Draw.SetFillColor(Color.Red);
            Draw.Circle(400, 200f, 40);

            Draw.SetFillColor(165, 42, 42);
            Draw.Rectangle(395, 156, 10, 20);

            Draw.SetFillColor(165, 42, 42);
            Draw.Rectangle(395, 149, 10, 20);

            Draw.SetFillColor(165, 42, 42);
            Draw.Rectangle(397, 145, 8, 10);

            Draw.SetFillColor(165, 42, 42);
            Draw.Rectangle(399, 147, 8, 10);

            Draw.SetFillColor(200);
            Draw.Capsule(390, 200, 380, 190, 5);

            
          
        }
    }
}


