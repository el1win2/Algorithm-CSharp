using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 자릿수 더하기
internal class AddDigits
{
    public int solution(int n)
    {
        int num = 0;
        foreach (char s in n.ToString())
        {
            int i = int.Parse(s.ToString());
            num += i;
        }
        int answer = num;
        return answer;
    }
}
