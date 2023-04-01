using DragonsWay.Logic;

Console.WriteLine("*** Dragon's Way ***\n");
var game = new Game(9, "→→→↓↓↓→→→↓↓↓→→→→→→→→→↓→→→→→→");
var game2 = new Game(9, "→→→→→→→→→→→→→→→→→→→→→→→→→→→→→→→→→→→→");
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(game);
Console.WriteLine(game2);
Console.BackgroundColor = ConsoleColor.Black;




//Console.BackgroundColor = ConsoleColor.Blue;
//Console.ForegroundColor = ConsoleColor.Yellow;
//var maze = new Game(20, "→→→↓↓↓→→→↓↓↓→→→→→→→→→↓→→→→→→");
//Console.Write(maze);
//Console.ForegroundColor = ConsoleColor.White;
//Console.BackgroundColor = ConsoleColor.Black;

