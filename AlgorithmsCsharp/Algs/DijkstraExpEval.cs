using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Algs
{
    class DijkstraExpEval
    {
        public static double Evaluate(string expression)
        {
            var s = expression.Split(' ');
            Stack<string> ops = new Stack<string>();
            Stack<Double> vals = new Stack<double>();
            foreach (var input in s)
            {
                if (input.Equals("(")) { }
                else if (input.Equals("+")) ops.Push(input);
                else if (input.Equals("*")) ops.Push(input);
                else if (input.Equals("-")) ops.Push(input);
                else if (input.Equals("/")) ops.Push(input);
                else if (input.Equals(")"))
                {
                    string op = ops.Pop();
                    if (op.Equals("+")) vals.Push(vals.Pop() + vals.Pop());
                    else if (op.Equals("-")) vals.Push(vals.Pop() - vals.Pop());
                    else if (op.Equals("*")) vals.Push(vals.Pop() * vals.Pop());
                    else if (op.Equals("/")) vals.Push(vals.Pop() / vals.Pop());
                }
                else vals.Push(Double.Parse(input));
            }
            return vals.Pop();
        }
    }
}
