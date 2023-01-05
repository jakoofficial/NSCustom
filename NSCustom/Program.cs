using CustomNS;

cText.WriteAtPos("""
    Welcome and thanks for using CustomNS by Jako.
    This is a small collection of userfriendly
    methods designed to make programming in C#
    easier.
    """, 10, 0, "centered", ConsoleColor.Green);

cText.WriteAtPos("Danmark er et land", 0, 10, 8, 14, ConsoleColor.Red, ConsoleColor.White);

//for (int i = 0; i < 10; i++)
//{ //
//    Thread.Sleep(10);
//    cText.ClearConsAt(10, 0, 15, 9 + i);
//    cText.WriteAtPos("Test", 10, 9 + i);
//}


cText.WriteAtPos("Press any key to continue", 0, 6);
Console.ReadKey();