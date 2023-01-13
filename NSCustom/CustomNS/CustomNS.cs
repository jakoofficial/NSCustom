using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomNS
{
    public static class cText
    {
        //* Custom functions *//
        #region WriteAtPos
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
            Console.ResetColor();
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
        #endregion

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

        #region InputCheck
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
        /// <summary>
        /// Makes the user input an integer and gets true/false in return depending on the expected integer result
        /// </summary>
        /// <param name="textToShow">The text before the quesiton</param>
        /// <param name="expected">the expected input</param>
        /// <returns>Boolean</returns>
        public static bool InputCheck(string textToShow, int expected)
        {
            Console.WriteLine(textToShow);
            int i;
            int.TryParse(Console.ReadLine(), out i);
            if (i == expected)
                return true;
            else
                return false;

        }
        #endregion

        #region String Extras
        /// <summary>
        /// Removes a part of a string at the start and end positions given by their respective integers
        /// </summary>
        /// <param name="strToChange">The string to change</param>
        /// <param name="removeStart">The start position for removal in the string</param>
        /// <param name="removeEnd">The end position for removal in the string</param>
        /// <returns>string</returns>
        public static string RemoveStringPart(string strToChange, int removeStart, int removeEnd)
        {
            char[] chars = strToChange.ToCharArray();
            string newStr = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if (!(i >= removeStart && i < removeEnd))
                {
                    newStr += chars[i];
                }
            }

            return newStr;
        }
        /// <summary>
        /// Removes a chosen word from a string everytime it is used
        /// </summary>
        /// <param name="strToChange">The string where the word can be found</param>
        /// <param name="wordToRemove">The word to remove</param>
        /// False: Removes every instance of the word.
        /// </param>
        /// <returns>string</returns>
        public static string RemoveWord(string strToChange, string wordToRemove)
        {
            string[] strArr = strToChange.Split(' ');
            string newStr = "";

            foreach (var w in strArr)
            {
                if (w.ToLower() != wordToRemove.ToLower())
                    newStr += w + " ";
            }

            return newStr;
        }

        /// <summary>
        /// Replaces a word from a string with a new word (Needs to be surrounded by a space on both sides to work)
        /// </summary>
        /// <param name="str">The string</param>
        /// <param name="wordToReplace">The word you want to replace</param>
        /// <param name="replacement">The replacement word</param>
        /// <returns></returns>
        public static string ReplaceWord(string str, string wordToReplace, string replacement)
        {
            string[] strArr = str.Split(' ');
            string newStr = "";

            foreach (var w in strArr)
            {
                if (w.ToLower() == wordToReplace.ToLower())
                {
                    newStr += replacement + " ";
                }
                else newStr += w + " ";
            }

            return newStr;
        }

        /// <summary>
        /// Moves the string along the x-axis to the desired distance and speed
        /// </summary>
        /// <param name="strToMove">The string</param>
        /// <param name="speed">The speed used to move the string</param>
        /// <param name="startXPos">The start point for the string</param>
        /// <param name="yPos">The Y point for the string</param>
        /// <param name="distance">The amount the string needs to move</param>
        /// <returns></returns>
        public static string MoveStringX(string strToMove, int speed, int startXPos, int yPos, int distance)
        {
            Console.SetCursorPosition(startXPos, yPos);
            for (int i = 0; i < distance; i++)
            {

            }

            return "";
        }
        /// <summary>
        /// Moves the string along the y-axis to the desired distance and speed
        /// </summary>
        /// <param name="strToMove">The string</param>
        /// <param name="speed">The speed used to move the string</param>
        /// <param name="yPos">The end point for the string</param>
        /// <returns></returns>
        public static string MoveStringY(string strToMove, int speed, int yPos)
        {


            return "";
        }
        #endregion
    }
}
