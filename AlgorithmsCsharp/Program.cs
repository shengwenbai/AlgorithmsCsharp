using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AlgorithmsCsharp.Algs;
using AlgorithmsCsharp.DataStructures;

namespace AlgorithmsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expression Evaluation.
            string ss = Console.ReadLine();
            Console.WriteLine(DijkstraExpEval.Evaluate(ss));
        }
    }
}
