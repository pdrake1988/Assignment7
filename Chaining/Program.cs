// See https://aka.ms/new-console-template for more information
using Chaining;
using static Chaining.Operation;

MathOp add,
    subtract,
    multiply,
    divide;

int num = MathOperations.GetNum();

add = new MathOp(MathOperations.Add);

subtract = new MathOp(MathOperations.Subtract);

multiply = new MathOp(MathOperations.Multiply);

divide = new MathOp(MathOperations.Divide);
