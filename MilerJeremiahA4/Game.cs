// Include the namespaces (code libraries) you need below.
using MilerJeremiahA4;
using System;
using System.Numerics;
using System.Threading;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {

        Apple apple1 = new Apple();
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        /// 

        Apple[] Apples;
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.ClearBackground(Color.Blue);

            apple1.Setup();

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            apple1.Update();

          
        }
    }

}
