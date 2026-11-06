using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class OtherDude
    {
        public Vector2 position2;

        public Vector2 velocity2;

        public Vector2 Size2;

        public float gravity2;
        
        
      

    public void setup()
        {
            Size2 = new Vector2(40, 60);
            position2 = new Vector2(400 - Size2.X / 2, 600);
         
            gravity2 = 500f;
          





        }
        public void update()
        {

            OtherDrawDude();

            processphysics(); //processInput(); render();

            
            
        }

        public void processphysics()
        {


            velocity2.Y += gravity2 * Time.DeltaTime;
            position2 += velocity2 * Time.DeltaTime;
           

            if (position2.Y + Size2.Y > Window.Size.Y)
            {
                position2.Y = Window.Size.Y - Size2.Y;
                velocity2.Y *= -0.9f;

            }

            


        }

        void OtherDrawDude()
        {

            
            if (Input.IsKeyboardKeyDown(KeyboardKey.Left))
            {
                position2.X -= 20f;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Right))
            {
                position2.X += 20f;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Down))
            {
                position2.Y += 10f;

                
            }


            if (position2.Y > 500)
            {
                if (Input.IsKeyboardKeyPressed(KeyboardKey.Up))
                { position2.Y -= 20f; }

            }

            if (position2.X < 0)
                { position2.X = 800;}

            if (position2.X > 800)
            { position2.X = 0; }

           


                Vector2 OtherDude = new Vector2(20 , 20);
            Draw.SetFillColor(0, 0, 100);
            Draw.Rectangle(position2 , OtherDude);

            //I initially wanted to remove the ability to jump mulitple times in a row, however as I secretely gunning to make this 2 players, (A PVP) type of game I do not
            //Want to remove any skill expression.
        }
    } 
}
