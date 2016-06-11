using System;
using System.Collections.Generic;
using System.Linq;

class Matrix_operator
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        List<List<int>> matrix = new List<List<int>>();

        for (int i = 0; i < rows; i++)
        {
            List<int> currentRowValues = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> temp = new List<int>(currentRowValues);

            matrix.Add(temp);
            currentRowValues.Clear();
        }

        string[] commandParams = Console.ReadLine().Split(' ');

        while (commandParams[0] != "end")
        {

            switch (commandParams[0])
            {
                case "remove":

                    string type = commandParams[1];
                    string place = commandParams[2];
                    int position = int.Parse(commandParams[3]);

                    switch (type)
                    {
                        case "positive":

                            //remove positive numbers
                            if (place == "row")
                            {
                                for (int i = 0; i < matrix[position].Count; i++)
                                {
                                    if (matrix[position][i] >= 0)
                                    {
                                        matrix[position].RemoveAt(i);
                                        i--;
                                    }
                                }
                            }

                            else // place == col
                            {
                                for (int i = 0; i < rows; i++)
                                {
                                    if (matrix[i].Count > position)
                                    {
                                        if (matrix[i][position] >= 0)
                                        {
                                            matrix[i].RemoveAt(position);
                                            //i--;
                                        }
                                    }
                                }
                            }

                            break;

                        case "negative":

                            //remove negative numbers
                            if (place == "row")
                            {
                                for (int i = 0; i < matrix[position].Count; i++)
                                {
                                    if (matrix[position][i] < 0)
                                    {
                                        matrix[position].RemoveAt(i);
                                        i--;
                                    }
                                }
                            }

                            else // place == col
                            {
                                for (int i = 0; i < rows; i++)
                                {
                                    if (matrix[i].Count > position)
                                    {
                                        if (matrix[i][position] < 0)
                                        {
                                            matrix[i].RemoveAt(position);
                                            //i--;
                                        }
                                    }
                                }
                            }

                            break;

                        case "odd":

                            //remove odd numbers

                            if (place == "row")
                            {
                                for (int i = 0; i < matrix[position].Count; i++)
                                {
                                    if (matrix[position][i] % 2 != 0)
                                    {
                                        matrix[position].RemoveAt(i);
                                        i--;
                                    }
                                }
                            }

                            else // place == col
                            {
                                for (int i = 0; i < rows; i++)
                                {
                                    if (matrix[i].Count > position)
                                    {
                                        if (matrix[i][position] % 2 != 0)
                                        {
                                            matrix[i].RemoveAt(position);
                                            //i--;
                                        }
                                    }
                                }
                            }

                            break;

                        case "even":

                            //remove even numbers

                            if (place == "row")
                            {
                                for (int i = 0; i < matrix[position].Count; i++)
                                {
                                    if (matrix[position][i] % 2 == 0)
                                    {
                                        matrix[position].RemoveAt(i);
                                        i--;
                                    }
                                }
                            }

                            else // place == col
                            {
                                for (int i = 0; i < rows; i++)
                                {
                                    if (matrix[i].Count > position)
                                    {
                                        if (matrix[i][position] % 2 == 0)
                                        {
                                            matrix[i].RemoveAt(position);
                                            //i--;
                                        }
                                    }
                                }
                            }

                            break;

                        default:
                            break;
                    }

                    break;

                case "swap":

                    int firstRow = int.Parse(commandParams[1]);
                    int secondRow = int.Parse(commandParams[2]);

                    List<int> temp = new List<int>(matrix[firstRow]);
                    matrix[firstRow] = matrix[secondRow];
                    matrix[secondRow] = temp;

                    break;

                case "insert":

                    int row = int.Parse(commandParams[1]);
                    int element = int.Parse(commandParams[2]);

                    matrix[row].Insert(0, element);

                    break;

                default:
                    break;
            }
            commandParams = Console.ReadLine().Split(' ');
        }

        for (int i = 0; i < matrix.Count; i++)
        {
            for (int j = 0; j < matrix[i].Count; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}