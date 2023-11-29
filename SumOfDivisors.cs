using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 약수의 합
internal class SumOfDivisors
{
    public int solution(int n)
    {
        int num = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                num += i;
            }
        }
        int answer = num;
        return answer;
    }
}
