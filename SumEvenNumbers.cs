using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 짝수의 합
internal class SumEvenNumbers
{
    public int solution(int n)
    {
        int answer = 0;
        if (1 > n || n > 1000) n = 1;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0) answer += i;
        }
        return answer;
    }
}
