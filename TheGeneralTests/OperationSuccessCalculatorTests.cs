using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheGeneral;

namespace TheGeneralGameTests
{
    [TestClass]
    public class TheGeneralTests
    {
        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(199, 2)]
        [DataRow(198, 299)]
        [DataRow(2, 299)]
        public void AttackSuccessfulWithValidCoordinates(int x, int y)
        {
            bool expectedResult = true;

            Game game = new Game();
            bool actualResult = game.IsAttackSuccessful(x, y);

            Assert.AreEqual(expectedResult, actualResult, "Expected attack to succeed but it did not");
        }

        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(199, 299)]
        public void AttackUnsuccessfulWithValidCoordinates(int x, int y)
        {
            bool expectedResult = false;
            Game game = new Game();
            bool actualResult = game.IsAttackSuccessful(x, y);

            Assert.AreEqual(expectedResult, actualResult, "Expected attack to fail but it did not");
        }

        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(199, 2)]
        [DataRow(198, 299)]
        [DataRow(2, 299)]
        public void DefenseSuccessfulWithValidCoordinates(int x, int y)
        {
            bool expectedResult = true;

            Game game = new Game();
            bool actualResult = game.IsAttackSuccessful(x, y);

            Assert.AreEqual(expectedResult, actualResult, "Expected defense to succeed but it did not");
        }

        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(199, 299)]
        public void DefenseUnsuccessfulWithValidCoordinates(int x, int y)
        {
            bool expectedResult = false;

            Game game = new Game();
            bool actualResult = game.IsAttackSuccessful(x, y);

            Assert.AreEqual(expectedResult, actualResult, "Expected defense to fail but it did not");
        }

        [DataTestMethod]
        [DataRow(-1, 5)]
        [DataRow(5, -1)]
        [DataRow(200, 1)]
        [DataRow(1, 300)]
        public void AttackThrowsExceptionWithInvalidCoordinates(int x, int y)
        {
            Game game = new Game();

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => game.IsAttackSuccessful(x, y));
        }

        [DataTestMethod]
        [DataRow(-1, 5)]
        [DataRow(5, -1)]
        [DataRow(200, 1)]
        [DataRow(1, 300)]
        public void DefenseThrowsExceptionWithInvalidCoordinates(int x, int y)
        {
            Game game = new Game();

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => game.IsDefenseSuccessful(x, y));
        }
    }
}
