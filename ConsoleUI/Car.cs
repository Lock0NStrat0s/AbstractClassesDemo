using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI;

public class Car : Vehicle
{
    public bool HasTrunk { get; set; }
    public override void DriveAbstract()
    {
        Console.WriteLine("The wittle car is driving abstractly.");
    }
}
