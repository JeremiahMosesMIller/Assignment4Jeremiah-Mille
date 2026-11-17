using System;
using System.Numerics;


namespace MohawkGame2D
{
    public class DudeP1
    {


        public Vector2 point;
      
        public Vector2 position1;



        public Vector2 velocity;

        public Vector2 Size;

        public float gravity;

        public float radius1;

        public float radius2;

        public float mass;

        public float leftedge;

        public float rightedge;

        public float bottomleft;

        public float bottomright;

        public float leftedge2;

        public float rightedge2;

        public float bottomleft2;

        public float bottomright2;




        DudeP1 collidingDude = null;

        bool isColliding = false;

        public static int Length { get; private set; }

        public void setup()
        {
            radius1 = (20);
            Size = new Vector2(40, 60);
            position1 = new Vector2(400 - Size.X / 2, 600);
            gravity = 500f;
            mass = 20f;
            calcdimensions();

        }

        public void update(DudeP2 dudeP21)
        {

            DrawDude();

            processphysics(); //processInput(); render();

            calcdimensions();

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
                position1.Y += 10f;


            }


            if (position1.Y > 500)
            {
                if (Input.IsKeyboardKeyPressed(KeyboardKey.W))
                { position1.Y -= 20f; }

            }

            if (position1.X < 0)
            { position1.X = 800; }

            if (position1.X > 800)
            { position1.X = 0; }


            radius1 = (20);


            Draw.SetLineSize(3);
            Draw.SetFillColor(100, 0, 0);
            Draw.Square(position1, radius1);




            //I initially wanted to remove the ability to jump mulitple times in a row, however as I secretely gunning to make this 2 players, (A PVP) type of game I do not
            //Want to remove any skill expression.


            //I want the position to go beneath the floor, to replicate death in myh game

           

        }

        void calcdimensions()
        {
            


            bool Dude1Point = Vector2.Distance(point, position1) <= radius1;


            float squareradii = radius1 + radius2;


            //ask for help later
            //Trying to make players have collision.
            bool doDudesOverlap = Vector2.Distance(position1, position2) <= squareradii;

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



    }
}

