
using System.Drawing;
using System.Numerics;
using System.Xml.Serialization;


namespace MohawkGame2D
{
    public class DudeP2
    {
        public Vector2 Point;
        public Vector2 position2;

        public Vector2 velocity;

        public Vector2 Size;

        public float gravity;

        public float radius2;

        public float mass;

        DudeP2 collidingDude = null;

        bool isColliding = false;

       


        public void setup()
        {
            mass = 20f;
            Size = new Vector2(40, 60);
            position2 = new Vector2(300 - Size.X / 2, 600);
            radius2 = (20);
            gravity = 500f;
         







        }
        public void update(DudeP1 dudeP11)
        {

            DrawDude2();

            processphysics(); //processInput(); render();

            Calcdimensions();

        }


        public void processphysics()
        {


            velocity.Y += gravity * Time.DeltaTime;
            position2 += velocity * Time.DeltaTime;


            if (position2.Y + Size.Y > Window.Size.Y)
            {
                position2.Y = Window.Size.Y - Size.Y;
                velocity.Y *= -0.9f;

            }




        }

        void DrawDude2()
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
            { position2.X = 800; }

            if (position2.X > 800)
            { position2.X = 0; }
           



            Draw.SetLineSize(3);

            radius2 = (20);
            Draw.SetFillColor(0, 0, 100);
            Draw.Circle(position2, radius2);



            //I initially wanted to remove the ability to jump mulitple times in a row, however as I secretely gunning to make this 2 players, (A PVP) type of game I do not
            //Want to remove any skill expression.
        }
        void Calcdimensions()
        {



            bool Dude1Point = Vector2.Distance(Point, position2) <= radius2;


            float duderadii = radius1 + radius2;


            //ask for help later
            //Trying to make players have collision.
            bool doDudesOverlap = Vector2.Distance(position2, position2) <= duderadii;

        }


    }
}
