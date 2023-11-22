using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 배열의 평균값
internal class AverageArray
{
    public double solution(int[] numbers)
    {
        double num1 = 0;
        double num2 = 0;
        foreach (int i in numbers)
        {
            num1++;
            num2 += i;
        }
        double answer = num2 / num1;
        return answer;
    }
}
