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

      
        

      
        Leaves leaves = new Leaves();
        Background background = new Background();
        DudeP2 dudeP21 = new DudeP2();
        Apple apple1 = new Apple();
       Green_Bomb green_bomb1 = new Green_Bomb();
        Green_Bomb green_bomb2 = new Green_Bomb();
        Green_Bomb green_bomb3 = new Green_Bomb();


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
            //dont know why, but green_bombs = new Green_bomb impacts speed
            green_bombs = new Green_Bomb[2];

           
          

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Blue);
            background.Update();
            apple1.Update();
            
            dudeP11.update(greenapple1, green_bomb1);
            dudeP21.update(dudeP11);
            greenapple1.Update();
            leaves.update();
            updatescore();
            greenbombrandom();


            for (int i = 0; i < green_bombs.Length; i++)
            {
                  if (green_bombs[i] != null)
                    green_bomb1.Update();
                green_bomb2.Update();
                green_bomb3.Update();


            }

           

        }
      
       void updatescore()
        {
            Text.Color = Color.White;
            Text.Draw(dudeP11.score.ToString(), new Vector2(20, 20));

        }

        public void greenbombrandom()
        {

           

            for (int i = 0; i < green_bombs.Length; i++)
            {
                if (green_bombs[i] == null)

                green_bombs[i] = new Green_Bomb();
                green_bombs[i].Setup();

               
            }

        }

    }
}


