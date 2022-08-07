// namespace ConsoleApp1
// {
//     public class Solution1
//     {
//         public static void Execute()
//         {
            
//         }
        
//         private int[] works_copy;
//         public long solution(int n, int[] works) {
//             long answer = 0;
//             int sum = 0;
            
//             works_copy = new int[works.Length];
//             for (int i = 0; i < works.Length; i++)
//                 works_copy[i] = works[i];
            
//             for (int i = 0; i < works.Length; i++)
//                 sum += works[i];

//             if (n >= sum) return 0;

//             while (n > 0)
//             {
//                 int maxIndex = 0;
//                 for (int i = 0; i < works.Length; i++)
//                 {
//                     if (works[i] > works[maxIndex])
//                     {
//                         maxIndex = i;
//                     }
//                 }

//                 works[maxIndex]--;
//                 n--;
//             }

//             for (int i = 0; i < works.Length; i++)
//                 answer += works[i] * works[i];
            
//             return answer;
//         }
//     }

// }