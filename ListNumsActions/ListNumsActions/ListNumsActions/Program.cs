﻿using System;
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
                    case "ins":
                        //TODO
                        break;

                    case "del":
                        int itemToRemove = int.Parse(cmd[1]);
                        nums.Remove(itemToRemove);                   
                        break;

                    case "contains":
                        var element = int.Parse(cmd[1]);
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
                        int index = 0;
                        index = int.Parse(cmd[1]);
                        nums.RemoveAt(index);
                        break;
                        
                    //TODO
                    case "print":
                    Console.WriteLine(string.Join(" ", nums));
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
