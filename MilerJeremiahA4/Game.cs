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

        GameoverScreen gameoverscreen = new GameoverScreen();
        DudeP2 dudeP21 = new DudeP2();
        DudeP1 dudeP11 = new DudeP1();
        Leaves leaves = new Leaves();
        Background background = new Background();
        RedApple redapple1 = new RedApple();
        Green_Bomb green_bomb = new Green_Bomb();
        Cloud clouds = new Cloud();




        GreenApple greenapple1 = new GreenApple();


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        /// 


        Green_Bomb[] green_bombs;

        Cloud[] cloud;

        public void Setup()
        {
            Window.SetSize(800, 600);

            redapple1.Setup();
            greenapple1.Setup();
            green_bomb.Setup();
            greenapple1.Setup();
            background.Setup();
            leaves.setup();
            dudeP11.setup();
            dudeP21.setup();
            clouds.Setup();
            RandomizeClouds();
            Greenbombrandom();



            //dont know why, but green_bombs = new Green_bomb impacts speed
        

           

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Blue);
            background.Update();
            redapple1.Update();
            greenapple1.Update();
            greenapple1.Update();
            leaves.update();
            updatescore();
            updatescore2();
            Greenbombrandom();

            dudeP11.update(greenapple1, green_bomb, redapple1);
            dudeP21.update(greenapple1, green_bomb, redapple1);
            gameoverscreen.Update(dudeP11, dudeP21);
           

            for (int i = 0; i < green_bombs.Length; i++)
            {
                    green_bomb.Update();
            }

            for (int i = 0; i < cloud.Length; i++)
            { cloud[i].Update(); }
        }



        void updatescore2()
        {
            Text.Color = Color.Blue;
            Text.Draw(dudeP21.score2.ToString(), new Vector2(700, 20));
        }
        void updatescore()
        {
            Text.Color = Color.Red;
            Text.Draw(dudeP11.score.ToString(), new Vector2(100, 20));
        }

        public void Greenbombrandom()
        {

            green_bombs = new Green_Bomb[5];

            for (int i = 0; i < green_bombs.Length; i++)
            {

                green_bombs[i] = new Green_Bomb();
                green_bombs[i].Setup();

            }



        }

        public void RandomizeClouds()
        {

            cloud = new Cloud[40];

            for (int i = 0; i < cloud.Length; i++)
            {

                cloud[i] = new Cloud();
                cloud[i].Setup();


            }

        }
    }
}

