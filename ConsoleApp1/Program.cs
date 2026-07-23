// C# 200제 2판 예제 타이핑
/*class Hello

{
    static void Main()

    { System.Console.WriteLine("Hello, World");
    }
}*/               // 0
/*using System;
class Hello
{
    static void Main()
    {
    Console.WriteLine("Hello, World");   
    }
}*/             // 1 
/*using System;
    namespace A002_HelloWorld
    {
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Hello, World"); }
    }
    }*/             // 2  
/*using System;

namespace A003_Console
{
    class Program
    { 
        static void Main(string[] args)
    {
        Console.Write("Hello ");
        Console.WriteLine("World!");
        Console.Write("이름을 입력하세요: ");

        string name = Console.ReadLine();
        Console.Write("안녕하세요 , ");
        Console.Write(name);
        Console.WriteLine("님!");
    }
  }
}*/             // 3  
/*using System;

namespace A004_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요 : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("키를 입력하세요(cm) : ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는 ");
            Console.WriteLine("cm 이군요!");
        }
    }
}*/             // 4  
/*using System;
namespace A005_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "H";

            b = b + "ello";
            Console.WriteLine(a == b);
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x;
            Console.WriteLine("c = " + c);
        }
    }
}*/             // 5 
/*using System;
   
namespace CS200
{
    class Program
    {
        static void Main(string[] args)
        {
        int i;
        double x;

        i = 5;
        x = 3.141592;
        Console.WriteLine("i = " + i + ", x = " + x);

        x = i;
        i = (int)x;
        Console.WriteLine("i = " + i + "x = " + x);
        }
    }
}*/             // 6 
/*using System;

namespace A007_ConsoleWriteline
{
    class Program
    {
       static void Main(string[] args)
        {
        bool b = true;
        char c = 'A';
        decimal d = 1.234m;
        double e = 1.23456789;
        float f = 1.23456789f;
        int i = 1234;
        string s ="Hello";

        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(i);
        Console.WriteLine(s);
        }
       
    }
}*/             // 7
/*using System;

namespace A008_ConsoleWriteMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3},", 2, 3, 5, 7);

            string primes;
            primes = String.Format("10 이하의 소수 :  {0}, {1}, {2}, {3},", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}*/             // 8
/*using System;
namespace A009_VariablesAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
        int v1 = 100;
        double v2 = 1.234;
        
        //Console.WriteLine(v1,v2);
        Console.WriteLine(v1.ToString() + ", " + v2.ToString() );
        Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
        Console.WriteLine("v1 = {0}, v2 = {1}" ,v1 , v2);
        Console.WriteLine($"v1 = {v1}, v2= {v2}");
        }

    }

}*/             // 9
/*using System;

namespace A010_ConsoleFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine
                (
                "(C) Currency:.........{0:C}\n" +
                "(D) Decimal:.........{0:D}\n" +
                "(E) Scientific:.........{1:E}\n" +
                "(F) Fixed point:.........{1:F}\n" +
                "(G) General:.........{0:G}\n" +
                "(N) Number:.........{0:N}\n" +
                "(P) Percent:.........{1:P}\n" +
                "(R) Round-trip:.........{1:R}\n" +
                "(X) Hexadecimal:.........{0:X}\n" ,
                -12345678, -1234.5678f
                );
        }
    }
}*/             // 10
/*using System;
namespace A011_FormaatSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:N2}", 1234.5678);
            Console.WriteLine("{0:D8}", 1234);
            Console.WriteLine("{0:F3}", 1234.56);
            Console.WriteLine("{0,8}", 1234);
            Console.WriteLine("{0,-8}", 1234);

            string s;
            s = string.Format("{0:N2}", 1234.5678);
            Console.WriteLine(s);
            s = string.Format("{0:D8}", 1234);
            Console.WriteLine(s);
            s = string.Format("{0:F3}", 1234.56);
            Console.WriteLine(s);

            Console.WriteLine(1234.5678.ToString("N2"));
            Console.WriteLine(1234.ToString("D8"));
            Console.WriteLine(1234.56.ToString("F3"));

            Console.WriteLine("{0:#.##}", 1234.5678);
            Console.WriteLine("{0:0,0.00}", 1234.5678);
            Console.WriteLine("{0:#,#.##}", 1234.5678);
            Console.WriteLine("{0:000000.00}", 1234.5678);

            Console.WriteLine("{0:#.##;(#,#.##):zero}", 1234.5678);
            Console.WriteLine("{0:#.##;(#,#.##):zero}", -1234.5678);
            Console.WriteLine("{0:#.##;(#,#.##):zero}", 0);
        }
    }
}*/             // 11
/*using System;
namespace A012_FloatDoubleDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;

            Console.WriteLine("float : {0}\n double : {1}\n decimal : {2}", flt, dbl, dcm);
            Console.WriteLine("float {0} bytes\n double : {1}bytes \n decunak:{2} bytes", sizeof(float), sizeof(double), sizeof(decimal));
            Console.WriteLine("float : {0}~{1}", float.MinValue, double.MaxValue);
            Console.WriteLine("double : {0}~{1}", double.MinValue, double.MaxValue);
            Console.WriteLine("double : {0}~{1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}*/             // 12
