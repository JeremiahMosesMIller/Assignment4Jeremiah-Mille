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
         

            

        }
        public void update()
        {
            DrawDude();

            processphysics(); //processInput(); render();
            
        }

        void processphysics()
        {

            void DrawDude()
            {
                Draw.SetFillColor(100, 0, 0);
                Draw.Rectangle(20, 20, 20, 20);
            }
            velocity.Y += gravity * Time.DeltaTime;
                position += velocity * Time.DeltaTime;

            if (position.Y + Size.Y > Window.Size.Y)
            { position.Y = Size.Y;
                velocity.Y *= -0.9f;
            }

         
        }
    } 
}
