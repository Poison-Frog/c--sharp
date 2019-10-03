using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {/*
             * 这是一段提示信息 
             */
            Console.Write("hello world");
            //单行注释
            const string CITY = "布宜诺斯艾利斯";//常量，城市
            const string NAME = "列奥波尔多·福图纳托·加尔铁里·卡斯特利";//常量，姓名
            Console.WriteLine(NAME+"出生在"+CITY+"的一个工人家庭");//使用常量
            string hobby;//声明变量保存爱好
            hobby="剑道";//给爱好变量赋值
            Console.WriteLine("我爱好"+hobby);//打印变量
        }
    }
}