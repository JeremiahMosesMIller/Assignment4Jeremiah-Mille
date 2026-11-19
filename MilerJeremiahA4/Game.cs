// Include the namespaces (code libraries) you need below.
using MilerJeremiahA4;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {


        public float radius1;
        public float radius2;
        Leaves leaves = new Leaves();
        Background background = new Background();
        DudeP2 dudeP21 = new DudeP2();
        Apple apple1 = new Apple();
       Green_Bomb green_bomb1 = new Green_Bomb();

        GreenApple greenapple1 = new GreenApple();

        DudeP1 dudeP11 = new DudeP1();
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        /// 

        Apple[] Apples;
        Green_Bomb[] green_bombs;
        GreenApple[] greenapples;
        public Vector2 position1;
        public Vector2 Point;
        public Vector2 position2;
        public void Setup()
        {
            Window.SetSize(800, 600);
            apple1.setup();
            green_bomb1.Setup();
            greenapple1.Setup();
            dudeP11.setup();
            dudeP21.setup();
            background.Setup();
            leaves.setup();

            //position1 = new Vector2(400 - Size.X / 2, 600);

            radius1 = (20);
            radius2 = (20);



        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Blue);
            background.Update();
            apple1.Update();
            green_bomb1.Update();
            dudeP11.update(dudeP21);
            dudeP21.update(dudeP11);
            greenapple1.Update();
            leaves.update();

            

           

        }
        float R = DudeP1.radius1;
      
        bool Dude1Point = Vector2.Distance(Point, position1) <= R;


        float circleradii = radius1 + radius2;


        //ask for help later
        //Trying to make players have collision.
        bool pointdude = Vector2.Distance(Point, position1) <= circleradii;



    }
}


