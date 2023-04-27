using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Backtracking
    {
        // 자연수 N과 M이 주어졌을 때, 아래 조건을 만족하는 길이가 M인 수열을 모두 구하는 프로그램을 작성하시오.
        // - 1부터 N까지 자연수 중에서 M개를 고른 수열
        // - 같은 수를 여러 번 골라도 된다.
        //
        // 입력
        // - 첫째 줄에 자연수 N과 M이 주어진다. (1 ≤ M ≤ N ≤ 7)
        // 출력
        // - 한 줄에 하나씩 문제의 조건을 만족하는 수열을 출력한다.중복되는 수열을 여러 번 출력하면 안되며,
        //   각 수열은 공백으로 구분해서 출력해야 한다.
        // - 수열은 사전 순으로 증가하는 순서로 출력해야 한다.
        // 
        //
        // 1. 입력 N : 3   2. 입력 : N : 4          3. 입력 : N : 3  
        //         M : 1             M : 2                    M : 3
        //    출력 1          출력 1 1                 출력 1 1 1
        //         2               1 2                      1 1 2
        //         3               1 3                      1 1 3
        //                         1 4                      1 2 1
        //                         2 1                      1 2 2
        //                         2 2                      1 2 3
        //                         2 3                      1 3 1
        //                         2 4                      1 3 2
        //                         3 1                      1 3 3
        //                         3 2                      2 1 1
        //                         3 3                      2 1 2
        //                         3 4                      2 1 3
        //                         4 1                      2 2 1
        //                         4 2                      2 2 2
        //                         4 3                      2 2 3
        //                         4 4                      2 3 1
        //                                                  2 3 2
        //                                                  2 3 3
        //                                                  3 1 1
        //                                                  3 1 2
        //                                                  3 1 3
        //                                                  3 2 1
        //                                                  3 2 2
        //                                                  3 2 3
        //                                                  3 3 1
        //                                                  3 3 2
        //                                                  3 3 3
    
        public static void NM()
        {
            int n = 3;
            void NM1()
            {
                for (int i = 1; i > n; i++)
                {
                    Console.WriteLine($"{i}");
                }
            }
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine(NM1);


            // if (n <= 3 && n > m && m == 1 )
            // {
            //
            // }
            // else if(n == 4 n > m)
            //     
            // return n > m;
        }
        //public static bool NM2(int n, int m)
        //{
        //    n = 4;
        //    m = 2;
        //    return n > m;
        //    
        //}
        //public static bool NM3(int n, int m)
        //{
        //    n = 3;
        //    m = 3;
        //    return n == m;
        //
        //}
    }
}





