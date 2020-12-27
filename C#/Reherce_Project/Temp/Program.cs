using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Temp;

//Console.WriteLine("hi");

Console.WriteLine(xx(10, 5, MoSo.Add));

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
numbers.FindAll(num => num % 2 == 0);

static int xx(int a , int b, Func F)
{
    return F(a, b);
    
}

delegate int Func(int a, int b);