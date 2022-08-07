using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // https://school.programmers.co.kr/learn/courses/30/lessons/42583?language=csharp
    
    public class Programmers_42583
    {
        public static void Execute()
        {
            Programmers_42583 s = new Programmers_42583();
            s.Test(2, 10, new[] { 7, 4, 5, 6 });
            s.Test(100, 100, new[] { 10 });
            s.Test(100, 100, new[] { 10,10,10,10,10,10,10,10,10,10 });
        }

        public void Test(int bridge_length, int weight, int[] truck_weights) {
            var answer = solution(bridge_length, weight, truck_weights);
            Console.WriteLine(answer);
        }
        
        public int solution(int bridge_length, int weight, int[] truck_weights) {
            int answer = 0;
            Queue<int> truckReady = new Queue<int>(truck_weights);
            Queue<(int, int)> truckOnBridge = new Queue<(int, int)>(bridge_length);
            int currentWeightBridge = 0;
            int turnCount = 0;
            
            for(int i = 0; i < truck_weights.Length; i++)
                truckReady.Enqueue(truck_weights[i]);

            
            while (truckReady.Count > 0 || truckOnBridge.Count > 0)
            {
                turnCount++;
                
                bool isEnterNextTruck = truckReady.Count > 0 && 
                                        truckOnBridge.Count < bridge_length &&
                                        currentWeightBridge + truckReady.Peek() <= weight;

                if (isEnterNextTruck)
                {
                    var truck = truckReady.Dequeue(); 
                    truckOnBridge.Enqueue((0, truck));
                    currentWeightBridge += truck;
                }

                int truckCountOnBridge = truckOnBridge.Count;
                for (int i = 0; i < truckCountOnBridge; i++)
                {
                    var t = truckOnBridge.Dequeue();
                    t.Item1++;
                    if (t.Item1 >= bridge_length)
                    {
                        currentWeightBridge -= t.Item2;
                        continue;
                    }
                    else
                    {
                        truckOnBridge.Enqueue(t);
                    }
                }
            }

            answer = turnCount + 1;

            return answer;
        }
    }
}