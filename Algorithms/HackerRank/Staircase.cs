using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HackerRank
{
    public class Staircase
    {
        public void BuildStaircase(int n)
        {
           

            //string stairCaseFloor = staircaseBuilder[0];
            //for (int i = 0; i < n; i++)
            //{
            //    staircaseBuilder.Add(stairCaseFloor.Substring(i + 1, n - 1));
            //}

            //foreach (var staircaseLevel in staircaseBuilder)
            //{
            //    Console.WriteLine(staircaseLevel);
            //}
        }
        public string CreateStaircaseFloor(int n)
        {
            List<string> staircaseBuilder = new List<string> { "" };

            for (int i = 0; i < n; i++)
            {
                staircaseBuilder[0] += "#";
            }
            return staircaseBuilder[0];

        }


    }
}
