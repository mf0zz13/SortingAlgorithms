using SortingAlgoithms;

namespace SortingAlgoithmTest
{
    [TestClass]
    public class SortingAlgorithmTests
    {
        [TestMethod]
        public void SelectionSort_EmptyArray()
        {
            //Arrange
            int[] array = new int[5] { 5, 4, 3, 2, 1 };
            int[] arrayControl = new int[5] { 1, 2, 3, 4, 5 };

            //Act
            Program.SelectionSort(array);

            //Assert
            CollectionAssert.AreEqual(array, arrayControl);
        }
    }
}
