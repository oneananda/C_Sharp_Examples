namespace Advanced_Func_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqFunc.GetEvenNumbers();

            CombiningMultipleFunc.AddAndThenSquare();

            CombiningMultipleFunc.SquareAndThenSquare();

            FuncHigherOrderFunction.FuncAsParam();

            FuncLazyEvaluation.ProcessLazy();

            ChainingFuncDelegate.ProcessChaining();

            Console.ReadLine();
        }
    }
}
