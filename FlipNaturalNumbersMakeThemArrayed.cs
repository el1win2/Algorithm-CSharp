using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 자연수 뒤집어 배열로 만들기
internal class FlipNaturalNumbersMakeThemArrayed
{
    public int[] solution(long n)
    {
        string s = n.ToString();
        char[] chars = s.ToCharArray();
        int[] answer = new int[chars.Length];
        Array.Reverse(chars);
        for (int num = 0; num < chars.Length; num++)
        {
            answer[num] = chars[num] - '0';
        }
        return answer;
    }
}
