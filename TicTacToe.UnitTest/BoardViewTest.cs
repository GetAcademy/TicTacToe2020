using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TicTacToe.UnitTest
{
    class BoardViewTest
    {
        [Test]
        public void Test1()
        {
            var boardModel = new BoardModel();
            boardModel.Fill("a2", 1);
            boardModel.Fill("c1", 2);
            var boardView = new BoardView(boardModel);
            const string expected = @"  a b c
 ┌─────┐
1│    o│
2│x    │
3│     │
 └─────┘";
            Assert.AreEqual(expected, boardView.Show());
        }

        [Test]
        public void Test2()
        {
            var boardModel = new BoardModel();
            boardModel.Fill("a3", 1);
            boardModel.Fill("a2", 2);
            var boardView = new BoardView(boardModel);
            const string expected = @"  a b c
 ┌─────┐
1│     │
2│o    │
3│x    │
 └─────┘";
            Assert.AreEqual(expected, boardView.Show());
        }
    }
}
