using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorsLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int state = 0;
            int result = 0;

            int[,] matrix = {{1,4,1,0},
                          {1,2,0,0},
                          {2,3,0,0},
                          {3,4,0,1},
                          {4,4,0,0}};
            int choose;
            Console.WriteLine("Enter path: ");
            string input = Console.ReadLine();
            Console.WriteLine("Press: 1 - StepByStep, 2 - Final result ");
            while (true)
            {
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)

                {
                    case 1:
                        {
                            Console.WriteLine("Current position  :   Path");
                            for (int i = 0; i < input.Length; i++)
                            {
                                if (input[i] == 'a')
                                {
                                    Console.WriteLine($"{matrix[state, 0]} : a>{matrix[state, 0]}");
                                    Console.ReadKey();
                                    state = matrix[state, 0];

                                }
                                else if (input[i] == 'b')
                                {
                                    Console.WriteLine($"{matrix[state, 1]} : b>{matrix[state, 1]}");
                                    Console.ReadKey();
                                    state = matrix[state, 1];
                                }
                                else
                                {
                                    Console.WriteLine("Wrong Characters.");
                                }
                                result = matrix[state, 3];
                            }
                            if (result == 1)
                            {
                                Console.WriteLine("String passes DFA");
                            }
                            else
                            {
                                Console.WriteLine("ERROR!");
                            }

                            break;
                        }
                    case 2:
                        {
                            for (int i = 0; i < input.Length; i++)
                            {
                                if (input[i] == 'a')
                                {
                                    state = matrix[state, 0];
                                }
                                else if (input[i] == 'b')
                                {
                                    state = matrix[state, 1];
                                }
                                else
                                {
                                    Console.WriteLine("Wrong Characters.");
                                }
                                result = matrix[state, 3];
                            }
                            if (result == 1)
                            {
                                Console.WriteLine("String passes DFA");
                            }
                            else
                            {
                                Console.WriteLine("ERROR!");
                            }
                            break;
                        }
                        
                        
                        
                }
            }
        }
    }
}
