namespace WebApplication3.Models
{
    public class BankBranch
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string BranchManager { get; set; }
        public int EmployeeCount { get; set; }
        public string LocationURL { get; set; }

        public List<Employee> Employees { get; set; } = new();

    }

    public class BranchData
    {
        public static List<BankBranch> Branches = new List<BankBranch>
    {
        new BankBranch { Id = 1, LocationName = "Al-Zara Branch", BranchManager = "Yousef Alhumaidan", EmployeeCount = 17, LocationURL = "https://maps.app.goo.gl/cE1LK3qpTS9gXWyW6" },
        new BankBranch { Id = 2, LocationName = "Avenues Mall Branch", BranchManager = "Loura Alyousef", EmployeeCount = 8, LocationURL = "https://maps.app.goo.gl/VURHddkaxJA4Vjhv8" }
        };
    }
}
