using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Kiểm thử lớp Point2D
            Console.WriteLine("Testing Point2D:");
            Point2D point2D = new Point2D();
            Console.WriteLine("Default Point2D: " + point2D); // Kết quả mong đợi: "0, 0"

            point2D.X = 5.5f;
            point2D.Y = 10.5f;
            Console.WriteLine("Updated Point2D: " + point2D); // Kết quả mong đợi: "5.5, 10.5"

            point2D.SetXY(2.2f, 3.3f);
            float[] xy = point2D.GetXY();
            Console.WriteLine($"Point2D after SetXY: X = {xy[0]}, Y = {xy[1]}"); // Kết quả mong đợi: "X = 2.2, Y = 3.3"

            // Kiểm thử lớp Point3D
            Console.WriteLine("\nTesting Point3D:");
            Point3D point3D = new Point3D();
            Console.WriteLine("Default Point3D: " + point3D); // Kết quả mong đợi: "0, 0, 0"

            point3D.X = 1.1f;
            point3D.Y = 2.2f;
            point3D.Z = 3.3f;
            Console.WriteLine("Updated Point3D: " + point3D); // Kết quả mong đợi: "1.1, 2.2, 3.3"

            point3D.SetXYZ(4.4f, 5.5f, 6.6f);
            float[] xyz = point3D.GetXYZ();
            Console.WriteLine($"Point3D after SetXYZ: X = {xyz[0]}, Y = {xyz[1]}, Z = {xyz[2]}"); // Kết quả mong đợi: "X = 4.4, Y = 5.5, Z = 6.6"

            Console.ReadLine();
        }
    }
}
