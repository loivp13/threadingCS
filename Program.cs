﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello World 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World 2");
            Console.WriteLine("Hello World 3");
            Console.WriteLine("Hello World 4");*/

  /*          new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

             new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

             new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

             new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();*/


            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Thread.Sleep(1000);
                taskCompletionSource.TrySetResult(true);
            });
            Console.WriteLine($"Thread number: {thread.ManagedThreadId}");
            thread.Start();
            var test = taskCompletionSource.Task.Result;
            Console.ReadLine();
        }
    }
}
