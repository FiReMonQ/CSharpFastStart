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
        static void Tword(int Tsize1, int Tsize2)
        {
            Turtle.Angle = 0;
            Turtle.Move(Tsize1);

            Turtle.TurnLeft();
            Turtle.Move(Tsize2);

            Turtle.Angle = 90;
            Turtle.Move(Tsize1);

        }
        static void Rword(int Rsize1, int Rsize2, int Rsize3)
        {
            Turtle.Move(Rsize1);

            for (int i = 0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(Rsize2);
            }

            Turtle.Angle = 135;
            Turtle.Move(Rsize3);
        }
        static void Oword(int Osize)
        {
            for (int i = 0; i < 4; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(Osize);
            }
        }
        static void Pword(int Psize1, int Psize2)
        {
            Turtle.Move(Psize1);

            for (int i = 0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(Psize2);
            }
        }

        static void Main(string[] args)
        {
            Turtle.Speed = 10;

            //TORT     
            //"T" letter
            Turtle.X = 100;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            Tword(50,25);

            //"O" letter
            Turtle.X = 150;
            Turtle.Y = 150;
            Turtle.Angle = 0;

            Oword(50);

            //"R" letter
            Turtle.X = 225;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            Rword(50,25,35);

            //"T" letter
            Turtle.X = 300;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            Tword(50,25);

            //"OR"
            //"O" letter
            Turtle.X = 75;
            Turtle.Y = 270;
            Turtle.Angle = 0;

            Oword(30);

            //"R" letter
            Turtle.X = 125;
            Turtle.Y = 300;
            Turtle.Angle = 0;

            Rword(30, 15, 25);

            //"Port"
            //"P"
            Turtle.X = 200;
            Turtle.Y = 400;
            Turtle.Angle = 0;

            Pword(100,50);

            //"O" letter
            Turtle.X = 275;
            Turtle.Y = 300;
            Turtle.Angle = 0;

            Oword(100);

            //"R" letter
            Turtle.X = 400;
            Turtle.Y = 400;
            Turtle.Angle = 0;

            Rword(100, 50, 70);

            //"T" letter
            Turtle.X = 525;
            Turtle.Y = 400;
            Turtle.Angle = 0;

            Tword(100, 50);
        }


    }
}
