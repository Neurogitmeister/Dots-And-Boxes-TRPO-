using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dots_And_Boxes__TRPO_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;

namespace Dots_And_Boxes__TRPO_.Tests
{
    [TestClass()]
    public class GameLogicTests
    {

        [TestMethod]
        public void testPixelDistance()
        {
            // arrange
            int faultFlagX = 0;
            int faultFlagY = 0;
            int expected = 0;
            int width = 400;
            int height = 400;
            BusinessLogic testObject = new BusinessLogic();
            testObject.x = 10;
            testObject.y = 10;

            // act
            testObject.dots(width, height);

            for (int i = 0; i < testObject.x - 1; i++)
                for (int j = 0; j < testObject.y - 1; j++)
                {
                    if (testObject.points[i + 1, j].X - testObject.points[i, j].X != width / testObject.x)
                        faultFlagX = 1;
                    if (testObject.points[i, j + 1].Y - testObject.points[i, j].Y != height / testObject.y)
                        faultFlagY = 1;
                }

            //assert
            Assert.AreEqual(expected, faultFlagX);
            Assert.AreEqual(expected, faultFlagY);
        }

        [TestMethod]
        public void testConvertPixelSize()
        {
            // arrange
            
            int height = 100;
            int width = 100;
            int x = 4;
            int y = 5;
            int expected = 10;
            BusinessLogic testObj = new BusinessLogic();
            testObj.x = x;
            testObj.y = y;
            Point p = new Point( width / x / 2 + 50, 50);

            // act
            int number = testObj.convertPixelsToPointNumber(width, height, p);
            
            // assert
            Assert.AreEqual(expected, number);
        }

       [TestMethod]
       public void testIndexTracker()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            int pixels_x = 400;
            int pixels_y = 400;
            int points_x = 10;
            int points_y = 8;
            testObj.x = points_x;
            testObj.y = points_y;
            int expected_x = 4;
            int expected_y = 1;

            int cursor_x = 200;
            int cursor_y = 100;

            // act
            testObj.dots(pixels_x, pixels_y);
            testObj.indexTracker(cursor_x, cursor_y);

            // assert
            Assert.AreEqual(expected_x, testObj.index_x);
            Assert.AreEqual(expected_y, testObj.index_y);
        }

        public void testSquareDetectBelow(int x = 3, int y = 3, int pNum1 = 0, int pNum2 = 1)
        {
            // arrange

            BusinessLogic testObj = new BusinessLogic();
            testObj.x = x;
            testObj.y = y;
            testObj.dots(500, 500);
            testObj.GameLogicArray[pNum1, 1] = pNum1 + 1;
            testObj.GameLogicArray[pNum1, 2] = pNum1 + x;
            testObj.GameLogicArray[pNum1 + 1, 1] = pNum1 + 1 + x;
            testObj.GameLogicArray[pNum1 + x, 1] = pNum1 + 1 + x; 

            // act
            testObj.squareFlag = 0;
            testObj.checkSquareComplete(pNum1, pNum2);

            // assert
            Assert.AreEqual(1, testObj.squareFlag);
        }

        public void testSquareDetectAbove(int x = 3, int y = 3, int pNum1 = 0, int pNum2 = 1)
        {
            // arrange

            BusinessLogic testObj = new BusinessLogic();
            testObj.x = x;
            testObj.y = y;
            testObj.dots(500, 500);
            testObj.GameLogicArray[pNum1, 1] = pNum1 + 1;
            testObj.GameLogicArray[pNum1 - x, 2] = pNum1;
            testObj.GameLogicArray[pNum1 - x + 1, 1] = pNum1 + 1;
            testObj.GameLogicArray[pNum1 - x, 1] = pNum1 - x + 1;

            // act
            testObj.squareFlag = 0;
            testObj.checkSquareComplete(pNum1, pNum2);

            // assert
            Assert.AreEqual(1, testObj.squareFlag);
        }

        public void testSquareDetectLeft(int x = 3, int y = 3, int pNum1 = 0, int pNum2 = 4)
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            testObj.x = x;
            testObj.y = y;
            testObj.dots(500, 500);
            testObj.GameLogicArray[pNum1 - 1, 1] = pNum1;
            testObj.GameLogicArray[pNum1 - 1, 2] = pNum1 + x - 1;
            testObj.GameLogicArray[pNum1 - 1 + x, 2] = pNum1 + x;
            testObj.GameLogicArray[pNum1, 1] = pNum1 + x;

