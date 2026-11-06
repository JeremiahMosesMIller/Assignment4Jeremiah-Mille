// Include the namespaces (code libraries) you need below.
using MilerJeremiahA4;
using System;
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

        OtherDude otherdude1 = new OtherDude();
        Apple apple1 = new Apple();
        Green_Bomb green_bomb1 = new Green_Bomb ();

        GreenApple greenapple1 = new GreenApple();

        Dude dude1 = new Dude();
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        /// 

        Apple[] Apples;
        Green_Bomb[] green_bombs;
        GreenApple[] greenapples;
        public void Setup()
        {
            Window.SetSize(800, 600);
            apple1.Setup();
            green_bomb1.Setup();
            greenapple1.Setup();
            dude1.setup();
            otherdude1.setup();

          

         
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Blue);
            apple1.Update();
            green_bomb1.Update();
            dude1.update();
            otherdude1.update();
            greenapple1.Update();



        }

    
     
        
          
        }
    }


