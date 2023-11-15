using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
public class MinusTwoNumbers
{
    public int solution(int num1, int num2)
    {
        if (-50000 > num1 || num1 > 50000) num1 = 0;
        if (-50000 > num2 || num2 > 50000) num2 = 0;
        int answer = num1 - num2;
        return answer;
    }
}