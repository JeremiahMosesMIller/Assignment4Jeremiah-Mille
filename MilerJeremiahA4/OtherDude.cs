using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class OtherDude
    {
        public Vector2 position;

        public Vector2 velocity;

        public Vector2 Size;

        public float gravity;
        
        
      

    public void setup()
        {
            Size = new Vector2(40, 60);
            position = new Vector2(400 - Size.X / 2, 600);
         
            gravity = 500f;
          





        }
        public void update()
        {

            OtherDrawDude();

            processphysics(); //processInput(); render();

            
            
        }

        public void processphysics()
        {


            velocity.Y += gravity * Time.DeltaTime;
            position += velocity * Time.DeltaTime;
           

            if (position.Y + Size.Y > Window.Size.Y)
            {
                position.Y = Window.Size.Y - Size.Y;
                velocity.Y *= -0.9f;

            }

            


        }

        void OtherDrawDude()
        {

            
            if (Input.IsKeyboardKeyDown(KeyboardKey.Left))
            {
                position.X -= 20f;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Right))
            {
                position.X += 20f;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Down))
            {
                position.Y += 10f;

                
            }


            if (position.Y > 500)
            {
                if (Input.IsKeyboardKeyPressed(KeyboardKey.Up))
                { position.Y -= 20f; }

            }

            if (position.X < 0)
                { position.X = 800;}

            if (position.X > 800)
            { position.X = 0; }

           


                Vector2 OtherDude = new Vector2(20 , 20);
            Draw.SetFillColor(0, 0, 100);
            Draw.Rectangle(position , OtherDude);

            //I initially wanted to remove the ability to jump mulitple times in a row, however as I secretely gunning to make this 2 players, (A PVP) type of game I do not
            //Want to remove any skill expression.
        }
    } 
}
