using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Matrix3x3d
    {
        public double m11 = 1, m21 = 0, m31 = 0;
        public double m12 = 0, m22 = 1, m32 = 0;
        public double m13 = 0, m23 = 0, m33 = 1;

        public static Matrix3x3d Scale(Matrix3x3d m, double s)
        {
            return new Matrix3x3d
            {
                m11 = m.m11 * s,
                m12 = m.m12 * s,
                m13 = m.m13 * s,
                m21 = m.m21 * s,
                m22 = m.m22 * s,
                m23 = m.m23 * s,
                m31 = m.m31 * s,
                m32 = m.m32 * s,
                m33 = m.m33 * s,
            };
        }

        public static Matrix3x3d Scale(Matrix3x3d m, Vector3d v)
        {
            return new Matrix3x3d
            {
                m11 = m.m11 * v.x,
                m21 = m.m21 * v.x,
                m31 = m.m31 * v.x,
                m12 = m.m12 * v.y,
                m22 = m.m22 * v.y,
                m32 = m.m32 * v.y,
                m13 = m.m13 * v.y,
                m23 = m.m23 * v.y,
                m33 = m.m33 * v.y,
            };
        }

        public static Vector3d Multiply(Matrix3x3d a, Vector3d b)
        {
            return new Vector3d
            {
                x = a.m11 * b.x + a.m12 * b.y + a.m13 * b.z,
                y = a.m21 * b.x + a.m22 * b.y + a.m23 * b.z,
                z = a.m31 * b.x + a.m32 * b.y + a.m33 * b.z,
            };
        }

        public static Vector3d operator *(Matrix3x3d a, Vector3d b)
        {
            return new Vector3d
            {
                x = a.m11 * b.x + a.m12 * b.y + a.m13 * b.z,
                y = a.m21 * b.x + a.m22 * b.y + a.m23 * b.z,
                z = a.m31 * b.x + a.m32 * b.y + a.m33 * b.z,
            };
        }

        public static Matrix3x3d Multiply(Matrix3x3d a, Matrix3x3d b)
        {
            return new Matrix3x3d
            {
                m11 = a.m11 * b.m11 + a.m12 * b.m21 + a.m13 * b.m31,
                m12 = a.m11 * b.m12 + a.m12 * b.m22 + a.m13 * b.m32,
                m13 = a.m11 * b.m13 + a.m12 * b.m23 + a.m13 * b.m33,

                m21 = a.m21 * b.m11 + a.m22 * b.m21 + a.m23 * b.m31,
                m22 = a.m21 * b.m12 + a.m22 * b.m22 + a.m23 * b.m32,
                m23 = a.m21 * b.m13 + a.m22 * b.m23 + a.m23 * b.m33,

                m31 = a.m31 * b.m11 + a.m32 * b.m21 + a.m33 * b.m31,
                m32 = a.m31 * b.m12 + a.m32 * b.m22 + a.m33 * b.m32,
                m33 = a.m31 * b.m13 + a.m32 * b.m23 + a.m33 * b.m33,
            };
        }

        public static Matrix3x3d operator *(Matrix3x3d a, Matrix3x3d b)
        {
            return new Matrix3x3d
            {
                m11 = a.m11 * b.m11 + a.m12 * b.m21 + a.m13 * b.m31,
                m12 = a.m11 * b.m12 + a.m12 * b.m22 + a.m13 * b.m32,
                m13 = a.m11 * b.m13 + a.m12 * b.m23 + a.m13 * b.m33,

                m21 = a.m21 * b.m11 + a.m22 * b.m21 + a.m23 * b.m31,
                m22 = a.m21 * b.m12 + a.m22 * b.m22 + a.m23 * b.m32,
                m23 = a.m21 * b.m13 + a.m22 * b.m23 + a.m23 * b.m33,

                m31 = a.m31 * b.m11 + a.m32 * b.m21 + a.m33 * b.m31,
                m32 = a.m31 * b.m12 + a.m32 * b.m22 + a.m33 * b.m32,
                m33 = a.m31 * b.m13 + a.m32 * b.m23 + a.m33 * b.m33,
            };
        }

        public static Matrix3x3d FromRotationX(double rotateX)
        {
            double cosx = Math.Cos(rotateX);
            double sinx = Math.Sin(rotateX);

            return new Matrix3x3d
            {
                m11 = 1,
                m12 = 0,
                m13 = 0,
                m21 = 0,
                m22 = cosx,
                m23 = sinx,
                m31 = 0,
                m32 = -sinx,
                m33 = cosx,
            };
        }

        public static Matrix3x3d FromRotationY(double rotateY)
        {
            double cosy = Math.Cos(rotateY);
            double siny = Math.Sin(rotateY);

            return new Matrix3x3d
            {
                m11 = cosy,
                m12 = 0,
                m13 = -siny,
                m21 = 0,
                m22 = 1,
                m23 = 0,
                m31 = siny,
                m32 = 0,
                m33 = cosy,
            };
        }

        public static Matrix3x3d FromRotationZ(double rotateZ)
        {
            double cosz = Math.Cos(rotateZ);
            double sinz = Math.Sin(rotateZ);

            return new Matrix3x3d
            {
                m11 = cosz,
                m12 = sinz,
                m13 = 0,
                m21 = -sinz,
                m22 = cosz,
                m23 = 0,
                m31 = 0,
                m32 = 0,
                m33 = 1,
            };
        }

        public static Matrix3x3d FromRotation(double rotateX, double rotateY, double rotateZ)
        {
            var mX = FromRotationX(rotateX);
            var mY = FromRotationY(rotateY);
            var mZ = FromRotationZ(rotateZ);

            return mZ * mY * mX;
        }

        public Vector3d GetRow(int r)
        {
            switch (r)
            {
                case 0: return new Vector3d(m11, m12, m13);
                case 1: return new Vector3d(m21, m22, m23);
                case 2: return new Vector3d(m31, m32, m33);
                default:
                    throw new ArgumentException($"Row number out of range: {r}");
            }
        }
        public Vector3d GetColumn(int c)
        {
            switch (c)
            {
                case 0: return new Vector3d(m11, m21, m31);
                case 1: return new Vector3d(m12, m22, m32);
                case 2: return new Vector3d(m13, m23, m33);
                default:
                    throw new ArgumentException($"Column number out of range: {c}");
            }
        }

        public Matrix3x3d GetTranspose()
        {
            return new Matrix3x3d
            {
                m11 = m11,
                m12 = m21,
                m13 = m31,

                m21 = m12,
                m22 = m22,
                m23 = m32,

                m31 = m13,
                m32 = m23,
                m33 = m33,
            };
        }

        public override string ToString()
        {
            return $"{m11}, {m12}, {m13}\r\n{m21}, {m22}, {m23}\r\n{m31}, {m32}, {m33}";
        }

        public Matrix3x3d GetInverse()
        {
            double d = m11 * m22 * m33 -
                       m11 * m32 * m23 +
                       m21 * m32 * m13 -
                       m21 * m12 * m33 +
                       m31 * m12 * m23 -
                       m31 * m22 * m13;

            double _d = (d != 0) ? 1 / d : 0;

            return new Matrix3x3d
            {
                m11 = (m22 * m33 - m23 * m32) * _d,
                m12 = (m13 * m32 - m12 * m33) * _d,
                m13 = (m12 * m23 - m13 * m22) * _d,

                m21 = (m23 * m31 - m21 * m33) * _d,
                m22 = (m11 * m33 - m13 * m31) * _d,
                m23 = (m13 * m21 - m11 * m23) * _d,

                m31 = (m21 * m32 - m22 * m31) * _d,
                m32 = (m12 * m31 - m11 * m32) * _d,
                m33 = (m11 * m22 - m12 * m21) * _d,
            };
        }
    }
}