/*using System;
namespace A013_TypeConversion
{
    class Program
    {
       static void Main(string[] args)
        {
            int num = 214783647;
            long bigNum = num;
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;

            a = (int)x;
            Console.WriteLine(a);
        }
    }
}*/             // 13
/*using System;
namespace A014_StringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            Console.Write("1. int로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value);
            
            if (!result)
                Console.WriteLine("'{0}'sms int로 변환될 수 없습니다.\n", input);
            else
                Console.WriteLine("int '{0}'으로 변환되었습니다.\n", value);

            Console.Write("2. double로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();
            try
                {
                double m = Double.Parse(input);
                Console.WriteLine("double {0}으로 변환되었습니다.\n", m);
                }
            catch (FormatException e)
                {
                Console.WriteLine(e.Message);
                }
        }
    }
} */             // 14
/*using System;
namespace A015_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("첫 번쨰 숫자를 입력하세요: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            
            short value = short.MaxValue; //Int16.MaxValue
            Console.WriteLine("/n 2진수, 8진수, 10진수, 16진수로 출력하기");

            int baseNum = 2;
            string s = Convert.ToString(value, baseNum);
            int i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}는 진수 = {2,16}", i, baseNum, s);

            baseNum = 8;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}는 진수 = {2,16}", i, baseNum, s);

            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}는 진수 = {2,16}", i, baseNum, s);

            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}는 진수 = {2,16}", i, baseNum, s);
        }
    }
}*/             // 15
/*using System;
namespace A016_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + 4 * 5); 
            Console.WriteLine((3 + 4) * 5);
            Console.WriteLine(3 * 4 / 5);
            Console.WriteLine(4 / 5  * 5);

            int a = 10, b = 20, c;
            Console.WriteLine(c = a + b);
        }
    }
}*/             // 16
/*using System;
namespace A016_ArthmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수의 계산");
            Console.WriteLine(123 + 45);
            Console.WriteLine(123 - 45);
            Console.WriteLine(123 * 45);
            Console.WriteLine(123 / 45);
            Console.WriteLine(123 % 45);

            Console.WriteLine("\n실수의 계산");
            Console.WriteLine(123.45 + 67.89);
            Console.WriteLine(123.45 - 67.89);
            Console.WriteLine(123.45 * 67.89);
            Console.WriteLine(123.45 / 67.89);
            Console.WriteLine(123.45 % 67.89);
        }
    }
}*/             // 17
/*using System;
namespace A018_DivideByZero
{ 
class Program // a무한대가 나오는 계산식
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;
            Console.WriteLine(10.0 / y);
            Console.WriteLine(x / y);
        }
    }
}
{
   class Program // 0으로 나누려 했습니다.
    {
        static void Main(string[] args)
        {
            int x = 10 , y = 0;
           
            try
            {
                Console.WriteLine(x / y);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}*/             // 18
