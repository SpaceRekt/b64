using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace b64
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                if(args[0] == "e" || args[0] == "enc" || args[0] == "encode")
                {
                    try
                    {
                        string res = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Join("", args).Substring(args[0].Length)));
                        Clipboard.SetText(res);
                        Console.WriteLine($"Set to clipboard! [{res}]");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("ERROR: " + e.Message);
                    }
                }
                if(args[0] == "d")
                {
                    try
                    {
                        string res = Encoding.UTF8.GetString(Convert.FromBase64String(string.Join("", args).Substring(args[0].Length)));
                        Clipboard.SetText(res);
                        Console.WriteLine($"Set to clipboard! [{res}]");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("ERROR: " + e.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: Correct Syntax is: b64 [e/d] [string]");
            }
        }
    }
}
