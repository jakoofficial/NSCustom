using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomNS
{
    public static class cText
    {
        //*  *//
        /// <summary>
        /// Used to set a text string in a specific position in the console
        /// </summary>
        /// <param name="text">The text to show</param>
        /// <param name="left">The console left position</param>
        /// <param name="top">The console top position</param>
        public static void WriteAtPos(string text, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(text);
        }

        /// <summary>
        /// Used to set a multiline text string in a specific position in the console with an orientation
        /// </summary>
        /// <param name="text">The text to show</param>
        /// <param name="left">The console left position</param>
        /// <param name="top">The console top position</param>
        /// <param name="orientaion">normal, centered</param>
        public static void WriteAtPos(string text, double left, int top, string orientaion)
        { //Normal, Centered  
            var stringArr = text.Split('\n');

            int lineNumb = 0;
            double cLeft = left;

            foreach (var line in stringArr)
            {
                if (orientaion.ToLower() == "centered")
                {
                    int strLength = line.Length;
                    if (lineNumb != 0)
                    {
                        int lastLine = lineNumb - 1;
                        double lastHalf = (stringArr[0].Length - strLength) / 2;
                        cLeft = left + Math.Round(lastHalf);
                    }
                }

                Console.SetCursorPosition((int)cLeft, top + lineNumb);
                Console.Write(stringArr[lineNumb]);
                lineNumb++;
            }

            //Console.SetCursorPosition((int)left, top);
            //Console.WriteLine(text);
        }

        /// <summary>
        /// Used to set a multiline text string in a specific position
        /// in the console with an orientation and a color
        /// * THE COLOR WILL REMAIN AFTERWARDS *
        /// </summary>
        /// <param name="text">The text to show</param>
        /// <param name="left">The console left position</param>
        /// <param name="top">The console top position</param>
        /// <param name="orientaion">normal, centered</param>
        /// <param name="color">The color of the text</param>
        public static void WriteAtPos(string text, double left, int top, string orientaion, ConsoleColor color)
        { //Normal, Centered  
            var stringArr = text.Split('\n');

            int lineNumb = 0;
            double cLeft = left;

            foreach (var line in stringArr)
            {
                if (orientaion.ToLower() == "centered")
                {
                    int strLength = line.Length;
                    if (lineNumb != 0)
                    {
                        int lastLine = lineNumb - 1;
                        double lastHalf = (stringArr[0].Length - strLength) / 2;
                        cLeft = left + Math.Round(lastHalf);
                    }
                }

                Console.SetCursorPosition((int)cLeft, top + lineNumb);
                Console.ForegroundColor = color;
                Console.Write(stringArr[lineNumb]);
                lineNumb++;
            }

            //Console.SetCursorPosition((int)left, top);
            //Console.WriteLine(text);
        }

        /// <summary>
        /// Used to set a text string in a specific position in the console
        /// with a color
        /// * THE COLOR WILL REMAIN AFTERWARDS *
        /// </summary>
        /// <param name="text">The text to show</param>
        /// <param name="left">The console left position</param>
        /// <param name="top">The console top position</param>
        /// <param name="color">The color of the text</param>
        public static void WriteAtPos(string text, int left, int top, ConsoleColor color)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }

        /// <summary>
        /// Clear the console at a position
        /// </summary>
        /// <param name="sLeft">Start left position</param>
        /// <param name="sTop">Start top position</param>
        /// <param name="eLeft">End left position</param>
        /// <param name="eTop">End top position</param>
        public static void ClearConsAt(int sLeft, int sTop, int eLeft, int eTop)
        {
            while (sTop != eTop)
            {
                Console.SetCursorPosition(sLeft, sTop);
                for (int i = sLeft; i <= eLeft; i++)
                {
                    Console.Write(" ");
                }
                sTop++;
            }
        }
    }
}
