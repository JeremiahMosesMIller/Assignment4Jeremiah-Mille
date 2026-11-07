using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Background
    {
        public void Setup()
        { }

        public void Update()
        {
            DrawBackground();

        }
        void DrawBackground()
        {

            Draw.SetLineSize(0);
            
            //Floor

            Draw.SetFillColor(0, 60, 0);
            Draw.Rectangle(0, 560, 800, 50);
            //Tree
            

            Draw.SetFillColor(120, 80, 60);
            Draw.Rectangle(400, 0, 200, 600);

            Draw.SetFillColor(0, 60, 0);
            Draw.Rectangle(0, 560, 800, 50);

            Draw.SetFillColor(120, 80, 60);
            Draw.Triangle(300, 150, 400, 200, 400, 300);

            Draw.SetFillColor(120, 80, 60);
            Draw.Triangle(600, 190, 600, 220, 670, 140);
          

          


        }

    }
}