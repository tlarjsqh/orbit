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
        {
            int wonja;
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("[청주고등학교]보어의 원자 모형에 의한 원자의 전자 배치");
            Console.WriteLine("제작자 - 심건보 21116");
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("원자 번호를 입력해주십시오.");
            wonja = int.Parse(Console.ReadLine());


            if (wonja <= 2)
            {
                Console.WriteLine("K({0})", wonja);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if(wonja <= 10)
            {
                Console.WriteLine("K(2)L({0})",wonja - 2 );
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if(wonja <= 18)
            {
                Console.WriteLine("K(2)L(8)M({0})", wonja - 10);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if(wonja <= 20)
            {
                Console.WriteLine("K(2)L(8)M(8)N({0})", wonja - 18);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 23)
            {
                Console.WriteLine("K(2)L(8)M({0})N(2)", wonja - 12);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 25)
            {
                Console.WriteLine("K(2)L(8)M(13)N({0})", wonja - 23);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 28)
            {
                Console.WriteLine("K(2)L(8)M({0})N(2)", wonja - 12);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 36)
            {
                Console.WriteLine("K(2)L(8)M(18)N({0})", wonja - 28);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 38)
            {
                Console.WriteLine("K(2)L(8)M(18)N(8)O({0})", wonja - 36);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 40)
            {
                Console.WriteLine("K(2)L(8)M(18)N({0})O(2)", wonja - 30);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 41)
            {
                Console.WriteLine("K(2)L(8)M(18)N(12)O(1)", wonja - 30);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 43)
            {
                Console.WriteLine("K(2)L(8)M(18)N(13)O({0})", wonja - 41);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 45)
            {
                Console.WriteLine("K(2)L(8)M(18)N({0})O(1)", wonja - 29);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 46)
            {
                Console.WriteLine("K(2)L(8)M(18)N(18)", wonja - 29);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 54)
            {
                Console.WriteLine("K(2)L(8)M(18)N(18)O({0})", wonja - 46);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 56)
            {
                Console.WriteLine("K(2)L(8)M(18)N(18)O(8)P({0})", wonja - 54);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 58)
            {
                Console.WriteLine("K(2)L(8)M(18)N({0})O(9)P(2)", wonja - 39);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 63)
            {
                Console.WriteLine("K(2)L(8)M(18)N({0})O(8)P(2)", wonja - 38);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 64)
            {
                Console.WriteLine("K(2)L(8)M(18)N(25)O(9)P(2)", wonja - 54);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 70)
            {
                Console.WriteLine("K(2)L(8)M(18)N({0})O(8)P(2)", wonja - 38);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 79)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O({0})P(1)", wonja - 61);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 86)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O(18)P({0})", wonja - 78);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 88)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O(18)P(8)Q({0})", wonja - 86);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 90)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O(18)P({0})Q(2)", wonja - 80);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 93)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O({0})P(9)Q(2)", wonja - 71);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 95)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O({0})P(8)Q(2)", wonja - 70);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 96)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O(25)P(9)Q(2)", wonja - 70);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 102)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O({0})P(8)Q(2)", wonja - 70);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 103)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O(32)P(8)Q(3)", wonja - 70);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 109)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O(32)P({0})Q(2)", wonja - 94);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 111)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O(32)P(17)Q({0})", wonja - 109);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 112)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O(32)P(18)Q(2)", wonja - 109);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else if (wonja <= 118)
            {
                Console.WriteLine("K(2)L(8)M(18)N(32)O(32)P(18)Q({0})", wonja - 110);
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("알수없는 원자번호입니다.");
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("엔터를 누르면 종료됩니다.");
                Console.ReadLine();
            }
        }
    }
}
