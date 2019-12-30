﻿using UnityEngine;
using c = HighPrecisionStepperJuggler.Constants;

namespace HighPrecisionStepperJuggler
{
    public static class MiscMath
    {
        /// <summary>
        /// Returns the tilt given the heights of two opposing joints of the plate
        /// </summary>
        public static float TiltFromOpposingPositions(Vector3 position1, Vector3 position2)
        {
            var h = c.PlateWidth / 2f;
            var o = (position1.y - position2.y) / 2f;
            return Mathf.Asin(o / h);
        }

        public static float HeightDifferenceFromTilt(float tilt)
        {
            // TODO: clean up differences in units (IK-unit vs unity-units)
            var h = c.PlateWidth * 0.1f;
            var o = Mathf.Sin(tilt) * h;
            return o;
        }

        /*public static float WidthCorrectionFromTilt(float tilt)
        {
            
        }
        */
    }
}
