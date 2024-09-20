using SortingAlgoithms;

namespace SortingAlgoithmTest
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
            int[] array = new int[5] { 5, 4, 3, 2, 1 };
            int[] arrayControl = new int[5] { 1, 2, 3, 4, 5 };

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
}
