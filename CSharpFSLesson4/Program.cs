using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace CSharpFSLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 10;
            int i = 0;
            while (i < 6) //это шестиугольник
            {
                Turtle.Move(50);
                Turtle.Turn(60);
                i++;
            }
            Turtle.PenUp();
            Turtle.TurnLeft();
            Turtle.Move(150);
            Turtle.PenDown();

            i = 0;
            while (i < 360)  //это круг
            {
                Turtle.Turn(1);
                Turtle.Move(1);
                i++;
            }

            Turtle.PenUp();
            Turtle.TurnLeft();
            Turtle.Move(50);
            Turtle.PenDown();
            i = 0;
            while (i < 4)  //это заборчик
            {
                Turtle.Move(20);
                Turtle.TurnLeft();
                Turtle.Move(20);
                Turtle.TurnLeft();
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnRight();
                i++;
            }
        }
    }
}
