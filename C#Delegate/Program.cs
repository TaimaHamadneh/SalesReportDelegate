using C_Delegate;

var emps = new Employee[]
{
new Employee{ Id = 1, Name = "Taima H", Gender = "F", TotalSales = 65000m},
new Employee { Id = 2, Name = "Reem S", Gender = "F", TotalSales = 50000m },
new Employee { Id = 3, Name = "Suzan B", Gender = "F", TotalSales = 65000m },
new Employee { Id = 4, Name = "Sara C", Gender = "F", TotalSales = 40000m },
new Employee { Id = 5, Name = "Saleh A", Gender = "M", TotalSales = 42000m },
new Employee { Id = 6, Name = "Rateb C", Gender = "M", TotalSales = 30000m },
new Employee { Id = 7, Name = "Abeer I", Gender = "F", TotalSales = 16000m },
new Employee { Id = 8, Name = "Marwan M", Gender = "M", TotalSales = 15000m }
};
 
var report = new Report();
report.ProcessEmployee(emps, "Employees with Sales $60,000+",(Employee e) => e.TotalSales > 60000m );
report.ProcessEmployee(emps, "Employees with Sales Between $30,000 and $60,000",(Employee e) => 30000 <= e.TotalSales && e.TotalSales < 60000m);
report.ProcessEmployee(emps, "Employees with Sales Less Than $30,000",(Employee e) => e.TotalSales < 30000m);
 