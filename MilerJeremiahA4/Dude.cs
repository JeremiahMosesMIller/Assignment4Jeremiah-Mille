using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Dude
    {
        public Vector2 position;

        public Vector2 velocity;

        public Vector2 Size;

        public float gravity;
        
    

    public void setup()
        {
            Size = new Vector2(40, 60);
         
          float gravity = Time.DeltaTime * +80f;


        }
        public void update()
        {
            DrawDude();

            processphysics(); //processInput(); render();
            
        }

        void processphysics()
        {


            velocity.Y += gravity * Time.DeltaTime;
            position += velocity * Time.DeltaTime;

            if (position.Y + Size.Y > Window.Size.Y)
            {
                position.Y = Size.Y;
                velocity.Y *= -0.9f;
            }


        }
        void DrawDude()
        {

            if (Input.IsKeyboardKeyDown(KeyboardKey.S))




            Vector2 DudeL = new Vector2(20, 50);
            Vector2 Dude = new Vector2(20, 20);
            Draw.SetFillColor(100, 0, 0);
            Draw.Rectangle(DudeLocation, Dude);
        }
    } 
}
