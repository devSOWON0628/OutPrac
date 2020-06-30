using System;

namespace StrucPrac
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Point p;
            p.x = 10;
            p.y = 20;*/

            Point p = new Point();
            Console.WriteLine("Point x:"+p.x+"  Point Y:"+p.y);

            PointClass pointclassA = new PointClass(10, 20);
            PointClass pointclassB = pointclassA;
            pointclassB.x = 100;
            pointclassB.y = 200;

            Console.WriteLine("pointclassA x:" + pointclassA.x + "  pointclassA Y:" + pointclassA.y);

            PointStruct pointstructA = new PointStruct(10, 20);
            PointStruct pointstructB = pointstructA;
            pointstructB.x = 100;
            pointstructB.y = 200;

            Console.WriteLine("pointstructA x:" + pointstructA.x + "  pointstructA Y:" + pointstructA.y);


        }
    }
    class PointClass
    {
        public int x;
        public int y;

        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    struct PointStruct
    {
        public int x;
        public int y;

        public PointStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
