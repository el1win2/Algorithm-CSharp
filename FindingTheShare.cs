using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 몫 구하기
internal class FindingTheShare
{
    public int solution(int num1, int num2)
    {
        if (num1 < 0 || num1 > 100) num1 = 0;
        if (num2 < 0 || num2 > 100) num2 = 0;
        int answer = (int)(num1 / num2);
        return answer;
    }
}
