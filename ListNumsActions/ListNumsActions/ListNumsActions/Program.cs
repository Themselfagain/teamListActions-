using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                

                switch (command)
                {
                    case "ins": var index = int.Parse(cmd[1]);
                        var element = int.Parse(cmd[2]);
                        nums.Insert(index, element);
                        break;
                    case "del":
                        int itemToRemove = int.Parse(cmd[1]);
                        nums.Remove(itemToRemove);                   
                        break;
                    case "contains":
                        element = int.Parse(cmd[1]);
                        if (nums.Contains(element))
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                        break;
                    case "remove":
                        index = int.Parse(cmd[1]);
                        nums.RemoveAt(index);
                        break;                        
                    case "print":
                    Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "add":
                        break;

                    case "large":
                        int chislo = int.Parse(cmd[1]);
                        var numsResult = nums.Where(x=>x>chislo).ToList();
                        Console.WriteLine(string.Join(" ", numsResult));
                        break;
                       
                    case "countl":
                        break;
                    case "cut":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
