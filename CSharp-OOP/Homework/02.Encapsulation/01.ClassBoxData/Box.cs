using System;
using System.Text;
using _01.ClassBoxData.Common;
using static System.String;

namespace _01.ClassBoxData
{
    public class Box
    {
        private const int Min_Box_Side = 0;
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get
            {
                return Length = length;
            }

            private set
            {
                ValidateState(value, nameof(Length));
                length = value;
            }
        }
        public double Width
        {
            get
            {
                return Width = width;
            }

            private set
            {
                ValidateState(value, nameof(Width));
                width = value;
            }
        }
        public double Height
        {
            get
            {
                return Height = height;
            }

            private set
            {
                ValidateState(value, nameof(Height));
                height = value;
            }
        }
        public double CalculateSurfaceArea()
        {
            var surfaceArea =
                (2 * length * width) + (2 * height * Length) + (2 * width * height);
            return surfaceArea;
        }
        public double CalculateLateralSurfaceArea()
        {
            var lateralSurfaceArea = 2 * Length * Height + 2 * Width * Height;

            return lateralSurfaceArea;
        }

        public double CalculateVolume()
        {
            var volume = length * height * width;
            return volume;
        }
        private void ValidateState(double value, string type)
        {
            if (value <= Min_Box_Side)
            {
                throw new ArgumentException
               (Format(GlobalConstants.ExceptionInvalidParameters, type));
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Surface Area - {CalculateSurfaceArea():F2}");
            sb.AppendLine($"Lateral Surface Area - {CalculateLateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {CalculateVolume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
