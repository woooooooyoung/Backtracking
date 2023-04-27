using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp4
{
    internal class Program
    {


        /*
         * 세 개의 장대가 있고 첫 번째 장대에는 반경이 서로 다른 n개의 원판이 쌓여 있다. 
         * 각 원판은 반경이 큰 순서대로 쌓여있다. 
         * 이제 수도승들이 다음 규칙에 따라 첫 번째 장대에서 세 번째 장대로 옮기려 한다.
         * 한 번에 한 개의 원판만을 다른 탑으로 옮길 수 있다.
         * 쌓아 놓은 원판은 항상 위의 것이 아래의 것보다 작아야 한다.
         * 이 작업을 수행하는데 필요한 이동 순서를 출력하는 프로그램을 작성하라. 
         * 단, 이동 횟수는 최소가 되어야 한다.
         * 아래 그림은 원판이 5개인 경우의 예시이다.
         * 
         * input : 첫째 줄에 첫 번째 장대에 쌓인 원판의 개수 N (1 ≤ N ≤ 20)이 주어진다.
         * out put: 첫째 줄에 옮긴 횟수 K를 출력한다.
         * 두 번째 줄부터 수행 과정을 출력한다. 
         * 두 번째 줄부터 K개의 줄에 걸쳐 두 정수 A B를 빈칸을 사이에 두고 출력하는데, 이는 A번째 탑의 가장 위에 있는 원판을 B번째 탑의 가장 위로 옮긴다는 뜻이다.
         */

        public enum Place { Left, Middle, Right }
        public static Stack<int>[] stick;
        public void Hanoi()
        {
            //Move(6, Place.Left, Place.Right);
        }
        public static void Move(int count, int start, int end)
        {
            if (count == 1)
            {
                int node = stick[start].Pop();
                stick[end].Push(node);
                Console.WriteLine($"{start}스틱에서{end}스틱으로{node}이동");
                return;
            }

            int other = 3 - start - end;
            Move(count - 1, start, end);
            Move(1, start, end);
            Move(count - 1, other, end);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            if (n == n)
            {
                
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine($"{i}");
                }
                
            }
            if (n == n)
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine($"{1} {i}");
                    if ( i == 4)
                    {
                        for (int i1 = 1; i1 < 5; i1++ )
                        Console.WriteLine($"{2} {i1}");
                        {
                            if (i == 4)
                            {
                                for (int i2 = 1; i2 < 5; i2++)
                                    Console.WriteLine($"{3} {i2}");
                                {
                                    if (i == 4)
                                    {
                                        for (int i3 = 1; i3 < 5; i3++)
                                            Console.WriteLine($"{4} {i3}");
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (n == n)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"{1} {i}");
                }

            }
        }
    }
}
