using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;

public class MultiplyingTwoNumbers
{
    public int solution(int num1, int num2)
    {
        if (0 > num1 || num1 > 100) num1 = 0;
        if (0 > num2 || num2 > 100) num2 = 0;
        int answer = num1 * num2;
        return answer;
    }
}