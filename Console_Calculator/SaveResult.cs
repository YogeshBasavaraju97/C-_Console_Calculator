using System;
namespace Calculator
{
	public class SaveResult
	{
		public void results(double num1, double num2, double result,string calculator)
		{
            //
            using FileStream filestream = new FileStream($"{calculator}.txt", FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(filestream))
            {
                writer.WriteLine(DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss"));
                writer.WriteLine($"num1: {num1}");
                writer.WriteLine($"num2: {num2}");
                writer.WriteLine("Your result: {0:0.##}\n", result);
                writer.WriteLine("--------------------------");
            }
        }

        //Metod overloading
        public void results(string expression, string result, string calculator)
        {
            string fileName = $"/Users/yogeshbasavaraju/Projects/Console_Calculator/Console_Calculator/{calculator}.txt";
            using FileStream filestream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(filestream))
            {
                writer.WriteLine(DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss"));
                writer.WriteLine($"Given Expression: {expression}");
                writer.WriteLine($"Your result:{result}");
                writer.WriteLine("--------------------------");
            }

        }

    }
}

