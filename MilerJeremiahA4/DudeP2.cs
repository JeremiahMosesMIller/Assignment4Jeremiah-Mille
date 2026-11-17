
using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Serialization;


namespace MohawkGame2D
{
    public class DudeP2
    {

        public  Vector2 point;
        public Vector2 position2;

        public Vector2 velocity;

        public Vector2 Size;

        public float gravity;

        public float radius2;

        public float radius1;

        public float mass;

        DudeP2 collidingDude = null;

        bool isColliding = false;

        public float leftedge;

        public float rightedge;

        public float bottomleft;

        public float bottomright;

        public float leftedge2;

        public float rightedge2;

        public float bottomleft2;

        public float bottomright2;



        public void setup()
        {
            mass = 20f;
            Size = new Vector2(40, 60);
            position2 = new Vector2(300 - Size.X / 2, 600);
            radius2 = (20);
            gravity = 500f;
            Calcdimensions();







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
            Calcdimensions();

            

            Draw.SetLineSize(3);

            radius2 = (20);
            Draw.SetFillColor(0, 0, 100);
            Draw.Square(position2, radius2);



            //I initially wanted to remove the ability to jump mulitple times in a row, however as I secretely gunning to make this 2 players, (A PVP) type of game I do not
            //Want to remove any skill expression.
        }
        void Calcdimensions()
        {
            bool Dude2Point = Vector2.Distance(point, position2) <= radius1;


            float squareradii = radius1 + radius2;

            bool doDudesOverlap = Vector2.Distance(position1, position2) <= squareradii;
        }


        }
        }
    


