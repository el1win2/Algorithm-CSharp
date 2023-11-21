using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp;
// 각도기
internal class Protractor
{
    public int solution(int angle)
    {
        int answer = 0;
        if (1 > angle || angle > 180) angle = 1;
        if (0 < angle && angle < 90)
        {
            answer = 1;
        }
        else if (angle == 90)
        {
            answer = 2;
        }
        else if (90 < angle && angle < 180)
        {
            answer = 3;
        }
        else
        {
            answer = 4;
        }

        return answer;
    }
}
