using System;
using SudokuSolver.Strategies;
using SudokuSolver.Workers;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SudokuMapper sudokuMapper = new SudokuMapper();
                SudokuBoardStateManager sudokuBoardStateManager = new SudokuBoardStateManager();
                SudokuSolverEngine sudokuSolverEngine = new SudokuSolverEngine(sudokuBoardStateManager, sudokuMapper);
                SudokuFileReader sudokuFileReader = new SudokuFileReader();
                SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

                Console.WriteLine("Please enter the filename containing the Sudoku Puzzle:");

                var filename = Console.ReadLine();

                var sudokuBoard = sudokuFileReader.ReadFile(filename);
                sudokuBoardDisplayer.Display("Initial State", sudokuBoard);

                bool IsSudokuSolved = sudokuSolverEngine.Solve(sudokuBoard);
                sudokuBoardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(IsSudokuSolved
                    ? "You have successfully solved this Sudoku Puzzle!"
                    : "Unfortunately, current algorithm(s) were not enough to solve the current Sudoku Puzzle!");
            }
            catch (Exception ex)
            {
                //In real world we would log the message in a db
                Console.WriteLine("{0} : {1}", "Sudoku Puzzle could not be solved because there was an error: ", ex.Message);
            }
        }
    }
}
