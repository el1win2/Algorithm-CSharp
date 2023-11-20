using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 숫자 비교하기
internal class CompareTheNumbers
{
    public int solution(int num1, int num2)
    {
        if (0 > num1 || num1 > 10000) num1 = 0;
        if (0 > num2 || num2 > 10000) num2 = 0;
        if (num1 == num2)
        {
            return 1;
        }
        else { return -1; }
    }
}
