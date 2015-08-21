namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class GameEngine
    {
        private const int MAX_SCORE = (FIELD_ROWS * FIELD_COLS) - MINES_NUMBER;
        private const int FIELD_ROWS = 5;
        private const int FIELD_COLS = 10;
        private const int FIELD_SIZE = FIELD_ROWS * FIELD_COLS;
        private const int MINES_NUMBER = 15;
        private const char UNCOVERD_FIELD_SYMBOL = '?';
        private const char WITHOUT_MINE_FIELD_SYMBOL = '-';
        private const char MINE_SYMBOL = '*';
        private const int MAX_NUMBER_OF_PLAYERS_IN_TOP_SCORE_LIST = 6;

        internal static void Run()
        {
            string currentCommand = string.Empty;
            char[,] fields = CreateGameFields();
            char[,] mines = AddMines();
            int scoreCounter = 0;
            bool gameOver = false;
            List<Player> topPlayersScore = new List<Player>(MAX_NUMBER_OF_PLAYERS_IN_TOP_SCORE_LIST);
            int row = 0;
            int col = 0;
            bool showGameMenu = true;
            bool gameWon = false;

            do
            {
                if (showGameMenu)
                {
                    Console.WriteLine(">>> Mine Sweeper - Console Edition <<<\nTry uncovering all fields without stepping on a mine.\n" +
                    "Commands:\n'top' -       displays the Highscore\n\r'restart' -   initiates a new game\n\r'exit' -      terminates the game.");
                    PrintGameField(fields);
                    showGameMenu = false;
                }

                Console.Write("Please, enter row and column: ");
                currentCommand = Console.ReadLine().Trim();
                if (currentCommand.Length >= 3)
                {
                    if (int.TryParse(currentCommand[0].ToString(), out row) &&
                    int.TryParse(currentCommand[2].ToString(), out col) &&
                        row <= fields.GetLength(0) && col <= fields.GetLength(1))
                    {
                        currentCommand = "turn";
                    }
                }

                switch (currentCommand)
                {
                    case "top":
                        PrintScore(topPlayersScore);
                        break;
                    case "restart":
                        fields = CreateGameFields();
                        mines = AddMines();
                        PrintGameField(fields);
                        gameOver = false;
                        showGameMenu = false;
                        break;
                    case "exit":
                        Console.WriteLine("Good Bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != MINE_SYMBOL)
                        {
                            if (mines[row, col] == WITHOUT_MINE_FIELD_SYMBOL)
                            {
                                GetPlayerMove(fields, mines, row, col);
                                scoreCounter++;
                            }

                            if (MAX_SCORE == scoreCounter)
                            {
                                gameWon = true;
                            }
                            else
                            {
                                PrintGameField(fields);
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalidcommand!\n");
                        break;
                }

                if (gameOver)
                {
                    PrintGameField(mines);
                    Console.Write(
                        "GAME OVER!\nYour Score: {0} points. \nPlease Enter Your Name: ", scoreCounter);
                    string name = Console.ReadLine();
                    Player currentPlayer = new Player(name, scoreCounter);
                    if (topPlayersScore.Count < MAX_NUMBER_OF_PLAYERS_IN_TOP_SCORE_LIST-1)
                    {
                        topPlayersScore.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayersScore.Count; i++)
                        {
                            if (topPlayersScore[i].Points < currentPlayer.Points)
                            {
                                topPlayersScore.Insert(i, currentPlayer);
                                topPlayersScore.RemoveAt(topPlayersScore.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayersScore.Sort((Player x, Player y) => y.Name.CompareTo(x.Name));
                    topPlayersScore.Sort((Player x, Player y) => y.Points.CompareTo(x.Points));
                    PrintScore(topPlayersScore);
                    fields = CreateGameFields();
                    mines = AddMines();
                    scoreCounter = 0;
                    gameOver = false;
                    showGameMenu = true;
                }

                if (gameWon)
                {
                    Console.WriteLine("\nCONGRATULATIONS! YOU WON!");
                    PrintGameField(mines);
                    Console.WriteLine("\nPlease, Enter your name: ");
                    string name = Console.ReadLine();
                    Player currentPlayer = new Player(name, scoreCounter);
                    topPlayersScore.Add(currentPlayer);
                    PrintScore(topPlayersScore);
                    fields = CreateGameFields();
                    mines = AddMines();
                    scoreCounter = 0;
                    gameWon = false;
                    showGameMenu = true;
                }
            }
            while (currentCommand != "Exit");
            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("GOOD BYE");
            Console.Read();
        }

        private static void PrintScore(List<Player> players)
        {
            Console.WriteLine("\nPlayers:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Score list is empty\n");
            }
        }

        private static void GetPlayerMove(char[,] gameField, char[,] mines, int row, int col)
        {
            char numberOfMines = GetMinesNubmer(mines, row, col);
            mines[row, col] = numberOfMines;
            gameField[row, col] = numberOfMines;
        }

        private static void PrintGameField(char[,] field)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        // Add new method for avoiding repeating code in the next two methods.
        private static char[,] GenerateGameFields(char symbol)
        {
            int fieldRows = FIELD_ROWS;
            int fieldColumns = FIELD_COLS;
            char[,] board = new char[fieldRows, fieldColumns];
            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldColumns; j++)
                {
                    board[i, j] = symbol;
                }
            }

            return board;
        }

        private static char[,] CreateGameFields()
        {
            char symbol = UNCOVERD_FIELD_SYMBOL;
            char[,] gameField = GenerateGameFields(symbol);
            return gameField;
        } 

        private static char[,] AddMines()
        {
            char symbol = WITHOUT_MINE_FIELD_SYMBOL;
            int cols = FIELD_COLS;
            char[,] gameField = GenerateGameFields(symbol);

            List<int> mines = new List<int>();

            while (mines.Count < MINES_NUMBER)
            {
                Random random = new Random();
                int randomNumber = random.Next(FIELD_SIZE);
                if (!mines.Contains(randomNumber))
                {
                    mines.Add(randomNumber);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / cols;
                int row = mine % cols;
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = MINE_SYMBOL;
            }

            return gameField;
        } 

        private static void PrintNeighbourMinesNumber(char[,] fields)
        {
            int col = fields.GetLength(0);
            int row = fields.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (fields[i, j] != MINE_SYMBOL)
                    {
                        char addMines = GetMinesNubmer(fields, i, j);
                        fields[i, j] = addMines;
                    }
                }
            }
        }

        private static char GetMinesNubmer(char[,] playFields, int row, int col)
        {
            int minesNumber = 0;
            int rows = playFields.GetLength(0);
            int cols = playFields.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playFields[row - 1, col] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if (row + 1 < rows)
            {
                if (playFields[row + 1, col] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playFields[row, col - 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if (col + 1 < cols)
            {
                if (playFields[row, col + 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playFields[row - 1, col - 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (playFields[row - 1, col + 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playFields[row + 1, col - 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (playFields[row + 1, col + 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            return char.Parse(minesNumber.ToString());
        }
    }
}