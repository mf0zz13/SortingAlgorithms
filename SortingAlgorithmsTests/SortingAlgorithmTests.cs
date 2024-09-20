using SortingAlgoithms;

namespace SortingAlgoithmTests
{
    [TestClass]
    public class SelectionSort
    {
        [TestMethod]
        public void SelectionSort_EmptyArray()
        {
            //Arrange
            int[] array = new int[0];
            int[] arrayControl = new int[0];

            //Act
            Program.SelectionSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void SelectionSort_TestCaseOne()
        {
            //Arrange
            int[] array = new int[1] { 0 };
            int[] arrayControl = new int[1] { 0 };

            //Act
            Program.SelectionSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void SelectionSort_TestCaseTwo()
        {
            //Arrange
            int[] array = new int[5] { 5, 5, 3, 2, 1 };
            int[] arrayControl = new int[5] { 1, 2, 3, 5, 5 };

            //Act
            Program.SelectionSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void SelectionSort_TestCaseThree()
        {
            //Arrange
            int[] array = new int[5] { 3, 5, 1, 2, 4 };
            int[] arrayControl = new int[5] { 1, 2, 3, 4, 5 };

            //Act
            Program.SelectionSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }
    }

    [TestClass]
    public class BubbleSort
    {
        [TestMethod]
        public void BubbleSort_EmptyArray()
        {
            //Arrange
            int[] array = new int[0];
            int[] arrayControl = new int[0];

            //Act
            Program.BubbleSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void BubbleSort_TestCaseOne()
        {
            //Arrange
            int[] array = new int[1] { 0 };
            int[] arrayControl = new int[1] { 0 };

            //Act
            Program.BubbleSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void BubbleSort_TestCaseTwo()
        {
            //Arrange
            int[] array = new int[5] { 5, 4, 3, 2, 1 };
            int[] arrayControl = new int[5] { 1, 2, 3, 4, 5 };

            //Act
            Program.BubbleSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void BubbleSort_TestCaseThree()
        {
            //Arrange
            int[] array = new int[5] { 3, 5, 5, 2, 4 };
            int[] arrayControl = new int[5] { 2, 3, 4, 5, 5 };

            //Act
            Program.BubbleSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }
    }

    [TestClass]
    public class InsertionSort
    {
        [TestMethod]
        public void InsertionSort_EmptyArray()
        {
            //Arrange
            int[] array = new int[0];
            int[] arrayControl = new int[0];

            //Act
            Program.InsertionSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void InsertionSort_TestCaseOne()
        {
            //Arrange
            int[] array = new int[1] { 0 };
            int[] arrayControl = new int[1] { 0 };

            //Act
            Program.InsertionSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void InsertionSort_TestCaseTwo()
        {
            //Arrange
            int[] array = new int[5] { 5, 4, 3, 2, 1 };
            int[] arrayControl = new int[5] { 1, 2, 3, 4, 5 };

            //Act
            Program.InsertionSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void InsertionSort_TestCaseThree()
        {
            //Arrange
            int[] array = new int[5] { 3, 5, 1, 2, 4 };
            int[] arrayControl = new int[5] { 1, 2, 3, 4, 5 };

            //Act
            Program.InsertionSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }
    }

    [TestClass]
    public class MergeSort
    {
        [TestMethod]
        public void MergeSort_EmptyArray()
        {
            //Arrange
            int[] array = new int[0];
            int[] arrayControl = new int[0];

            //Act
            Program.MergeSort_Divide(array, 0, array.Length -1);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void MergeSort_TestCaseOne()
        {
            //Arrange
            int[] array = new int[1] { 0 };
            int[] arrayControl = new int[1] { 0 };

            //Act
            Program.MergeSort_Divide(array, 0, array.Length - 1);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void MergeSort_TestCaseTwo()
        {
            //Arrange
            int[] array = new int[5] { 5, 5, 3, 2, 1 };
            int[] arrayControl = new int[5] { 1, 2, 3, 5, 5 };

            //Act
            Program.MergeSort_Divide(array, 0, array.Length - 1);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }

        [TestMethod]
        public void MergeSort_TestCaseThree()
        {
            //Arrange
            int[] array = new int[5] { 3, 5, 1, 2, 4 };
            int[] arrayControl = new int[5] { 1, 2, 3, 4, 5 };

            //Act
            Program.MergeSort_Divide(array, 0, array.Length - 1);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }
    }
}

