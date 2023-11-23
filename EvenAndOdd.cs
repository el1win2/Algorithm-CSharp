using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 짝수와 홀수
internal class EvenAndOdd
{
    public string solution(int num)
    {
        string answer;
        if (num % 2 == 0)
        {
            answer = "Even";
        }
        else
        {
            answer = "Odd";
        }
        return answer;
    }
}
