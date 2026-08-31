using LinqPractice;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;


//Use First() when you want the first matching record and you're confident that at least one record exists.
var employee = StaticData.Employees
    .First(e => e.DepartmentId == 1);

Trace.WriteLine("*******Output******\n\n\n");
Trace.WriteLine(employee?.Name);
Trace.WriteLine("\n\n\n");