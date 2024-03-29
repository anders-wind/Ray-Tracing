﻿using System;
using System.Collections.Generic;
using System.Drawing;
using RayTracingModel.Model.Lights;

namespace RayTracingModel.Model.Shaders
{
    public class FlatShader : IShader
    {
        public Color BaseColor { get; set; }

        public FlatShader(Color baseColor, double reflectivity, double refractivity, double refractionIndex)
        {
            BaseColor = baseColor;
            Reflectivity = reflectivity;
            Refractivity = refractivity;
            RefractionIndex = refractionIndex;
            CheckInvariants();
        }

        private void CheckInvariants()
        {
            if (Reflectivity < 0 || Reflectivity < 0) throw new Exception("Neither reflectivity or refractivity must be beneath 0");
            if (Reflectivity > 1 || Reflectivity > 1) throw new Exception("Neither reflectivity or refractivity must be over 1");
        }

        public double Reflectivity { get; set; }
        public double Refractivity { get; set; }
        public bool IsReflective()
        {
            if (Reflectivity > 0) return true;
            return false;
        }

        public bool IsRefractive()
        {
            if (Refractivity > 0) return true;
            return false;
        }

        public double RefractionIndex { get; set; }

        public Color CalculateColor(IList<ILight> lightsThatHitsSurface, Vector3D normalVector3D, Vector3D rayVector3D, Vector3D collisionPositionVector3D)
        {
            return BaseColor;
        }
    }
}
