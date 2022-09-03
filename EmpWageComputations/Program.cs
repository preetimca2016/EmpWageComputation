using System;

namespace EmpWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
			EmpWageBuilder Realiance = new EmpWageBuilder("Realiance", 200, 150, 50);
			Realiance.ComputeWage();
			Console.WriteLine(Realiance.ToString());
			EmpWageBuilder TATA = new EmpWageBuilder("TATA", 22, 20, 990);
			TATA.ComputeWage();
			Console.WriteLine(TATA.ToString());
			
		}
    }
}