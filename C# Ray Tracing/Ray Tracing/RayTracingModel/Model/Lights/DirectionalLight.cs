﻿using System.Drawing;

namespace RayTracingModel.Model.Lights
{
    class DirectionalLight : ILight
    {
        public double Intensity { get; set; }
        public Color Color { get; set; }
        private Vector3D _direction;
        public Vector3D CalculateLightDirectionOnPosition(Vector3D positionVector3D)
        {
            return _direction;
        }

        public double DistanceFromLight(Vector3D positionVector3D)
        {
            return 1;
        }

        public DirectionalLight(Vector3D direction, double intensity, Color color)
        {
            _direction = direction.Normalize();
            Intensity = intensity;
            Color = color;
        }

        public ILight Clone()
        {
            return new DirectionalLight(_direction, Intensity, Color);
        }
    }
}
