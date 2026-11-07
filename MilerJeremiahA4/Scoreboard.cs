using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

//Using https://stackoverflow.com/questions/52803533/creating-a-highscore-table-in-c-sharp-windows-form as reference.
//Just stating incase I get this to work.

namespace MohawkGame2D
{
    public class Scoreboard
    {

        public int DudeP1;



        public void setup()
        {

            

            int[] Highscores = new int[20];
            Highscores[0] = 20;
            Highscores[1] = 19;
            Highscores[2] = 18;
            Highscores[3] = 17;
            Highscores[4] = 16;
            Highscores[5] = 15;
            Highscores[6] = 14;
            Highscores[7] = 13;
            Highscores[8] = 12;
            Highscores[9] = 11;
            Highscores[10] = 10;
            Highscores[11] = 9;
            Highscores[12] = 8;
            Highscores[13] = 7;
            Highscores[14] = 6;
            Highscores[15] = 5;
            Highscores[16] = 4;
            Highscores[17] = 3;
            Highscores[18] = 2;
            Highscores[19] = 1;
            Highscores[20] = 0;
                }
    }
}
