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
                    case "ins":
                        //TODO
                        break;
                    case "del":
                        //TODO
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
                        //TODO
                        break;
                    //TODO

                    default:
                        break;
                }
            }
        }
    }
}
