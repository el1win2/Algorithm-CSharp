using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 나머지가 1이 되는 수 찾기
internal class FindNumberEqualsOne
{
    public int solution(int n)
    {
        List<int> list = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            int num = n % i;
            if (num == 1) list.Add(i);
        }
        int answer = list[0];
        return answer;
    }
}
