﻿using System;

namespace ClassyPropertyMethod
{
    // 클래스
    class Point
    {
        // 속성
        public int X { get; set; }
        public int Y { get; set; }
        // 메서드(함수)
        public void Draw()
        {
            Console.WriteLine($"X: {this.X}, Y: {this.Y}");
        }
    }

    class ClassyPropertyMethod
    {
        static void Main()
        {
            var point = new Point();
            point.X = 100;
            point.Y = 200;
            point.Draw();
        }
    }

}