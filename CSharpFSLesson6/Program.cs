using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace CSharpFSLesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            int eatX = 200;
            int eatY = 200;

            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            GraphicsWindow.BrushColor = "Red";

            var eat = Shapes.AddRectangle(10, 10);
            Shapes.Move(eat, eatX, eatY);

            Random rand = new Random();

            if (Turtle.X = eatX)
            {
                Shapes.Move(eat, eatX + 100, eatX + 100);
            }
            
            Turtle.PenUp();
                        
            while (true)
            
            {
                Turtle.Move(10);
                if (Turtle.X >= eatX && Turtle.X <= eatX+10 && Turtle.Y >= eatY && Turtle.Y <= eatY+10)
                {
                    eatX = rand.Next(0, GraphicsWindow.Width);
                    eatY = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(eat, eatX, eatY);
                    Turtle.Speed++;
                }
            }

            //int getXeat = 0;
            
            
            
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }

            if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }

            if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }

            if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }

            
        }
    }
}
