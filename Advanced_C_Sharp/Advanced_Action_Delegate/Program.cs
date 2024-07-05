namespace Advanced_Action_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiple_Parameters.ActionMethod();

            Annonymous_Method.ActionMethod();

            Modify_Variables.ActionMethod();

            Combining_Delegates.ActionMethod();

            Combining_Delegates.ActionMethod2();

            Passing_Action_As_Parameter.ActionMethod();

            Action_In_Collection.ActionMethod();

            Action_In_Dictionary.ActionMethod();

            Console.ReadLine();
        }
    }
}
