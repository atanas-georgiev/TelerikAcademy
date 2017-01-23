//Problem 7.* Arithmetical expressions

//Write a program that calculates the value of given arithmetical expression.
//The expression can contain the following elements only:
//Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//Arithmetic operators: +, -, *, / (standard priorities)
//Mathematical functions: ln(x), sqrt(x), pow(x,y)
//Brackets (for changing the default priorities): (, )

using System;
using System.Collections.Generic;

namespace Problem07ArithmeticalExpressions
{
    enum OperatorType
    {
        opNumber,
        opFunctionToken,
        opArgumentSeparator,
        opOperator,
        opLeftParenthesis,
        opRightParenthesis
    }

    struct Operator
    {
        public string str;
        public int precedence;
        public string associativity;
        public double value;
        public OperatorType opType;

        public Operator(string s, int p, string a, double v, OperatorType o)
        {
            str = s;
            precedence = p;
            associativity = a;
            value = v;
            opType = o;
        }
    }

    class ArithmeticalExpressions
    {
        static Operator[] operators =
        {
            new Operator ("+", 2, "Left",    0, OperatorType.opOperator), 
            new Operator ("-", 2, "Left",    0, OperatorType.opOperator),
            new Operator ("*", 3, "Left",    0, OperatorType.opOperator),
            new Operator ("/", 3, "Left",    0, OperatorType.opOperator),
            new Operator ("ln", 4, "Left",   0, OperatorType.opFunctionToken),
            new Operator ("sqrt", 4, "Left", 0, OperatorType.opFunctionToken),
            new Operator ("pow", 4, "Left",  0, OperatorType.opFunctionToken),
            new Operator ("(", 0, "Left",    0, OperatorType.opLeftParenthesis),
            new Operator (")", 0, "Left",    0, OperatorType.opRightParenthesis),
            new Operator (",", 0, "Left",    0, OperatorType.opArgumentSeparator)
        };

        static Operator GetOperator(string str)
        {
            for (int i = 0; i < operators.Length; i++)
            {
                if (str.StartsWith(operators[i].str))
                {
                    return operators[i];
                }
            }

            return operators[0];
        }

        static List<Operator> StringToRPN(string input)
        {
            Stack<Operator> stackOp = new Stack<Operator>();
            List<Operator> elements = new List<Operator>();
            Operator el = new Operator();
            Operator op = new Operator();

            // Adapt the input string
            input = input.Replace(" ", "");
            input = input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                if ((Char.IsDigit(input[i]) == true) ||
                    (op.opType == OperatorType.opArgumentSeparator) && input[i] == '-')
                {
                    // Digit found, parse it to elements array
                    string str = string.Empty;
                    do
                    {
                        str += input[i].ToString();
                        i++;

                        if (i == input.Length) break;
                    }

                    while (Char.IsDigit(input[i]) || input[i] == '.');
                    i--;

                    el.opType = OperatorType.opNumber;
                    el.value = double.Parse(str);
                    elements.Add(el);
                }
                else
                {
                    // Operator found, search for its type
                    op = GetOperator(input.Remove(0, i));
                    i += op.str.Length - 1;

                    switch (op.opType)
                    {
                        case OperatorType.opFunctionToken:
                        case OperatorType.opLeftParenthesis:
                            // If the token is a left parenthesis, then push it onto the stack.
                            stackOp.Push(op);
                            break;

                        case OperatorType.opArgumentSeparator:
                            // If the token is a function argument separator (e.g., a comma):
                            // Until the token at the top of the stack is a left parenthesis, pop operators off the stack onto the output queue.                             
                            do
                            {
                                el = stackOp.Pop();
                                if (el.opType != OperatorType.opLeftParenthesis)
                                {
                                    elements.Add(el);
                                }
                            } while (stackOp.Count != 0 && el.opType != OperatorType.opLeftParenthesis);
                            break;

                        
                        case OperatorType.opOperator:
                            // If the token is an operator, o1, then:
                            // while there is an operator token, o2, at the top of the stack, and either
                            // o1 is left-associative and its precedence is less than or equal to that of o2, or
                            // o1 if right associative, and has precedence less than that of o2,
                            // then pop o2 off the stack, onto the output queue;
                            // push o1 onto the stack.            
          
                            Stack<Operator> tempStack = new Stack<Operator>();
                            int tempDeepLevel = 0;

                            if (stackOp.Count == 0)
                            {
                                stackOp.Push(op);
                                break;                                
                            }
                            else
                            {
                                el = stackOp.Pop();
                            }                                                      

                            if (el.opType == OperatorType.opFunctionToken)
                            {
                                elements.Add(el);

                                if (stackOp.Count == 0)
                                {
                                    stackOp.Push(op);
                                    break;
                                }
                                else
                                {
                                    el = stackOp.Pop();
                                }  
                            }

                            if (op.associativity == "Left" && op.precedence <= el.precedence ||
                                op.associativity == "Right" && op.precedence > el.precedence)
                            {
                                elements.Add(el);
                                stackOp.Push(op);
                            }
                            else
                            {
                                stackOp.Push(el);
                                stackOp.Push(op);
                            }                            
                            break;

                        case OperatorType.opRightParenthesis:
                            //If the token is a right parenthesis:
                            //Until the token at the top of the stack is a left parenthesis, pop operators off the stack onto the output queue.
                            //Pop the left parenthesis from the stack, but not onto the output queue.
                            //If the token at the top of the stack is a function token, pop it onto the output queue.
                            //If the stack runs out without finding a left parenthesis, then there are mismatched parentheses.
                            do
                            {
                                el = stackOp.Pop();
                                if (el.opType != OperatorType.opLeftParenthesis)
                                {
                                    elements.Add(el);
                                }
                            } while (stackOp.Count != 0 && el.opType != OperatorType.opLeftParenthesis);

                            break;
                        default:
                            break;
                    }
                }
            }

