using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilerJeremiahA4
{
    internal class Apple
    {
        public void Setup()
        {

        }

        public void Update()
        {
            DrawApple();
        }
    }
}

void DrawApple()
{
    Draw.SetFillColor(Color.Red);
    Draw.Circle(400, 200, 40);

    Draw.SetFillColor(165, 42, 42);
    Draw.Rectangle(395, 156, 10, 20);

    Draw.SetFillColor(165, 42, 42);
    Draw.Rectangle(395, 149, 10, 20);

    Draw.SetFillColor(165, 42, 42);
    Draw.Rectangle(397, 145, 8, 10);

    Draw.SetFillColor(165, 42, 42);
    Draw.Rectangle(399, 147, 8, 10);

    Draw.SetFillColor(200);
    Draw.Capsule(390, 200, 380, 190, 5);
}