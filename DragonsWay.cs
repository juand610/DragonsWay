using System.IO;

namespace DragonsWay.Logic
{
     public class Game
    {
        private char[,] _maze;
        int control = 1;

        public Game(int n , string path)
        {
            N = n;
            Path = path;
            _maze = new char[N, N*2];
            FillMaze();
        }

        public int N { get; }
        public string Path { get; }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{_maze[i, j]}";
                }
                output += "\n";
            }
            return output;
        }

        private void FillMaze()
        {
            FillBorders();
            GamePat();
            


        }

        
        private void GamePat()
        {

            int i = 1; int j = 0; int k = 0;
            while (control == 1) 
            {
                _maze[i, j] = Path[k];
                if (Path[k]=='→') 
                {
                    j++;
                    k++;                
                }
                else 
                {
                    if (Path[k] == '↓')
                    {
                        i++;
                        k++;

                    }
                }
                
                if (_maze[i,j]== '█')
                {
                    Console.WriteLine("The dragon die... sorry");
                    control= 0;
                    
                }
                else
                {
                    if (i==N || j==(N*2)-2)
                    {
                        Console.WriteLine("The dragon is free!");
                        control = 0;
                    }
                }
                
            }
            //for (int i = 1; i < N; i++)
            //{
            //    for (int j = 0; j < (N*2)-2; j++)
            //    {
            //        int k = 0;
            //        _maze [i, j] = Path[k];
            //        k++;

            //    }
            //}
            
        }

        private void FillBorders()
        {
            for (int i = 0; i < N; i++)
            {
                _maze[0, i] = '█';
            }
            for (int i = 0; i < N - 1; i++)
            {
                _maze[1, i] = ' ';
            }

            _maze[1, N - 1] = '█';
            for (int i = 2; i < N - 2; i++)
            {
                _maze[i, 0] = '█';
                for (int j = 1; j < N - 1; j++)
                {
                    _maze[i, j] = ' ';
                }
                _maze[i, N - 1] = '█';
            }
            _maze[N - 2, 0] = '█';
            for (int i = 1; i < N; i++)
            {
                _maze[N - 2, i] = ' ';
            }

            for (int i = 0; i < N; i++)
            {
                _maze[N - 1, i] = '█';
            }
        }
    }
}