namespace TestingTask1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary{ get; set; }
        public string Gender { get; set; }
       
        
    }   
    public class Program
    {
        public string Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Username or password are empty";
            }
            else if(username == "Admin" && password == "Admin")
            {
                return "Login successful , Welcome Admin";
            }
            else
            {
                return "Login failed";
            }

        }
        public List<Employee> AllUsers() 
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee
             {
              Id  = 1  ,
                Name = "Mawlana",
                Gender = "Male" ,
                Salary = 1000
            });
            li.Add(new Employee
            {
                Id = 2,
                Name = "Gedo",
                Gender = "Male",
                Salary = 1000
            });
            li.Add(new Employee
            {
                Id = 3,
                Name = "Nagah",
                Gender = "Male",
                Salary = 1000
            });
            li.Add(new Employee
            {
                Id = 4,
                Name = "Matteo",
                Gender = "Male",
                Salary = 1000
            });
            return li;
        }

        public List<Employee> GetEmployees(int id) 
        {
            List<Employee> li2 = new List<Employee>();
            Program p = new Program();
            var li = p.AllUsers();
            foreach (var item in li)
            {
                if (item.Id == id)
                {
                    li2.Add(item);
                }
              
            } 
            return li2;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");
        }
    }
}
