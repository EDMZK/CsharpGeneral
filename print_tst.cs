// See https://aka.ms/new-console-template for more information
using System;
namespace Simple //命名空间是一种把相关的类型声明分组并命名的方法
{



    class print_tst           //声明一个类
    {
        static void Main()
        {
            System.Console.Write("Hi there.");
            System.Console.WriteLine("Hi there2.换行");


            int a = 30;
            System.Console.WriteLine("The two sample are {0} and {1}.The money is {2:C}", a, 20,114514);
            System.Console.WriteLine("the test tabRight num is   |{0,-20}|",a);//-20表示 左对齐于 在20个字段中
            System.Console.WriteLine("the test tabRight num is   |{0,20}|\n", a);// 20表示 右对齐于 在20个字段中


            double MyDouble = 300.1415926;
            System.Console.WriteLine("{0,-10:G5}|总体精度5 General", MyDouble);//10格内靠左，General 总精度5
            System.Console.WriteLine("{0,-10}|默认 无精度", MyDouble);
            System.Console.WriteLine("{0,-10:F5}|小数精度5 定点", MyDouble);
            System.Console.WriteLine("{0,-10:N5}|小数精度5 定点，且整数部分3个一组来分割", MyDouble);
            System.Console.WriteLine("{0,-10:C5}|小数精度5 金钱",MyDouble);
            System.Console.WriteLine("{0,-10:E5}|小数精度5 科学计数法", MyDouble);
            //E:Science    F:fixed point  G:General  C:Currency  P:Percentage  N:Num 
            //x:hex X:HEX d:DEC

            System.Console.WriteLine("{0,-10:x}|转换为小写HEX (不支持小数)",114514);
            System.Console.WriteLine("{0,-10:X10}|转换为大写HEX 并补全10位(不支持小数)", 114514);
            System.Console.WriteLine("{0,-10:d}|转换为DEC (只支持整数)", 0b11/*二进制整数*/);
            System.Console.WriteLine("{0,-10:d10}|转换为DEC 并补全10位(只支持整数)", 0x11/*十六进制整数*/);
            System.Console.WriteLine("好了.");



        }
    }






}

