using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 두 수의 나눗셈
internal class DivisionTwoNumbers
{
    public int solution(int num1, int num2)
    {
        if (1 > num1 || num1 > 100) num1 = 1;
        if (1 > num2 || num2 > 100) num2 = 1;
        float answer = (float)num1 / (float)num2 * 1000;
        return (int)answer;
    }
}
