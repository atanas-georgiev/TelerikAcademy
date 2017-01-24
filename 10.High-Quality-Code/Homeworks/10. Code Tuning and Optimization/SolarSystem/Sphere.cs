// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sphere.cs" company="">
//   
// </copyright>
// <summary>
//   The sphere.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Surfaces
{
    using System;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Media3D;

    /// <summary>
    /// The sphere.
    /// </summary>
    public sealed class Sphere : Surface
    {
        /// <summary>
        /// The radius property.
        /// </summary>
        private static readonly PropertyHolder<double, Sphere> RadiusProperty =
            new PropertyHolder<double, Sphere>("Radius", 1.0, OnGeometryChanged);

        /// <summary>
        /// The position property.
        /// </summary>
        private static readonly PropertyHolder<Point3D, Sphere> PositionProperty =
            new PropertyHolder<Point3D, Sphere>("Position", new Point3D(0, 0, 0), OnGeometryChanged);

        /// <summary>
        /// The _position.
        /// </summary>
        private Point3D _position;

        /// <summary>
        /// The _radius.
        /// </summary>
        private double _radius;

        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        public double Radius
        {
            get
            {
                return RadiusProperty.Get(this);
            }

            set
            {
                RadiusProperty.Set(this, value);
            }
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        public Point3D Position
        {
            get
            {
                return PositionProperty.Get(this);
            }

            set
            {
                PositionProperty.Set(this, value);
            }
        }

        /// <summary>
        /// The get position.
        /// </summary>
        /// <param name="angle">
        /// The angle.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <returns>
        /// The <see cref="Point3D"/>.
        /// </returns>
        private Point3D GetPosition(double angle, double y)
        {
            var r = this._radius * Math.Sqrt(1 - y * y);
            var x = r * Math.Cos(angle);
            var z = r * Math.Sin(angle);

            return new Point3D(this._position.X + x, this._position.Y + this._radius * y, this._position.Z + z);
        }

        /// <summary>
        /// The get normal.
        /// </summary>
        /// <param name="angle">
        /// The angle.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <returns>
        /// The <see cref="Vector3D"/>.
        /// </returns>
        private Vector3D GetNormal(double angle, double y)
        {
            return (Vector3D)this.GetPosition(angle, y);
        }

        /// <summary>
        /// The get texture coordinate.
        /// </summary>
        /// <param name="angle">
        /// The angle.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        private Point GetTextureCoordinate(double angle, double y)
        {
            var map = new Matrix();
            map.Scale(1 / (2 * Math.PI), -0.5);

            var p = new Point(angle, y);
            p = p * map;

            return p;
        }

        /// <summary>
        /// The create mesh.
        /// </summary>
        /// <returns>
        /// The <see cref="Geometry3D"/>.
        /// </returns>
        protected override Geometry3D CreateMesh()
        {
            this._radius = this.Radius;
            this._position = this.Position;

            const int angleSteps = 32;
            const double minAngle = 0;
            const double maxAngle = 2 * Math.PI;
            const double dAngle = (maxAngle - minAngle) / angleSteps;

            const int ySteps = 32;
            const double minY = -1.0;
            const double maxY = 1.0;
            const double dy = (maxY - minY) / ySteps;

            var mesh = new MeshGeometry3D();

            for (var yi = 0; yi <= ySteps; yi++)
            {
                var y = minY + yi * dy;

                for (var ai = 0; ai <= angleSteps; ai++)
                {
                    var angle = ai * dAngle;

                    mesh.Positions.Add(this.GetPosition(angle, y));
                    mesh.Normals.Add(this.GetNormal(angle, y));
                    mesh.TextureCoordinates.Add(this.GetTextureCoordinate(angle, y));
                }
            }

            for (var yi = 0; yi < ySteps; yi++)
            {
                for (var ai = 0; ai < angleSteps; ai++)
                {
                    var a1 = ai;
                    var a2 = ai + 1;
                    var y1 = yi * (angleSteps + 1);
                    var y2 = (yi + 1) * (angleSteps + 1);

                    mesh.TriangleIndices.Add(y1 + a1);
                    mesh.TriangleIndices.Add(y2 + a1);
                    mesh.TriangleIndices.Add(y1 + a2);

                    mesh.TriangleIndices.Add(y1 + a2);
                    mesh.TriangleIndices.Add(y2 + a1);
                    mesh.TriangleIndices.Add(y2 + a2);
                }
            }

            mesh.Freeze();
            return mesh;
        }
    }
}