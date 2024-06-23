// Debugging Process - Writing the console to file  - OneAnanda

FileStream fs = new FileStream("Output.txt", FileMode.Create);
StreamWriter sw = new StreamWriter(fs);

Console.SetOut(sw);

Console.WriteLine("Hello, World!");


sw.Close();


// Output 

// The "Hello, World!" is written to the file "Output.txt"
