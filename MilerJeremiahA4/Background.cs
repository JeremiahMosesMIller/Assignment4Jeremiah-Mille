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
            Draw.SetFillColor(0, 60, 0);
            Draw.Rectangle(400, 550, 800, 50);


        }

    }
}