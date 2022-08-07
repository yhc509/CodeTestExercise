using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    // https://school.programmers.co.kr/learn/courses/30/lessons/42586
    
    public class Programmers_42586
    {
        public static void Execute()
        {
            Programmers_42586 s = new Programmers_42586();
            s.Test(new[] { 93, 30, 55 }, new[] { 1, 30, 5 });
        }
        
        public void Test(int[] progresses, int[] speeds) {
            var answer = solution(progresses, speeds);
            for(int i = 0 ; i < answer.Length; i++)
                Console.Write($"{answer[i]} ");
            Console.WriteLine("");
        }

        public class Job
        {
            public int index;
            public int progress;
            public int speed;
            public int day;
        }
        public int[] solution(int[] progresses, int[] speeds)
        {
            Dictionary<int, int> answer = new Dictionary<int, int>();
            List<Job> jobQueue = new List<Job>();

            for (int i = 0; i < progresses.Length; i++)
            {
                var jobProgress = new Job()
                {
                    index = i,
                    progress = progresses[i],
                    speed = speeds[i]
                };
                jobQueue.Add(jobProgress);
            }

            while (jobQueue.Count > 0)
            {
                Job currentJob = null;
                foreach (var j in jobQueue.ToList())
                {
                    j.progress += j.speed;
                    j.day++;
                    if (j.progress >= 100 && jobQueue.FirstOrDefault() == j)
                    {
                        if(answer.ContainsKey(j.day))
                            answer[j.day]++;
                        else
                            answer.Add(j.day, 1);

                        jobQueue.Remove(j);
                    }
                }
                
            }
            

            return answer.Values.ToArray();
        }
    }

    
}