            // act
            testObj.squareFlag = 0;
            testObj.checkSquareComplete(pNum1, pNum2);

            // assert
            Assert.AreEqual(1, testObj.squareFlag);
        }

        [TestMethod]
        public void testSquareDetectBelowBig()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            testObj.x = testObj.y = 5;

            // act
            for (int i = 0; i < testObj.x * testObj.y - testObj.x; i++)
                testSquareDetectBelow(5, 5, i, i + 1);

            // assert
        }

        [TestMethod]
        public void testSquareDetectAboveBig()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            testObj.x = testObj.y = 5;

            //act
            for (int i = testObj.x; i < testObj.x * testObj.y; i++)
                testSquareDetectAbove(5, 5, i, i + 1);

            //assert
        }

        [TestMethod]
        public void testSquareDetectRightBig()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            testObj.x = testObj.y = 5;

            // act
            for (int i = 0; i < testObj.x * testObj.y - testObj.x; i++)
                if ( (i + 1) % testObj.x != 0)
                testSquareDetectBelow(5, 5, i, i + testObj.x);

            // assert
        }

        [TestMethod]
        public void testSquareDetectLeftBig()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            testObj.x = testObj.y = 5;

            //  act
            for (int i = 0; i < testObj.x * testObj.y - testObj.x; i++)
                if (i % testObj.x != 0 || i != 0)
                    testSquareDetectLeft(5, 5, i, i + testObj.x);

            //  assert
        }

        [TestMethod]
        public void testNotSwitchingPlayerAfterSquareIsDetected()
        {
            // arrange
            int playerTest = 1;
            int result1;
            int result2;
            int x = 6;
            int y = 6;
            int pNum1 = 4;
            Point[] line = new Point[2];
            line[0].X = 10;
            line[1].X = 30;
            BusinessLogic testObj = new BusinessLogic();
            testObj.x = x;
            testObj.y = y;
            testObj.dots(500, 500);
           

            // act
            testObj.player = playerTest;
            testObj.checkAfterClick(pNum1);
            result1 = testObj.player;

            testObj.GameLogicArray[pNum1, 1] = 0;
            testObj.GameLogicArray[pNum1, 2] = pNum1 + x;
            testObj.GameLogicArray[pNum1 + 1, 1] = pNum1 + 1 + x;
            testObj.GameLogicArray[pNum1 + x, 1] = pNum1 + 1 + x;

            testObj.player = playerTest;
            testObj.checkAfterClick(pNum1);
            result2 = testObj.player;

            // assert
            Assert.AreNotEqual(playerTest, result1);
            Assert.AreEqual(playerTest, result2);

        }

        [TestMethod]
        public void testPlayerScore()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();          
            int x = 6;
            int y = 6;
            int pNum1 = 4;
            int pNum2 = pNum1 + 1;
            testObj.x = x;
            testObj.y = y;
            testObj.dots(500, 500);
            testObj.GameLogicArray[pNum1, 1] = pNum1 + 1;
            testObj.GameLogicArray[pNum1, 2] = pNum1 + x;
            testObj.GameLogicArray[pNum1 + 1, 1] = pNum1 + 1 + x;
            testObj.GameLogicArray[pNum1 + x, 1] = pNum1 + 1 + x;

            testObj.player1Score = 0;
            testObj.player2Score = 0;
            testObj.player = 1;

            // act
            testObj.checkSquareComplete(pNum1, pNum2);

            // assert
            Assert.AreEqual(1, testObj.player1Score);
            Assert.AreEqual(0, testObj.player2Score);
        }

        [TestMethod]
        public void testDoubleSquareVertical()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            int x = 6;
            int y = 6;
            int pNum1 = 12;
            int pNum2 = pNum1 + 1;
            testObj.x = x;
            testObj.y = y;
            testObj.dots(500, 500);
            // lower square
            testObj.GameLogicArray[pNum1, 2] = pNum1 + x;
            testObj.GameLogicArray[pNum1 + 1, 1] = pNum1 + 1 + x;
            testObj.GameLogicArray[pNum1 + x, 1] = pNum1 + 1 + x;
            // upper square
            testObj.GameLogicArray[pNum1 - x, 1] = pNum1 - x + 1;
            testObj.GameLogicArray[pNum1 - x, 2] = pNum1;
            testObj.GameLogicArray[pNum1 + 1 - x, 1] = pNum1 + 1;

            testObj.player1Score = 0;
            testObj.player2Score = 0;
            testObj.player = 1;
            testObj.line[0].X = 10;
            testObj.line[1].X = 11;

            // act
            testObj.checkAfterClick(pNum1);

            // assert
            Assert.AreEqual(2, testObj.player1Score);
            Assert.AreEqual(0, testObj.player2Score);
            Assert.AreEqual(1, testObj.GameLogicArray[pNum1, 0]);
            Assert.AreEqual(1, testObj.GameLogicArray[pNum1 - x, 0]);
        }

        [TestMethod]
        public void testDoubleSquareHorizontal()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            int x = 6;
            int y = 6;
            int pNum1 = 12;
            int pNum2 = pNum1 + 1;
            testObj.x = x;
            testObj.y = y;
            testObj.dots(500, 500);
            // right square
            testObj.GameLogicArray[pNum1, 2] = pNum1 + x;
            testObj.GameLogicArray[pNum1 + 1, 1] = pNum1 + 1 + x;
            testObj.GameLogicArray[pNum1 + x, 1] = pNum1 + 1 + x;
            // left square
            testObj.GameLogicArray[pNum1 - 1, 1] = pNum1;
            testObj.GameLogicArray[pNum1 - 1, 2] = pNum1 - 1 + x;
            testObj.GameLogicArray[pNum1 - 1 + x, 1] = pNum1 + x;

            testObj.player1Score = 0;
            testObj.player2Score = 0;
            testObj.player = 1;
            testObj.line[0].X = 10;
            testObj.line[1].X = 10;

            // act
            testObj.checkAfterClick(pNum1);

            // assert
            Assert.AreEqual(2, testObj.player1Score);
            Assert.AreEqual(0, testObj.player2Score);
            Assert.AreEqual(1, testObj.GameLogicArray[pNum1, 0]);
            Assert.AreEqual(1, testObj.GameLogicArray[pNum1 - 1, 0]);
        }

        [TestMethod]
        public void testRewriteLine()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            int x = 6;
            int y = 6;
            int pNum1 = 12;
            int pNum2 = pNum1 + 1;
            int expected = 2;
            testObj.x = x;
            testObj.y = y;
            testObj.dots(500, 500);
            testObj.player = 1;
            int playerAfterFirstClick;
            testObj.line[0].X = 10;
            testObj.line[1].X = 10;

            // act
            testObj.checkAfterClick(pNum1);
            Assert.AreEqual(1, testObj.GameLogicArray[pNum1, 3]);
            playerAfterFirstClick = testObj.player;
            testObj.checkAfterClick(pNum1);
            Assert.AreEqual(1, testObj.GameLogicArray[pNum1, 3]);

            // assert
            Assert.AreEqual(expected, playerAfterFirstClick);
            Assert.AreEqual(expected, testObj.player);
        }

        [TestMethod]
        public void testDotsCheckCenter()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            int pixels_x = 400;
            int pixels_y = 400;
            int points_x = 10;
            int points_y = 8;
            testObj.x = points_x;
            testObj.y = points_y;
            Point expectedStart = new Point(180, 75);
            Point expectedEnd = new Point(180, 125);

            int cursor_x = 200;
            int cursor_y = 100;

            // act
            testObj.dots(pixels_x, pixels_y);
            testObj.indexTracker(cursor_x, cursor_y);
            testObj.dotsCheck(testObj.index_x, testObj.index_y, cursor_x, cursor_y);

            // assert
            Assert.AreEqual(expectedStart, testObj.line[0]);
            Assert.AreEqual(expectedEnd, testObj.line[1]);
        }

        [TestMethod]
        public void testDotsCheckLeft()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            int pixels_x = 400;
            int pixels_y = 400;
            int points_x = 10;
            int points_y = 8;
            testObj.x = points_x;
            testObj.y = points_y;
            Point expectedStart = new Point(180, 75);
            Point expectedEnd = new Point(180, 125);

            int cursor_x = 180;
            int cursor_y = 100;

            // act
            testObj.dots(pixels_x, pixels_y);
            testObj.indexTracker(cursor_x, cursor_y);
            testObj.dotsCheck(testObj.index_x, testObj.index_y, cursor_x, cursor_y);

            // assert
            Assert.AreEqual(expectedStart, testObj.line[0]);
            Assert.AreEqual(expectedEnd, testObj.line[1]);
        }

        [TestMethod]
        public void testDotsCheckUpper()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            int pixels_x = 400;
            int pixels_y = 400;
            int points_x = 10;
            int points_y = 8;
            testObj.x = points_x;
            testObj.y = points_y;
            Point expectedStart = new Point(180, 75);
            Point expectedEnd = new Point(220, 75);

            int cursor_x = 200;
            int cursor_y = 75;

            // act
            testObj.dots(pixels_x, pixels_y);
            testObj.indexTracker(cursor_x, cursor_y);
            testObj.dotsCheck(testObj.index_x, testObj.index_y, cursor_x, cursor_y);

            // assert
            Assert.AreEqual(expectedStart, testObj.line[0]);
            Assert.AreEqual(expectedEnd, testObj.line[1]);
        }

        [TestMethod]
        public void testDotsCheckLower()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            int pixels_x = 400;
            int pixels_y = 400;
            int points_x = 10;
            int points_y = 8;
            testObj.x = points_x;
            testObj.y = points_y;
            Point expectedStart = new Point(180, 125);
            Point expectedEnd = new Point(220, 125);

            int cursor_x = 200;
            int cursor_y = 125;

            // act
            testObj.dots(pixels_x, pixels_y);
            testObj.indexTracker(cursor_x, cursor_y);
            testObj.dotsCheck(testObj.index_x, testObj.index_y, cursor_x, cursor_y);

            // assert
            Assert.AreEqual(expectedStart, testObj.line[0]);
            Assert.AreEqual(expectedEnd, testObj.line[1]);
        }

        [TestMethod]
        public void testDotsCheckRight()
        {
            // arrange
            BusinessLogic testObj = new BusinessLogic();
            int pixels_x = 400;
            int pixels_y = 400;
            int points_x = 10;
            int points_y = 8;
            testObj.x = points_x;
            testObj.y = points_y;
            Point expectedStart = new Point(220, 75);
            Point expectedEnd = new Point(220, 125);

            int cursor_x = 210;
            int cursor_y = 100;

            // act
            testObj.dots(pixels_x, pixels_y);
            testObj.indexTracker(cursor_x, cursor_y);
            testObj.dotsCheck(testObj.index_x, testObj.index_y, cursor_x, cursor_y);

            // assert
            Assert.AreEqual(expectedStart, testObj.line[0]);
            Assert.AreEqual(expectedEnd, testObj.line[1]);
        }


        [TestMethod]
        public void testRecordSegmentation()
        {
            // arrange
            string path = "test.txt";
            ScoreBoard board = new ScoreBoard(path);
            string expected = "Test 5x5 5 55";
            int b, c, d;
            string a;
            // act
            board.segmentRecordLine(expected, out a, out b, out c, out d);

            // assert
            Assert.AreEqual(expected, a + " " + (b/5).ToString() + "x" + (b / 5).ToString() + " " + c.ToString() + " " + d.ToString());
        }

        [TestMethod]
        public void testFileSort()
        {
            // arrange
            string path = "test.txt";
            string path2 = "test2.txt";
            ScoreBoard board = new ScoreBoard(path);
            string expected = "Test 5x5 5 55";
            List<string> text, text2;

            // act
            text2 = File.ReadAllLines(path2).ToList();
            File.WriteAllLines(path, text2);
            text2 = File.ReadAllLines(path).ToList();

            board.ScoreSort();
            text = File.ReadAllLines(path).ToList();

            // assert
            Assert.AreEqual(expected, text[4]);
            Assert.AreEqual(expected, text2[7]);
        }

        [TestMethod]
        public void testFileAdd()
        {
            // arrange 
            BusinessLogic logic = new BusinessLogic();
            logic.x = logic.y = 3;
            logic.player1GamesWon = 4;
            logic.player1TotalScore = 36;
            string name = "Test";

            // act


            // assert
        }
    }
}