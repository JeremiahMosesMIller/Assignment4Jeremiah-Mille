using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MilerJeremiahA4
{
    public class GreenApple
    {
        float x = 0;
        float y = 160;
        float speed = 50f;
        void RandomizeNewApple()
        {
            x = MohawkGame2D.Random.Float(20 - 800);
            speed = y + Time.DeltaTime * 50f - 1200f;
        }
        public void Setup()
        {
            //I know this contributes nothing, but I am superstitious enough to keep it incase.
            int x = MohawkGame2D.Random.Integer(0, 800);

        }



        public void Update()
        {
            DrawGreenApple();
        }


        void DrawGreenApple()
        {
            y += Time.DeltaTime * 400f;
            x += Time.DeltaTime * 0f;

            Vector2 AppleBody1 = new Vector2(x + 400f, y + 200f);
            Vector2 Stem1 = new Vector2(x + 395, y + 156);
            Vector2 StemShape1 = new Vector2(10, 20);
            Vector2 Stem2 = new Vector2(x + 395, y + 149);
            Vector2 StemShape2 = new Vector2(10, 20);
            Vector2 Stem3 = new Vector2(x + 397, y + 145);
            Vector2 StemShape3 = new Vector2(8, 10);
            Vector2 Stem4 = new Vector2(x + 399, y + 147);
            Vector2 StemShape4 = new Vector2(8, 10);
            Vector2 AppleShine1 = new Vector2(x + 390, y + 200);
            Vector2 AppleShine2 = new Vector2(x + 380, y + 190);
            Draw.SetFillColor(0, 100, 0);
            Draw.Circle(AppleBody1, 40);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(Stem1, StemShape1);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(Stem2, StemShape2);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(Stem3, StemShape3);

            Draw.SetFillColor(20, 30, 30);
            Draw.Rectangle(Stem4, StemShape4);

            Draw.SetFillColor(200);
            Draw.Capsule(AppleShine1, AppleShine2, 5);

            if (y > 620)
            {

                y = -200;
                RandomizeNewApple();

            }

        }
    }
}

