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
            Turtle.Speed = 9;
            int i = 0;

            while (i < 6)
            {
                Turtle.Move(100);
                Turtle.Turn(60);
                i++;
            }

            Turtle.Move(50);
            Turtle.TurnRight();

            while (i < 9)
            {
            Turtle.Move(25);
            Turtle.TurnRight();

            Turtle.Move(25);
            Turtle.TurnLeft();

            Turtle.Move(25);
            Turtle.TurnLeft();

            Turtle.Move(25);
            Turtle.TurnRight();

            i++;
            }
            Turtle.Move(23);
            Turtle.TurnLeft();
        }
    }
}
