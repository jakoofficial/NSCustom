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
        /// Change the color in a string
        /// </summary>
        /// <param name="text">The text to show</param>
        /// <param name="left">Start left position of text</param>
        /// <param name="top">Start top position of text</param>
        /// <param name="colorStartPos">The start position for color</param>
        /// <param name="colorEndPos">End position of color</param>
        /// <param name="startColor">The main color for the line</param>
        /// <param name="newColor">The new color for part of string</param>
        public static void WriteAtPos(string text, int left, int top, int colorStartPos, int colorEndPos, ConsoleColor startColor, ConsoleColor newColor)
        {
            char[] chars = text.ToCharArray();
            int numb = 0;
            Console.SetCursorPosition(left, top);
            foreach (var c in chars)
            {
                Console.ForegroundColor = startColor;
                if (numb >= colorStartPos && numb < colorEndPos)
                {
                    Console.ForegroundColor = newColor;
                }
                Console.Write(chars[numb]);
                numb++;
            }

            //Console.WriteLine(txt);
            Console.ResetColor();
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
            while (sTop != eTop && sTop < eTop && sLeft < eLeft)
            {
                Console.SetCursorPosition(sLeft, sTop);
                for (int i = sLeft; i <= eLeft; i++)
                {
                    Console.Write(" ");
                }
                sTop++;
            }
            if (sTop > eTop || sLeft > eLeft)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nsTop might be higher than eTop\n" +
                                  "sLeft might be higher than eLeft");
            }
        }

        /// <summary>
        /// Makes the user write a text string and gets true/false in return depending on the expected result
        /// </summary>
        /// <param name="textToShow">The text before the quesiton</param>
        /// <param name="expected">the expected input</param>
        /// <returns>Boolean</returns>
        public static bool InputCheck(string textToShow, string expected)
        {
            Console.WriteLine(textToShow);
            if (Console.ReadLine().ToLower() == expected.ToLower())
                return true;
            else
                return false;
        }
        /// <summary>
        /// Makes the user press a key and gets true/false in return depending on the expected char result
        /// </summary>
        /// <param name="textToShow">The text before the quesiton</param>
        /// <param name="expected">the expected input</param>
        /// <returns>Boolean</returns>
        public static bool InputCheck(string textToShow, char expected)
        {
            Console.WriteLine(textToShow);
            if (Console.ReadKey().KeyChar.ToString().ToLower() == expected.ToString().ToLower())
                return true;
            else
                return false;
        }
    }
}
