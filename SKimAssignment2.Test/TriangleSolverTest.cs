using System.Collections.Generic;
using NUnit.Framework;

namespace SKimAssignment2.Test
{
    [TestFixture]
    public class TriangleSolverTest
    {

        List<int> sides;

        string GuessingNoTriangle = "The sides isn't form a triangle! Please choose the right one";
        string GuessingTheTriangleEquilateral = "The sides form = equilateral triangle!";
        string GuessingTheTriangleIsosceles = "The sides form = isosceles triangle!";
        string GuessingTheTriangleScalene = "The sides form = scalene triangle!";

        [Test]
        public void Guessing_Given1And2And3_IsNotTriangle()
        {
            sides = new List<int> { 1, 2, 3 };
            StringAssert.AreEqualIgnoringCase
            (GuessingNoTriangle, TriangleSolver.Analyze(ref sides));

        }
        [Test]
        public void Guessing_Given2And2And2_EquilateralTriangle()
        {
            sides = new List<int> { 2, 2, 2 };
            StringAssert.AreEqualIgnoringCase
            (GuessingTheTriangleEquilateral, TriangleSolver.Analyze(ref sides));

        }
        [Test]
        public void Guessing_Given5And5And5_EquilateralTriangle()
        {
            sides = new List<int> { 5, 5, 5 };
            StringAssert.AreEqualIgnoringCase
            (GuessingTheTriangleEquilateral, TriangleSolver.Analyze(ref sides));

        }
        [Test]
        public void Guessing_Given2And3And3_IsosceleTriangle()
        {
            sides = new List<int> { 2, 3, 3 };
            StringAssert.AreEqualIgnoringCase
            (GuessingTheTriangleIsosceles, TriangleSolver.Analyze(ref sides));

        }
        [Test]
        public void Guessing_Given2And3And4_IsNotTriangle()
        {
            sides = new List<int> { 2, 3, 4 };
            StringAssert.AreEqualIgnoringCase
            (GuessingTheTriangleScalene, TriangleSolver.Analyze(ref sides));

        }
        [Test]
        public void Guessing_Given4And6And8_IsNotTriangle()
        {
            sides = new List<int> { 4, 6, 8 };
            StringAssert.AreEqualIgnoringCase
            (GuessingTheTriangleScalene, TriangleSolver.Analyze(ref sides));

        }
    }
}
