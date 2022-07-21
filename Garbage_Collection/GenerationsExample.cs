// C# Garbage collection generations with code examples
// This code is explained in the following YouTube channel video
// https://youtu.be/yaX_WMn5WdM
class GC_Example
{
    static void Main()
    {        
        GC_Example gC = new GC_Example();

        gC.CreateGarbage();

        // Introduced in step 2
        GC.Collect();

        // Introduced in step 3
        GC.Collect(2);

        Console.WriteLine(
            "gC objects is in the Generation : {0}"
            , GC.GetGeneration(gC));

        Console.ReadLine();
    }

    void CreateGarbage()
    {
        StringWriter sw;
        for (int i = 0; i < 100; i++)
        {
            sw = new StringWriter();
        }
    }
}
