using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Library;
using System.Collections;

namespace Task1.Tests
{
    [TestClass]
    public class IntMatrixSorterTest
    {
        [TestMethod]
        public void SortRows_BySumOfRowElementsAscending_ReturnsSortedArray()
        {
            int[][] array = { new int[]{ 1, 3, 5 }, new int[]{ 1, 3, 4 }, new int[]{ 1, 3, 6 } };

            IStructuralEquatable expected = new int[][]{array[1], array[0], array[2]};
            IntMatrixSorter.SortRows(array, new SortBySumAscendingHelper());

            Assert.IsTrue(expected.Equals(array, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void SortRows_ByMaxMagnitudeElementAscending_ReturnsSortedArray()
        {
            int[][] array = { new int[] { 1, 3, 5 }, new int[] { 1, -3, 4 }, new int[] { 1, 3, -6 } };

            IStructuralEquatable expected = new int[][] { array[1], array[0], array[2] };
            IntMatrixSorter.SortRows(array, new SortByMaxMagnitudeAscendingHelper());

            Assert.IsTrue(expected.Equals(array, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void SortRows_BySumDescending_ReturnsSortedArray()
        {
            int[][] array = { new int[] { 1, 3, 5 }, new int[] { 1, 3, 4 }, new int[] { 1, 3, 6 } };

            IStructuralEquatable expected = new int[][] { array[2], array[0], array[1] };
            IntMatrixSorter.SortRows(array, new SortBySumDescendingHelper());

            Assert.IsTrue(expected.Equals(array, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void SortRows_ByMaxMagnitudeDescending_ReturnsSortedArray()
        {
            int[][] array = { new int[] { 1, 3, 5 }, new int[] { 1, -3, 4 }, new int[] { 1, 3, -6 } };

            IStructuralEquatable expected = new int[][] { array[2], array[0], array[1] };
            IntMatrixSorter.SortRows(array, new SortByMaxMagnitudeDescendingHelper());

            Assert.IsTrue(expected.Equals(array, StructuralComparisons.StructuralEqualityComparer));
        }
    }
}
