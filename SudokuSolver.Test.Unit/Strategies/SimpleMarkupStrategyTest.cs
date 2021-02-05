using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver.Strategies;
using SudokuSolver.Workers;

namespace SudokuSolver.Test.Unit.Strategies
{
    [TestClass]
    public class SimpleMarkupStrategyTest
    {
        private readonly ISudokuStrategy _simpleMarkupSudokuStrategy = new SimpleMarkupStrategy(new SudokuMapper());

        [TestMethod]
        public void SimpleStrategyShouldSolveAlmostCompletedSudokuForTopLeftCell()
        {
        }
    }
}