/*using System;
namespace A020_Overflow
{ // (1)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            int x = int.MaxValue, y = 0;
            y = x + 10;
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    } 
}
{ //(2)
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue, y = 10;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("int.MaxValue + 10 = {0}", y);
                }
        }
    }
}*/             // 19
/*using System;
namespace A020_RelationalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            result = (first == second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);
            result = (first > second);
            Console.WriteLine("{0} > {1} : {2}", first, second, result);
            result = (first < second);
            Console.WriteLine("{0} < {1} : {2}", first, second, result);
            result = (first >= second);
            Console.WriteLine("{0} >= {1} : {2}", first, second, result);
            result = (first <= second);
            Console.WriteLine("{0} <= {1} : {2}", first, second, result);
            result = (first != second);
            Console.WriteLine("{0} != {1} : {2}", first, second, result);

        }
    }
}*/             // 20
/*using System;
namespace A021_LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            result = (first == second) || (first > 5);
            Console.WriteLine("{0} || {1} : {2}", first == second, first > 5, result);
            result = (first == second) && (first > 5);
            Console.WriteLine("{0} && {1} : {2}", first == second, first > 5, result);

            result = true ^ false;
            Console.WriteLine("{0} ^ {1} : {2}", true, false, result);

            result = !(first > second);
            Console.WriteLine("!{0} : {1}", first > second, result);
        }
    }
}*/             // 21
/*using System;
namespace A022_BitwiseOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 11, result;
            
            result = x | y;
            Console.WriteLine("{0} | {1} = {2}", x, y, result);
            result = x & y;
            Console.WriteLine("{0} & {1} = {2}", x, y, result);
            result = x ^ y;
            Console.WriteLine("{0} ^ {1} = {2}", x, y, result);
            result = ~x;
            Console.WriteLine("~{0} = {1}", x, result);
            result = x << 2;
            Console.WriteLine("{0} << 2 = {1}", x, result);
            result = y >> 1;
            Console.WriteLine("{0} >> 1 = {1}", y, result);
        }
    }
}*/             // 22
/*using System;
namespace A023_ConditionalOperator
{
    class Prgram
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            string result = (input > 0) ? " 양수입니다. " : " 음수입니다";
            Console.WriteLine("{0}는 {1}", input, result);
            Console.WriteLine("{0}는 {1}", input, (input % 2 == 0) ? "짝수입니다." : "홀수입니다.");

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0,3}{1}", i, i % 10 != 0 ? "" : "\n");
            }

        }

    }
}*/             // 23
/*using System;
namespace A024_CompoundAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 32;

            Console.WriteLine(x += 2);
            Console.WriteLine(x -= 8);
            Console.WriteLine(x *= 3);
            Console.WriteLine(x /= 2);
            Console.WriteLine(x++);
            Console.WriteLine(--x);
        }
    }
}*/             // 24
/*using System;
namespace A025_StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello, World! ";
            string t;

            Console.WriteLine(s.Length);
            Console.WriteLine(s[8]);
            Console.WriteLine(s.Insert(8 , "c# "));
            Console.WriteLine(s.PadLeft(20 , '.'));
            Console.WriteLine(s.PadRight(20, '.'));
            Console.WriteLine(s.Remove(6));
            Console.WriteLine(s.Remove(6,7));
            Console.WriteLine(s.Replace('ㅣ', 'm'));
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.Trim() + '/');
            Console.WriteLine('/' + s.TrimStart() + '/');
            Console.WriteLine('/' + s.TrimEnd() + '/');

            string[] a = s.Split(',');
            foreach (var i in a)
                Console.WriteLine('/' + i + '/');

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 6);
            Console.WriteLine(destination);

            Console.WriteLine('/' + s.Substring(8) + '/');
            Console.WriteLine('/' + s.Substring(8,5) + '/');

            Console.WriteLine(s.Contains("11"));
            Console.WriteLine(s.IndexOf('0'));
            Console.WriteLine(s.LastIndexOf('0'));
            Console.WriteLine(s.CompareTo("abc"));

            Console.WriteLine(String.Concat("Hi~", s));
            Console.WriteLine(String.Compare("abc", s));
            Console.WriteLine(t = String.Copy(s));

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(",", val);
            Console.WriteLine(result);

        }
    }
}*/             // 25
/*using System;
namespace A025_SplitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("더하고자 하는 숫자들을 입력하세요: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();
            foreach (var i in v)
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과는 {0}", sum);
        }
    }
}*/             // 26
/*using System;
namespace A027_StringConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "bikang";
            string date = DateTime.Today.ToShortDateString();

            string strPlus = "Hello " + userName + ".Today is " + date + ".";
            Console.WriteLine(strPlus);

            string strFormat = String.Format("hello {0}.Today is {1}", userName, date);
            Console.WriteLine(strFormat);

            string strInterPolation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterPolation);

            string strConcat = String.Concat("hHello ", userName, ". Today is ", date, ".");
            Console.WriteLine(strConcat);

            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon", };

            string s = String.Concat(animals);
            Console.WriteLine(s);

            s = String.Join(",", animals);
            Console.WriteLine(s);
        }
    }
}*/             // 27
/*using System;
namespace A027_StringContains
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "Cow"; // s2 = cow
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}' : {2}", s2, s1, b);

            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at index {1}", s2, index);
            }
            if (s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0)
            { 
            Console.WriteLine("'{0}' is ine the string '{1}'", s2, s1);
            }
        }   
    }
}*/             // 28
using System;
namespace A029_StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string max = String.Format("0x{0 : X} {0 : E} {0 : N}", Int64.MaxValue);
            Console.WriteLine(max);

            Decimal exchangeRate = 1129.20m;

            string s = String.Format("현재 원달러 환율은 {0} 입니다.", exchangeRate);
            Console.WriteLine(s);

            s = String.Format("현재 원달러 환율은 {0:C2} 입니다.", exchangeRate);
            Console.WriteLine(s);

            s = String.Format("오늘 날짜는 {0:d}, 시간은 {0:c2} 입니다.", DateTime.Now);
            Console.WriteLine(s);
            Console.WriteLine(s);
            Console.WriteLine(s);
            TimeSpan duration = new TimeSpan(1, 12, 23, 62);
            string output = String.Format("소요시간 : {0:c}", duration);
            Console.WriteLine(s);
        }
    }
}