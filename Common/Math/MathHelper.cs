using System;

namespace Common
{
    public static class MathHelper
    {
        public static double ToRadians(double degrees)
        {
            return (Math.PI / 180) * degrees;
        }

        public static double ToDegrees(double radians)
        {
            return (180 / Math.PI) * radians;
        }

        public static float ToRadians(float degrees)
        {
            return (float)(Math.PI / 180) * degrees;
        }

        public static float ToDegrees(float radians)
        {
            return (float)(180 / Math.PI) * radians;
        }

        public static Vector2d SphericalToTextureCoords(double lat, double lon)
        {
            double tx = (Math.PI + lon) / (Math.PI * 2);
            double ty = (Math.PI * 0.5 - lat) / Math.PI;

            return new Vector2d(tx, ty);
        }

        public static Vector2d SphericalToTextureCoords(Vector3d n)
        {
            double lat = Math.Asin(n.z);
            double lon = Math.Atan2(n.y, n.x);

            return SphericalToTextureCoords(lat, lon);
        }
    }
}