            // Transfer all remaining elements from stack to the elements result
            while (stackOp.Count != 0)
            {
                el = stackOp.Pop();
                if (el.opType != OperatorType.opLeftParenthesis)
                {
                    elements.Add(el);
                }
            }

            return elements;
        }

        static double CalculateRPN(List<Operator> input)
        {
            Stack<Operator> elements = new Stack<Operator>();
            Operator a, b;
            Operator res = new Operator();

            for (int i = 0; i < input.Count; i++)
            {
                switch (input[i].opType)
                {
                    case OperatorType.opNumber:
                        {
                            elements.Push(input[i]);
                        }
                        break;
                    case OperatorType.opOperator:
                        switch (input[i].str)
                        {
                            case "+":
                                a = elements.Pop();
                                b = elements.Pop();
                                res.value = b.value + a.value;
                                res.opType = OperatorType.opNumber;
                                elements.Push(res);
                                break;
                            case "-":
                                a = elements.Pop();
                                b = elements.Pop();
                                res.value = b.value - a.value;
                                res.opType = OperatorType.opNumber;
                                elements.Push(res);
                                break;
                            case "/":
                                a = elements.Pop();
                                b = elements.Pop();
                                res.value = b.value / a.value;
                                res.opType = OperatorType.opNumber;
                                elements.Push(res);
                                break;
                            case "*":
                                a = elements.Pop();
                                b = elements.Pop();
                                res.value = b.value * a.value;
                                res.opType = OperatorType.opNumber;
                                elements.Push(res);
                                break;
                            default:
                                break;
                        }
                        break;
                    case OperatorType.opFunctionToken:
                        switch (input[i].str)
                        {
                            case "ln":
                                a = elements.Pop();
                                res.value = Math.Log(a.value);
                                res.opType = OperatorType.opNumber;
                                elements.Push(res);
                                break;
                            case "sqrt":
                                a = elements.Pop();
                                res.value = Math.Sqrt(a.value);
                                res.opType = OperatorType.opNumber;
                                elements.Push(res);
                                break;
                            case "pow":
                                a = elements.Pop();
                                b = elements.Pop();
                                res.value = Math.Pow(b.value, a.value);
                                res.opType = OperatorType.opNumber;
                                elements.Push(res);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }

            res = elements.Pop();

            return res.value;
        }

        static void Main()
        {
            Console.WriteLine("Enter arithmetical expression: ");
            List<Operator> elements = StringToRPN(Console.ReadLine());

            Console.Write("Exprtession in RPN: ");
            foreach (var el in elements)
            {
                if (el.opType == OperatorType.opNumber)
                {
                    Console.Write(el.value + " ");
                }
                else
                {
                    Console.Write(el.str + " ");
                }
            }

            Console.WriteLine();
            Console.Write("Final result: ");
            Console.WriteLine(CalculateRPN(elements));
        }
    }
}
