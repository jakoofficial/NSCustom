using CustomNS;

cText.WriteAtPos("""
    Welcome and thanks for using CustomNS by Jako.
    This is a small collection of userfriendly
    methods designed to make programming in C#
    easier.
    """, 10, 0, "centered", ConsoleColor.Green);

//cText.WriteAtPos("Danmark er et land", 0, 10, 8, 14, ConsoleColor.Red, ConsoleColor.White);

//for (int i = 0; i < 10; i++)
//{ //
//    Thread.Sleep(10);
//    cText.ClearConsAt(10, 0, 15, 9 + i);
//    cText.WriteAtPos("Test", 10, 9 + i);
//}

//if (cText.InputCheck("Am i a human?", 'Y'))
//{
//    Console.WriteLine("\nWOOOOOOOO!");
//}

//if (cText.InputCheck("\nAm i a human?", "Yes"))
//{
//    Console.WriteLine("WOOOOOOOO!");
//}

//cText.WriteAtPos("hej", 5, 5);
//if (cText.InputCheck("hej", 'y'))
//{
//    cText.ClearConsAt(0, 0, 10, 10);
//}

//string str = "I used to like cake now i cake only eat pizza";
//Console.WriteLine(cText.RemoveWord(str,
//                                   "cake"));
//Console.WriteLine(cText.ReplaceWord(str,
//                                   "cake", "buns"));
//Console.WriteLine(cText.RemoveStringPart(str, 5, 23));

//Console.CursorVisible = false;
//string move = "[__]";
//for (int i = 0; i < 40; i++)
//{
//    cText.WriteAtPos(move, i, 5);
//    Thread.Sleep(100);
//    cText.ClearConsAt(0,4, 38, 6);
//}

cText.WriteAtPos("Press any key to continue", 0, 25);
Console.ReadKey();