﻿// ArithmeticPseudo.*
// 산술 연산자(Arithmetic Operator)
// +, -, *, /, %
using System;

class ArithmeticPseudo
{
    static void Main()
    {
        int a = 5;
        int b = 3;

        Console.WriteLine(a + b); // 더하기: 8
        Console.WriteLine(a - b); // 빼기: 2
        Console.WriteLine(a * b); // 곱하기: 15
        Console.WriteLine(a / b); // 몫: 1  
        Console.WriteLine(
            "{0} % {1} = {2}", a, b, (a % b)); // 나머지: 2
    }
}
