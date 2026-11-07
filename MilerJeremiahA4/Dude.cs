using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
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

        public float radius;

        public float mass;

        Dude collidingDude = null;

        bool isColliding = false;

        

        

        public void setup()
        {
            radius = (20);
            Size = new Vector2(40, 60);
            position = new Vector2(400 - Size.X / 2, 600);
            gravity = 500f;
            mass = 20f;

        }
        void DrawDude()
        {


            if (Input.IsKeyboardKeyDown(KeyboardKey.A))
            {
                position.X -= 20f;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.D))
            {
                position.X += 20f;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.S))
            {
                position.Y += 10f;


            }


            if (position.Y > 500)
            {
                if (Input.IsKeyboardKeyPressed(KeyboardKey.W))
                { position.Y -= 20f; }

            }

            if (position.X < 0)
            { position.X = 800; }

            if (position.X > 800)
            { position.X = 0; }


            radius = (20);

           
          
            Draw.SetFillColor(100, 0, 0);
            Draw.Square(position, radius);

            //I initially wanted to remove the ability to jump mulitple times in a row, however as I secretely gunning to make this 2 players, (A PVP) type of game I do not
            //Want to remove any skill expression.
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
                position.Y = Window.Size.Y - Size.Y;
                velocity.Y *= -0.9f;

            }



          


            }
        void collision(Dude[] dudes)
        {
            isColliding = false;
            collidingDude = null;
            for (int i = 0; i < dudes.Length; i++)
            {
                Dude otherDude = dudes[i];

                float distance = Vector2.Distance(position, otherDude.position);

                float sumOfRadii = radius + otherDude.radius;
                if (distance < sumOfRadii)
                {
                    isColliding = true;
                    collidingDude = otherDude;
                }
            }

            void resolveCollision()
            {
                if (isColliding)
                { Vector2 velocityDelta = velocity - collidingDude.velocity;
                  Vector2 positionDelta = position - collidingDude.position;

                    float dotproduct = Vector2.Dot(velocityDelta, positionDelta);
                    float lengthSquared = positionDelta.LengthSquared();

                    float massFactor = -2 * mass / (collidingDude.mass + mass);

                    velocity += massFactor * dotproduct * positionDelta/lengthSquared;
                    
                }

            }

        }

    }
}
