using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 평균 구하기
internal class FindingAverage
{
    public double solution(int[] arr)
    {
        int num1 = 0;
        int num2 = 0;
        foreach (int i in arr)
        {
            num1 += i;
            num2++;
        }
        double answer = (double)num1 / (double)num2;
        return answer;
    }
}
