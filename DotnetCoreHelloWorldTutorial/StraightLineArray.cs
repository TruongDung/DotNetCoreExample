using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    public class Point
    {
        public int _value;
        public int _x;
        public int _y;

        public Point(int x, int y, int value)
        {
            this._x = x;
            this._y = y;
            this._value = value;
        }
    }
    class StraightLineArray
    {
        public static bool check(int n, int [] ar )
        {
            int tem = 1;

            var lst1 = new List<Point>();
            bool flag = true;
            for (int i=0;i< n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    lst1.Add(new Point(i + 1, j + 1, tem));
                    tem++;
                }
            }

            for (int i = 0; i < ar.Length; i++)
            {
                var data1 = lst1.Find(w => w._value == ar[i]);
                var data2 = lst1.Find(w => w._value == ar[i + 1]);

                if (data1._x == data2._x || data1._y == data2._y)
                    flag = true;
                else
                {
                    flag = false;
                    break;
                }

                if (i + 1 + 1 == ar.Length)
                    break;
            }
            return flag;
        }

        public static bool check1(int n, int[] ar)
        {
            for(int i=0; i<ar.Length; i++)
            {
                var a = ar[i];
                var b = ar[i+1];


                var result = Math.Abs(a - b);
                if(i+1+1 == ar.Length)
                {
                    break;
                }
            }
            return true;
        }
    }
}
