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
            Draw.SetFillColor(0, 40, 0);
            Draw.Circle(380, 10, 200);

            Draw.SetFillColor(0, 40, 0);
            Draw.Circle(760, 10, 200);

            Draw.SetFillColor(120, 80, 60);
            Draw.Rectangle(400, 0, 200, 600);

            Draw.SetFillColor(0, 60, 0);
            Draw.Rectangle(0, 560, 800, 50);

            Draw.SetFillColor(120, 80, 60);
            Draw.Triangle(300, 150, 400, 200, 400, 300);

            Draw.SetFillColor(120, 80, 60);
            Draw.Triangle(600, 190, 600, 220, 670, 140);
            //leaves

            Draw.SetFillColor(0, 40, 0);
            Draw.Circle(265, 70, 60);



            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(100, 0, 100);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(160, 150, 100);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(110, 150, 100);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(265, -10, 100);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(250, 200, 100);


            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(380, 200, 100);


            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(500, 190, 100);


            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(600, 150, 100);


            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(700, 120, 100);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(760, 90, 100);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(780, 140, 70);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(450, 140, 90);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(490, 30, 70);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(495, 35, 85);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(600, 35, 40);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(600, 10, 20);

            Draw.SetFillColor(0, 80, 0);
            Draw.Circle(400, 25, 60);



        }

    }
}