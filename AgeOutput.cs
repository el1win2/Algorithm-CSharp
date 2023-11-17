using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 나이 출력
internal class AgeOutput
{
    public int solution(int age)
    {
        int year = 2022;
        if (age < 0 || age > 120) age = 1;
        for (int i = 1; i < age; i++)
        {
            year--;
        }
        int answer = year;
        return answer;
    }
}

