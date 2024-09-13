using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Program main = new Program();

        [TestMethod()]
        public void Task_1_1Test()
        {
            // Arrange
            int test;
            int answer = 222;
            // Act
            test = main.Task_1_1();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_2Test()
        {
            // Arrange
            double test;
            double answer = 2.93;
            // Act
            test = main.Task_1_2();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_3Test()
        {
            // Arrange
            double test;
            double answer = 54;
            // Act
            test = main.Task_1_3();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_4Test()
        {
            // Arrange
            double test1 = 0.5;
            double answer1 = -243.15;
            double test2 = 0.9;
            double answer2 = 1.36;
            double test3 = 0;
            double answer3 = 0;
            // Act
            test1 = main.Task_1_4(test1);
            test2 = main.Task_1_4(test2);
            test3 = main.Task_1_4(test3);
            // Assert
            Assert.AreEqual(answer1, test1);
            Assert.AreEqual(answer2, test2);
            Assert.AreEqual(answer3, test3);
        }

        [TestMethod()]
        public void Task_1_5Test()
        {
            // Arrange
            double test1p = 0.5;
            double test1h = 2;
            double answer1 = 1232.5;
            double test2p = 2;
            double test2h = 0.5;
            double answer2 = 201.25;
            double test3p = 2;
            double test3h = 0;
            double answer3 = 40;
            double test4p = 0;
            double test4h = 2;
            double answer4 = 1140;
            // Act
            double test1 = main.Task_1_5(test1p, test1h);
            double test2 = main.Task_1_5(test2p, test2h);
            double test3 = main.Task_1_5(test3p, test3h);
            double test4 = main.Task_1_5(test4p, test4h);
            // Assert
            Assert.AreEqual(answer1, test1);
            Assert.AreEqual(answer2, test2);
            Assert.AreEqual(answer3, test3);
            Assert.AreEqual(answer4, test4);
        }
        [TestMethod()]
        public void Task_1_6Test()
        {
            double[] test = new double[17]; int counter = 0;
            double[] answer = new double[17] { 36, 30.62, 25.5, 20.62, 16, 11.62, 7.5, 3.62, 0, -3.38, -6.5, -9.38, -12, -14.38, -16.5, -18.38, -20 };
            // Act
            for (double i = -4; i <= 4; i += 0.5, counter++)
                test[counter] = main.Task_1_6(i);
            // Assert
            for (int i = 0; i < test.Length; i++)
                Assert.AreEqual(answer[i], test[i]);
        }

        [TestMethod()]
        public void Task_1_7Test()
        {
            // Arrange
            int test;
            int answer = 720;
            // Act
            test = main.Task_1_7();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_8Test()
        {
            // Arrange
            int test;
            int answer = 873;
            // Act
            test = main.Task_1_8();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_9Test()
        {
            // Arrange
            double test;
            double answer = 8.37;
            // Act
            test = main.Task_1_9();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_10Test()
        {
            int test;
            int answer = 2187;
            // Act
            test = main.Task_1_10();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_11Test()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Task_1_12Test()
        {
            // Arrange
            double test1 = 1.35;
            double answer1 = 3.72;
            double test2 = 0.9;
            double answer2 = 19.68;
            double test3 = 0;
            double answer3 = 0;
            // Act
            test1 = main.Task_1_12(test1);
            test2 = main.Task_1_12(test2);
            test3 = main.Task_1_12(test3);
            // Assert
            Assert.AreEqual(answer1, test1);
            Assert.AreEqual(answer2, test2);
            Assert.AreEqual(answer3, test3);
        }

        [TestMethod()]
        public void Task_1_13Test()
        {
            // Arrange
            double[] test = new double[31] { -1.5, -1.4, -1.3, -1.2, -1.1, -1.0, -0.9, -0.8, -0.7, -0.6, -0.5, -0.4, -0.3, -0.2, -0.1, 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.3, 1.4, 1.5 };
            double[] answer = new double[31] { 1, 1, 1, 1, 1, 1, 0.9, 0.8, 0.7, 0.6, 0.5, 0.4, 0.3, 0.2, 0.1, 0, -0.1, -0.2, -0.3, -0.4, -0.5, -0.6, -0.7, -0.8, -0.9, -1, -1, -1, -1, -1, -1 };
            // Act
            for (int i = 0; i < test.Length; i++)
                test[i] = main.Task_1_13(test[i]);
            // Assert
            for (int i = 0; i < test.Length; i++)
                Assert.AreEqual(answer[i], test[i]);
        }

        [TestMethod()]
        public void Task_1_14Test()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Task_1_15Test()
        {
            // Arrange
            double test;
            double answer = 1.6;
            // Act
            test = main.Task_1_15();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_16Test()
        {
            // Arrange
            (double, int) test;
            double answer = 1.23;
            double power = 18;
            // Act
            test = main.Task_1_16();
            // Assert
            Assert.AreEqual(answer, test.Item1);
            Assert.AreEqual(power, test.Item2);
        }

        [TestMethod()]
        public void Task_1_17Test()
        {
            // Arrange
            double[] test = new double[10] { 1, 2, 3, 4, 5, 10, 50, 100, 250, 1000 };
            double[] answer = new double[10] { 112.7, 159.39, 195.22, 225.42, 252.04, 356.51, 798.44, 1131.37, 1799.31, 3701.35 };
            // Act
            for (int i = 0; i < test.Length; i++)
                test[i] = main.Task_1_17(test[i]);
            // Assert
            for (int i = 0; i < test.Length; i++)
                Assert.AreEqual(answer[i], test[i], 0.02);
        }

        [TestMethod()]
        public void Task_1_18Test()
        {
            // Arrange
            int[] test = new int[8] { 3, 6, 9, 12, 15, 18, 21, 24 };
            int[] answer = new int[8] { 20, 40, 80, 160, 320, 640, 1280, 2560 };
            // Act
            for (int i = 0; i < test.Length; i++)
                test[i] = main.Task_1_18(test[i]);
            // Assert
            for (int i = 0; i < test.Length; i++)
                Assert.AreEqual(answer[i], test[i]);
        }

        [TestMethod()]
        public void Task_2_2Test()
        {
            int test;
            int answer = 13;
            // Act
            test = main.Task_2_2();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_2_4Test()
        {
            // Arrange
            double test1 = 1;
            double answer1 = 0;
            double test2 = 0.8;
            double answer2 = 2.78;
            double test3 = -0.35;
            double answer3 = 1.14;
            double test4 = 0;
            double answer4 = 1;
            // Act
            test1 = main.Task_2_4(test1);
            test2 = main.Task_2_4(test2);
            test3 = main.Task_2_4(test3);
            test4 = main.Task_2_4(test4);
            // Assert
            Assert.AreEqual(answer1, test1);
            Assert.AreEqual(answer2, test2);
            Assert.AreEqual(answer3, test3);
            Assert.AreEqual(answer4, test4);
        }

        [TestMethod()]
        public void Task_2_6Test()
        {
            // Arrange
            int test;
            int answer = 42;
            // Act
            test = main.Task_2_6();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_2_8Test()
        {
            // Arrange
            int test;
            int answer = 10;
            // Act
            test = main.Task_2_8();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_2_10Test()
        {
            // Arrange
            int test;
            int answer = 10;
            // Act
            test = main.Task_2_10();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_3_8Test()
        {
            // Arrange
            double[] x = new double[19] { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95, 1 };
            double[,] test = new double[2, 19];
            double[] answer = new double[19] { 1.22, 1.35, 1.49, 1.65, 1.82, 2.01, 2.23, 2.46, 2.72, 3.00, 3.32, 3.67, 4.06, 4.48, 4.95, 5.47, 6.05, 6.69, 7.39 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_8(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.AreEqual(answer[i], test[0, i]);
                Assert.AreEqual(answer[i], test[1, i]);
            }
        }
    }
}
