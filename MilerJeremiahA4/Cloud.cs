using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
   
    
    public class Cloud
    {
        public int x = 0;
       public int y = 0;
        public int w = 0;

     
      
     
       
        public void Setup()
        {
            x = Random.Integer(20, 780);
            y = Random.Integer(1, 170);
            w = Random.Integer(30, 80);
            //So what I just learned that I feel is worth noting for the future. If you put the Random.Integer into Update it Constantly Update it's position, which obviously makes sense and all, but the way it was moving
            //within my prior set up is worth noting as I can use it for future games!
        }

        public void Update()
        { 
         
            RenderClouds();
        }

        void RenderClouds()
        {
            Draw.SetLineColor(10);
            Draw.SetFillColor(200);
            Draw.Ellipse(x, y, 100, 50);

           


        }
    
    }

    }

