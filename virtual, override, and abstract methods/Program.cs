using System;
using System.Collections.Generic;

public class ayayayayayayayayaya
{
    public abstract class Expression
    {
        public abstract double Evaluate(Dictionary<string, object> vars);
    }

    public class Constant : Expression
    {
        double _value;

        // constructor for Constant
        public Constant(double value)
        {
            this._value = value;
        }

        // overriding abstract method defined in parent abstract class
        public override double Evaluate(Dictionary<string, object> vars)
        {
            return _value;
        }
    }

    public class VariableReference : Expression
    {
        // declaring the class fields
        string _name;

        // class constructor
        public VariableReference(string name)
        {
            _name = name;
        }

        public override double Evaluate(Dictionary<string, object> vars)
        {
            object value = vars[_name] ?? throw new Exception($"Unknown variable: {_name}");
            return Convert.ToDouble(value);
        }
    }

    public class Operation : Expression
    {
        // initialising class fields
        private Expression _left;
        private char _op;
        private Expression _right;

        // constructor
        public Operation(Expression left, char op, Expression right)
        {
            _left = left;
            _op = op;
            _right = right;
        }

        // overriding the abstract method
        public override double Evaluate(Dictionary<string, object> vars)
        {
            double x = _left.Evaluate(vars);
            double y = _right.Evaluate(vars);
            switch (_op)
            {
                case '+': return x + y;
                case '-': return x - y;
                case '*': return x * y;
                case '/': return x / y;

                default: throw new Exception("Unknown operator");
            }
        }
    }


    static void Main(string[] args)
    {
        Expression e = new Operation(
                new VariableReference("x"),
                '*',
                new Operation(
                    new VariableReference("y"),
                    '+',
                    new Constant(2)
                )
            );

        Dictionary<string, object> vars = new Dictionary<string, object>();
        vars["x"] = 3;
        vars["y"] = 5;
        Console.WriteLine(e.Evaluate(vars));

        vars["x"] = 1.5;
        vars["y"] = 9;
        Console.WriteLine(e.Evaluate(vars));

    }
}
