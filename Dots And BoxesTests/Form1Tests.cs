using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dots_And_Boxes__TRPO_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Dots_And_Boxes__TRPO_.Tests
{
    [TestClass()]
    public class Form1Tests
    {

        [TestMethod]
        public void PixelDistance()
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
        public void convertPixelSize()
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

       // [TestMethod]
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

    }
}