using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // https://school.programmers.co.kr/learn/courses/30/lessons/42587
    
    public class Programmers_42587
    {
        public static void Execute()
        {
            Programmers_42587 s = new Programmers_42587();
            s.Test(new[] { 2, 1, 3, 2 }, 2);
            s.Test(new[] { 1, 1, 9, 1,1,1 }, 0);
        }
        
        public void Test(int[] priorities, int location) {
            var answer = solution(priorities, location);
            Console.WriteLine(answer);
        }

        public int solution(int[] priorities, int location) {
            int answer = 0;
            Queue<(int, int)> priority = new Queue<(int, int)>();
            Queue<(int, int)> jobQueue = new Queue<(int, int)>();

            for (int i = 0; i < priorities.Length; i++)
            {
                priority.Enqueue((i, priorities[i]));
            }

            while (priority.Count > 0)
            {
                (int maxJobIndex, int maxPriority) = FindMaxPriority(priority.ToArray());
                for (int i = 0; i < priority.Count; i++)
                {
                    (int jobIndex, int currentPriority) = priority.Dequeue();
                    if (currentPriority == maxPriority)
                    {
                        jobQueue.Enqueue((jobIndex, currentPriority));
                        break;
                    }
                    else
                    {
                        priority.Enqueue((jobIndex, currentPriority));
                    }
                }
            }

            var arr = jobQueue.ToArray();
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Item2 == priorities[location] &&
                    arr[i].Item1 == location)
                {
                    answer = (i+1);
                    break;
                }
            }
            
            return answer;
        }

        private (int, int) FindMaxPriority((int, int)[] priorities)
        {
            int index = 0;
            int priority = 0;
            for (int i = 0; i < priorities.Length; i++)
            {
                if (priority < priorities[i].Item2)
                {
                    priority = priorities[i].Item2;
                    index = priorities[i].Item1;
                }
            }
            return (index, priority);
        }
    }
}