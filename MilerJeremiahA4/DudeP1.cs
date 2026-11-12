using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MohawkGame2D
{
    public class DudeP1
    {



        public Vector2 position1;

        public Vector2 velocity;

        public Vector2 Size;

        public float gravity;

        public float radius;

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
            radius = (20);
            Size = new Vector2(40, 60);
            position1 = new Vector2(400 - Size.X / 2, 600);
            gravity = 500f;
            mass = 20f;


        }

        public void update(DudeP2 dudeP21)
        {

            DrawDude();

            processphysics(); //processInput(); render();

            calcdimensions();

        }

        void calcdimensions()
        {
            leftedge = position1.X;
            rightedge = position1.X + radius;
            bottomleft = position1.Y;
            bottomright = position1.Y + radius;

            for (int i = 0; i < DudeP1.Length; i++)
            { 
                    bool overlapTR = rightedge < leftedge2;
                bool overlapTL = leftedge > rightedge2;
                bool overlapBL = bottomleft > bottomleft2;
                bool overlapBR = bottomright < bottomleft2;

                bool overlap = overlapBL && overlapBR && overlapTL && overlapTR;
                if (overlap)
                { Draw.Rectangle(400, 400, 400, 400);
                    Draw.SetFillColor(100, 0, 0);
                }
            }

             
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


            radius = (20);

            Draw.SetLineSize(3);

            Draw.SetFillColor(100, 0, 0);
            Draw.Square(position1, radius);




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
        void collision(DudeP1[] dudes)
        {
            isColliding = false;
            collidingDude = null;
            for (int i = 0; i < dudes.Length; i++)
            {
                DudeP1 otherDude = dudes[i];

                float distance = Vector2.Distance(position1, otherDude.position1);

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
                {
                    Vector2 velocityDelta = velocity - collidingDude.velocity;
                    Vector2 positionDelta = position1 - collidingDude.position1;

                    float dotproduct = Vector2.Dot(velocityDelta, positionDelta);
                    float lengthSquared = positionDelta.LengthSquared();

                    float massFactor = -2 * mass / (collidingDude.mass + mass);

                    velocity += massFactor * dotproduct * positionDelta / lengthSquared;

                }

            }
                   

            }

        internal void update(object dudeP1)
        {
            throw new NotImplementedException();
        }
    }
    }

