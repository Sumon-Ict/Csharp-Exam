using System;
using System.Collections.Generic;
using System.Text;

namespace TowerofHanoi
{
    class Hanoigame
    {

        List<char> li = new List<char>();
        List<char> li2 = new List<char>();



        public void movecolordice(List<char>li,List<char>li2)
        {
            char ch = li[li.Count - 1];
            li2.Add(ch);
            li.RemoveAt(li.Count - 1);

        }

        public void presensituation(int d,List<char>li, List<char>li2)
        {
            Console.WriteLine($"try no {d}");

            for(int i=0;i<li.Count;i++)
            {
                Console.WriteLine(li[i]);

            }
            for(int i=0;i<li2.Count;i++)
            {
                Console.WriteLine(li2[i]);
            }

        }
    }
}
