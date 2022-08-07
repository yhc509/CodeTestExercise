// using System;
// using System.Collections.Generic;

// namespace ConsoleApp1
// {
//     public class Solution2
//     {
        
//         public static void Execute()
//         {
//             Solution2 s = new Solution2();
//             var an = s.solution(new[]
//             {
//                 "I 16",
//                 "I -5643",
//                 "D -1",
//                 "D 1",
//                 "D 1",
//                 "I 123",
//                 "D -1"
//             });
//             Console.WriteLine($"{an}");
//         }
        
//         private List<int> _queue = new List<int>();
        
//         public int[] solution(string[] operations) {
//             int[] answer = new int[] {};
//             _queue.Clear();

//             for (int i = 0; i < operations.Length; i++)
//             {
//                 string[] split = operations[i].Split(' ');
//                 string command = split[0];
//                 int param = int.Parse(split[1]);

//                 switch (command)
//                 {
//                     case "I":
//                         _queue.Insert(0, param);
//                         break;
//                     case "D":
//                         int index = -1;
//                         if (param == 1) index = FindMax();
//                         else if (param == -1) index = FindMin();

//                         if (index < 0 || _queue.Count <= index) break;
//                         _queue.RemoveAt(index);
//                         break;
//                 }
//             }

//             if (_queue.Count == 0) answer = new[] {0, 0};
//             else
//             {
//                 answer = new[]
//                 {
//                     _queue[FindMax()], _queue[FindMin()]
//                 };
//             }
            
//             return answer;
//         }

//         private int FindMax()
//         {
//             int result = 0;

//             for (int i = 0; i < _queue.Count; i++)
//             {
//                 if (_queue[i] >= _queue[result]) result = i;
//             }

//             return result;
//         }
        
//         private int FindMin()
//         {
//             int result = 0;

//             for (int i = 0; i < _queue.Count; i++)
//             {
//                 if (_queue[i] <= _queue[result]) result = i;
//             }

//             return result;
//         }
//     }

// }