using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; }
    public override void DriveAbstract()
    {
        Console.WriteLine("Motorcycle is driving via abstraction.");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle is driving virtually.");
    }
}
