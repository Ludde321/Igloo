using System;
using System.Collections.Generic;
using Common;

namespace IglooBuilder
{
    public class IglooBuilder
    {
        public Geometry IceBox;

        public Geometry Igloo;

        public double PoleLength = 4;

        public void Build()
        {
            CreateIceBox();
            // Igloo.Vertexes.Add(new Vector3d()); // 0,0,0

            // double d = 0;
            // for(int i=0;i<=8;i++)
            // {
            //     var m = Matrix3x3d.FromRotationZ(MathHelper.ToRadians(d));

            //     AddBox(m);

            //     d += 22.5;
            // }
        }

        private void AddBox(Matrix3x3d m)
        {
            // var left = m.GetRow(0);
            // var forward = m.GetRow(1);
            // var up = m.GetRow(2);

            // var p0 = Vector3d.Multiply(forward, PoleLength);
        }

        private void CreateIceBox()
        {
            var v0 = new Vector3d(0, 0, 0);

        }

    }
}
