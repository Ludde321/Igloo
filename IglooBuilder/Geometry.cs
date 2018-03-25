using System;
using System.Collections.Generic;
using Common;

namespace IglooBuilder
{
    public class Geometry
    {
        public readonly List<Triangle> Triangles = new List<Triangle>();
        public readonly List<Vector3d> Vertexes = new List<Vector3d>();
    }
}