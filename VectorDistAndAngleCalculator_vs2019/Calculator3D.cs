﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDistAndAngleCalculator_vs2019
{
    static class Calculator3D
    {
        public static double GetDist2Points(Point p1, Point p2)
        {
            return Math.Sqrt(
                    Math.Pow(p1.X - p2.X, 2) +
                    Math.Pow(p1.Y - p2.Y, 2) +
                    Math.Pow(p1.Z - p2.Z, 2)
                    );
        }

        public static (double alpha, double beta, double gamma) GetDirectionCosines(Point p1, Point p2)
        {
            double dist = GetDist2Points(p1, p2);

            // Direction cosines equation
            double alpha = Math.Acos((p2.X - p1.X) / dist) * (180.0 / Math.PI);
            double beta = Math.Acos((p2.Y - p1.Y) / dist) * (180.0 / Math.PI);
            double gamma = Math.Acos((p2.Z - p1.Z) / dist) * (180.0 / Math.PI);

            return (alpha, beta, gamma);
        }
        public static (double alpha, double beta, double gamma) GetAnglesWithProjection(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double dz = p2.Z - p1.Z;

            // Project and get angles
            double alpha = Math.Atan2(dx, dy) * 180 / Math.PI;
            double beta = 90 - alpha;
            double gamma = Math.Atan2(dy, dz) * 180 / Math.PI;


            return (alpha, beta, gamma);
        }

        public static (double alpha, double beta, double gamma) GetAnglesWithObjectingLine(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double dz = p2.Z - p1.Z;

            double magnitude = Math.Sqrt(dx * dx + dy * dy + dz * dz);

            double alpha = Math.Acos(dx / magnitude) * (180.0 / Math.PI);
            double beta = Math.Acos(dy / magnitude) * (180.0 / Math.PI); 
            double gamma = Math.Acos(dz / magnitude) * (180.0 / Math.PI);

            return (alpha, beta, gamma);
        }

    }
}
