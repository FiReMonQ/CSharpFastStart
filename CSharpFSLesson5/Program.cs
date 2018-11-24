using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace CSharpFSLesson5
{
    class Program
    {

        void Tletter()
        {
            Turtle.Angle = 0;
            Turtle.Move(50);

            Turtle.TurnLeft();
            Turtle.Move(25);

            Turtle.Angle = 90;
            Turtle.Move(50);

        }

        static void Main(string[] args)
        {
                      
            Turtle.Speed = 9;
            Turtle.X = 100;
            Turtle.Y = 200;
            //Turtle.Hide();

            //TORT

            //"T" letter
            Tletter();

            //"O" letter
            Turtle.X = 150;
            Turtle.Y = 150;

            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.TurnRight();
                Turtle.Move( 50 );
            }

            //"R" letter
            Turtle.X = 225;
            Turtle.Y = 200;
            
            Turtle.Angle = 0;
            Turtle.Move(50);

            for (int i = 0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(25);
            }

            Turtle.Angle = 135;
            Turtle.Move(35);

            //Last "T"
            Turtle.X = 300;
            Turtle.Y = 200;

            Turtle.Angle = 0;
            Tletter();
        }
    }
}
