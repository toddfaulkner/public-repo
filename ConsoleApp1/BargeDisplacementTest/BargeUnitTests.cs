using BargeDisplacement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

/// <summary>
/// 
/// </summary>
namespace BargeDisplacementTest
{
    [TestClass]
    public class BargeUnitTests
    {
        [TestMethod]
        public void CalculateDisplacementTest()
        {
            Barge barge = new Barge(75, 7, 4);

            Assert.AreEqual(15709, Math.Round(barge.LengthInFeet * barge.WidthInFeet * barge.DraftInFeet * Barge.GAL_PER_FT3), "Displacement calulation did not equal expected value.");
        }
    }
}
