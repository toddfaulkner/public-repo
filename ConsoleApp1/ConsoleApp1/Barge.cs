using System;

namespace BargeDisplacement
{
    /// <summary>
    /// Barge class current holds information for length, width and draft of barge
    ///     and method to determine displacement
    /// This extensible to include additional barge parameter
    /// If this concept were to be expanded, a parent Boat class could be created
    ///     to contain other boat types/classes
    /// </summary>
    public class Barge
    {
        /// <summary>
        /// Length, Width and Draft (all in feet) need to be set to call CalculateDisplacement()
        /// </summary>
        public double LengthInFeet { get; set; }
        public double WidthInFeet  { get; set; }
        public double DraftInFeet  { get; set; }

        public const double GAL_PER_FT3 = 7.48052;

        public Barge(double lengthInFeet, double widthInFeet, double draftInFeet)
        {
            LengthInFeet = lengthInFeet;
            WidthInFeet =  widthInFeet;
            DraftInFeet =  draftInFeet;
        }

        /// <summary>
        /// Determine gallons of water displaced by barge
        ///      given length (ft.), width (ft.) and draft (ft.) of barge in instance
        ///      volume in cubic feet is determined and converted to gallons
        /// CAD data, 3D scan or Simpsons formula will need to be used if not perfect box 
        /// Assumptions:
        ///      hull      = perfect box (hyperrectangle)
        ///      aft draft = forward draft
        ///      volume    = US gallons
        /// </summary>
        /// <returns>Displacement of barge in gallons</returns>
        public double CalculateDisplacement()
        {
            return LengthInFeet * WidthInFeet * DraftInFeet * GAL_PER_FT3;
        }
    }
}