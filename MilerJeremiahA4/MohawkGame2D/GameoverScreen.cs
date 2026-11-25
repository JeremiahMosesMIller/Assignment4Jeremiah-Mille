using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class GameoverScreen
    {

        public Vector2 position1;

        public void Setup(DudeP1 dudep1)
        { }
        

        public void Update(DudeP1 dudep1)
        {DrawDefeat1(dudep1); }

      

        void DrawDefeat1(DudeP1 dudep1)
        {
            if (dudep1.position1.Y < -1000)
            {
                Draw.SetFillColor(20);
                Draw.Rectangle(1, 1, 800, 600);

                Text.Color = MohawkGame2D.Color.White;
                Text.Draw("Game over", new Vector2(320, 300));

                Text.Color = MohawkGame2D.Color.Blue;
                Text.Draw("Blue Wins", new Vector2(320, 400));
            }
          
        }

        void DrawDefeat1(DudeP2 dudep2)
        {
            if (dudep2.position2.Y < -1000)
            {
                Draw.SetFillColor(20);
                Draw.Rectangle(1, 1, 800, 600);

                Text.Color = MohawkGame2D.Color.White;
                Text.Draw("Game over", new Vector2(320, 300));

                Text.Color = MohawkGame2D.Color.Red;
                Text.Draw("Red Wins", new Vector2(320, 400));
            }

        }





    }
}
