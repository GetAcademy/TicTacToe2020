using System.Linq;
using NUnit.Framework;

namespace TicTacToe.UnitTest
{
    public class Tests
    {
        [Test]
        public void TestDefaultValue()
        {
            var boardModel = new BoardModel();
            var i = boardModel.GetSquare(5);
            Assert.AreEqual(0, i);
        }

        [Test]
        public void TestSetX()
        {
            var boardModel = new BoardModel();
            boardModel.Fill("b2", 1);
            var i = boardModel.GetSquare(4);
            Assert.AreEqual(1, i);
        }

        [Test]
        public void TestSetX2()
        {
            var boardModel = new BoardModel();
            boardModel.Fill("c3", 2);
            var i = boardModel.GetSquare(8);
            Assert.AreEqual(2, i);
        }

        [Test]
        public void TestSetInvalidSquareContent()
        {
            var boardModel = new BoardModel();
            boardModel.Fill("c3", 1);
            boardModel.Fill("c3", 0);
            var i = boardModel.GetSquare(8);
            Assert.AreEqual(1, i);
        }

        [Test]
        public void TestRandom()
        {
            var boardModel = new BoardModel();
            boardModel.SetRandom(1);
            var count = Enumerable.Range(0, 9).Count(i=> boardModel.GetSquare(i) == 1);
            //var count = 0;
            //for(var i = 0; i < 9; i++)
            //{
            //    if (boardModel.GetSquare(i) == 1) count++;
            //}
            Assert.AreEqual(1,count);
        }

        [Test]
        public void TestBoardIsNotFull()
        {
            var boardModel = new BoardModel();
            Assert.IsFalse(boardModel.BoardIsFull());
        }

        [Test]
        public void TestBoardIsFull()
        {
            var boardModel = new BoardModel();
            boardModel.SetRandom(1);
            boardModel.SetRandom(2);
            boardModel.SetRandom(1);
            
            boardModel.SetRandom(2);
            boardModel.SetRandom(1);
            boardModel.SetRandom(2);

            boardModel.SetRandom(1);
            boardModel.SetRandom(2);
            boardModel.SetRandom(1);
            Assert.IsTrue(boardModel.BoardIsFull());
        }
    }
}