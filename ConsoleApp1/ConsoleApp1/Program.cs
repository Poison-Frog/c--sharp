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
            Console.WriteLine("hello world");
            //单行注释
            const string CITY = "布宜诺斯艾利斯";//常量，城市
            const string NAME = "列奥波尔多·福图纳托·加尔铁里·卡斯特利";//常量，姓名
            Console.WriteLine(NAME+"出生在"+CITY+"的一个工人家庭");//使用常量
            string hobby;//声明变量保存爱好
            hobby="剑道";//给爱好变量赋值
            Console.WriteLine("我爱好"+hobby);//打印变量
            string boy = "秀丽";//男孩名字
            string girl = "伟强";//女孩名字
            string temp;//中间变量
            temp = boy;//把男孩的名字赋值给temp
            boy = girl;//把女孩的名字赋值给男孩
            girl = temp;//把temp中的名字赋值给女孩
            Console.WriteLine("男孩叫" + boy + " 女孩叫" + girl);
            string today;//今天的午饭
            string tomorrow;//明天的午饭
            today = "鱼香肉丝";
            tomorrow = "小鸡炖蘑菇";
            //请在这里补充代码，实现变量today和tomorrow的交换
            string tem;
            tem = today;
            today = tomorrow;
            tomorrow = tem;
            //打印
            Console.WriteLine("我今天吃{0}，明天吃{1}。", today, tomorrow);
            string name = "曹少钦";//姓名，string类型
            char sex = '男';//性别，char类型
            int age = 19;//年龄，int类型
            double height = 1.72;//身高，double类型
            Console.WriteLine("我叫{0}，是{1}生，今年{2}岁，身高{3}米。", name, sex, age, height);
            double d = 2.5;
            int x = (int)d + 1;
            Console.WriteLine(x);
            int _num1 = 5;//第一个加数
            int _num2 = 7;//第二个加数
            int _sum = _num1 + _num2;//求和
            Console.WriteLine("和是{0}", _sum);//打印结果
            double salary = 6000.00;//基本工资
            double prize = 3200.00;//奖金
            double tax = 4500.00;//交税
            Console.WriteLine("我的工资奖金总额是{0}元", salary + prize);
            Console.WriteLine("我的税后收入是{0}元", salary + prize - tax);
            int year = 2015;//年份
            Console.WriteLine(year % 4);//求年份除以4的余数
            int y = 5;
            int z = 5;
            y++;
            Console.Write(y);
            Console.Write(++z);
            double a = 3.5;
            int b = 3;
            Console.WriteLine((int)a == b);
        }
    }
}