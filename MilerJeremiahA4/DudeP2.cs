
using System.Numerics;
using System.Xml.Serialization;


namespace MohawkGame2D
{
    public class DudeP2
    {
        public Vector2 position2;

        public Vector2 velocity;

        public Vector2 Size;

        public float gravity;

        public float radius;

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
            position2 = new Vector2(400 - Size.X / 2, 600);
            radius = (20);
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
            Calcdimensions();

            

            Draw.SetLineSize(3);

            radius = (20);
            Draw.SetFillColor(0, 0, 100);
            Draw.Square(position2, radius);



            //I initially wanted to remove the ability to jump mulitple times in a row, however as I secretely gunning to make this 2 players, (A PVP) type of game I do not
            //Want to remove any skill expression.
        }
        void Calcdimensions()
        {
            leftedge = position2.X;
            rightedge = position2.X + radius;
            bottomleft = position2.Y;
            bottomright = position2.Y + radius;

            bool anyoverlap = false;

            for (int i = 0; i < DudeP1.Length; i++)
            {
                bool overlapTL = leftedge2 < rightedge;
                bool overlapTR = rightedge2 > leftedge;
                bool overlapBR = bottomright2 > bottomleft;
                bool overlapBL = bottomleft2 < bottomright;

                bool overlap = overlapBL && overlapBR && overlapTL && overlapTR;

                if (overlap) anyoverlap = true; position2.X = 200;
             
            }

        }

      
        }
        }
    


