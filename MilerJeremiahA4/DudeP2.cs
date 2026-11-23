
using MilerJeremiahA4;
using System.Drawing;
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

        public float radius2;
      
        public float mass;
       
        public int score2;


        public void setup()
        {
            mass = 20f;
            Size = new Vector2(40, 60);
            position2 = new Vector2(300 - Size.X / 2, 600);
            radius2 = (20);       
            gravity = 500f;
        }
        public void update(GreenApple Apple1, Green_Bomb green_Bomb, RedApple redApple)
        {
            DrawDude2();
            death();
            processphysics();
            Rendercollision(Apple1);
            Rendercollision(redApple);
            RendercollisionBombs(green_Bomb);
        }

        void death()
        {
            if (position2.Y < 10)
                DrawDefeat2();
            else if (position2.Y > 10 == false) ;
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
                position2.Y += 5f;
            }


            if (position2.Y > 535)
            {
                if (Input.IsKeyboardKeyPressed(KeyboardKey.Up))
                { position2.Y -= 50f; }
            }

            if (position2.X < 0)
            { position2.X = 800; }

            if (position2.X > 800)
            { position2.X = 0; }


            if (position2.Y > 535)
            {
                Draw.SetLineColor(100, 0, 0);
            }
            else
            { Draw.SetLineColor(100); }
            Draw.SetLineSize(3);
            radius2 = (20);
            Draw.SetFillColor(0, 0, 100);
            Draw.Circle(position2, radius2);



            //I initially wanted to remove the ability to jump mulitple times in a row, however as I secretely gunning to make this 2 players, (A PVP) type of game I do not
            //Want to remove any skill expression.
        }
        void Rendercollision(RedApple redApple)
        {
            bool colliding = Vector2.Distance(redApple.position, position2) <= radius2 + redApple.AppleRadius;

            if (colliding == true)
            {
                score2 += 25;
            }
        }




    

void Rendercollision(GreenApple Apple1)
        {
            bool colliding = Vector2.Distance(Apple1.position, position2) <= radius2 + Apple1.AppleRadius;

            if (colliding == true)
            {
                score2 += 1;
            }
        }
        void RendercollisionBombs(Green_Bomb green_bombs)
        {
            bool colliding = Vector2.Distance(green_bombs.Hitboxpos, position2) <= radius2 + green_bombs.radius;

            if (colliding == true)

            { position2.Y = -8000000000000000; }
        }
        void DrawDefeat2()
        {
            Draw.SetFillColor(20);
            Draw.Rectangle(1, 1, 800, 600);

            Text.Color = MohawkGame2D.Color.White;
            Text.Draw("Game over", new Vector2(320, 300));

            Text.Color = MohawkGame2D.Color.Blue;
            Text.Draw("Red Wins", new Vector2(320, 400));
        }


    }

}

