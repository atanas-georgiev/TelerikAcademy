// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Circle.cs" company="">
//   
// </copyright>
// <summary>
//   The circle.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Surfaces
{
    using System;
    using System.Windows.Media.Media3D;

    /// <summary>
    /// The circle.
    /// </summary>
    public sealed class Circle : Surface
    {
        /// <summary>
        /// The radius property.
        /// </summary>
        private static readonly PropertyHolder<double, Circle> RadiusProperty =
            new PropertyHolder<double, Circle>("Radius", 1.0, OnGeometryChanged);

        /// <summary>
        /// The position property.
        /// </summary>
        private static readonly PropertyHolder<Point3D, Circle> PositionProperty =
            new PropertyHolder<Point3D, Circle>("Position", new Point3D(0, 0, 0), OnGeometryChanged);

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
        /// The point for angle.
        /// </summary>
        /// <param name="angle">
        /// The angle.
        /// </param>
        /// <returns>
        /// The <see cref="Point3D"/>.
        /// </returns>
        private Point3D PointForAngle(double angle)
        {
            return new Point3D(
                this._position.X + this._radius * Math.Cos(angle), 
                this._position.Y + this._radius * Math.Sin(angle), 
                this._position.Z);
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

            var mesh = new MeshGeometry3D();
            var prevPoint = this.PointForAngle(0);
            var normal = new Vector3D(0, 0, 1);

            const int div = 180;
            for (var i = 1; i <= div; ++i)
            {
                var angle = 2 * Math.PI / div * i;
                var newPoint = this.PointForAngle(angle);
                mesh.Positions.Add(prevPoint);
                mesh.Positions.Add(this._position);
                mesh.Positions.Add(newPoint);
                mesh.Normals.Add(normal);
                mesh.Normals.Add(normal);
                mesh.Normals.Add(normal);
                prevPoint = newPoint;
            }

            mesh.Freeze();
            return mesh;
        }
    }
}