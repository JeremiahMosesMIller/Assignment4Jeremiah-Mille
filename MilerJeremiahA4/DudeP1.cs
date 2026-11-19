using MilerJeremiahA4;
using System;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;


namespace MohawkGame2D
{
    public class DudeP1
    {


     
        public Vector2 position1;

        public Vector2 point;

        public Vector2 velocity;

        public Vector2 Size;

        public float gravity;

        public float radius1 = 20f;
     

        public float mass;

        public int score;

       




       

        bool isColliding = false;

     

        public void setup()
        {
            radius1 = (20);
           
            Size = new Vector2(40, 60);
            position1 = new Vector2(500 - Size.X / 2, 600);
            gravity = 500f;
            mass = 20f;
            
       

        }

        public void update(GreenApple Apple1, Green_Bomb green_Bomb)
        {

            DrawDude();

            Rendercollision(Apple1);
            RendercollisionBombs(green_Bomb);




            processphysics();

       

        }

       

        void DrawDude()
        {


            if (Input.IsKeyboardKeyDown(KeyboardKey.A))
            {
                position1.X -= 20f;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.D))
            {
                position1.X += 20f;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.S))
            {
                position1.Y += 5f;


            }


            if (position1.Y > 535)
            {
                if (Input.IsKeyboardKeyPressed(KeyboardKey.W))
                { position1.Y -= 50f; }
                

            }

            if (position1.X < 0)
            { position1.X = 800; }

            if (position1.X > 800)
            { position1.X = 0; }

            if (position1.Y > 535)
            {
                Draw.SetLineColor(0, 0, 100);
            }
            else
            { Draw.SetLineColor(100); }

            radius1 = (20);


            Draw.SetLineSize(3);
            Draw.SetFillColor(100, 0, 0);
            Draw.Circle(position1, radius1);




            //I initially wanted to remove the ability to jump mulitple times in a row, however as I secretely gunning to make this 2 players, (A PVP) type of game I do not
            //Want to remove any skill expression.


            //I want the position to go beneath the floor, to replicate death in myh game

           

        }

      
        void processphysics()
        {


            velocity.Y += gravity * Time.DeltaTime;
            position1 += velocity * Time.DeltaTime;


            if (position1.Y + Size.Y > Window.Size.Y)
            {
                position1.Y = Window.Size.Y - Size.Y;
                velocity.Y *= -0.9f;

            }






        }

        void Rendercollision(GreenApple Apple1)
        {
            bool colliding = Vector2.Distance(Apple1.position, position1) <= radius1 + Apple1.AppleRadius;

            if (colliding == true)
            {
                score += 1;
            }
        }
             void RendercollisionBombs(Green_Bomb green_bombs)
            {
                bool colliding = Vector2.Distance(green_bombs.Hitboxpos, position1) <= radius1 + green_bombs.radius;

                if (colliding == true)

                { position1.Y = -800; }



            }


        }

     



    }
