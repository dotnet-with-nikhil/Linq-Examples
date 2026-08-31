namespace LinqPractice;

public static class StaticData
{
    // =========================================================
    // DEPARTMENTS
    // =========================================================

    public static List<Department> Departments = new()
    {
        new Department { Id = 1, Name = "IT", Location = "Pune" },
        new Department { Id = 2, Name = "HR", Location = "Mumbai" },
        new Department { Id = 3, Name = "Finance", Location = "Bangalore" },
        new Department { Id = 4, Name = "Sales", Location = "Delhi" },
        new Department { Id = 5, Name = "Marketing", Location = "Pune" }
    };


    // =========================================================
    // EMPLOYEES
    // =========================================================

    public static List<Employee> Employees = new()
    {
        new Employee
        {
            Id = 1,
            Name = "Rahul",
            Age = 28,
            Salary = 75000,
            DepartmentId = 1,
            City = "Pune",
            IsActive = true,
            JoiningDate = new DateTime(2021, 5, 10)
        },

        new Employee
        {
            Id = 2,
            Name = "Priya",
            Age = 32,
            Salary = 95000,
            DepartmentId = 1,
            City = "Mumbai",
            IsActive = true,
            JoiningDate = new DateTime(2019, 3, 15)
        },

        new Employee
        {
            Id = 3,
            Name = "Amit",
            Age = 26,
            Salary = 60000,
            DepartmentId = 2,
            City = "Pune",
            IsActive = true,
            JoiningDate = new DateTime(2022, 7, 20)
        },

        new Employee
        {
            Id = 4,
            Name = "Sneha",
            Age = 35,
            Salary = 110000,
            DepartmentId = 3,
            City = "Bangalore",
            IsActive = true,
            JoiningDate = new DateTime(2018, 1, 10)
        },

        new Employee
        {
            Id = 5,
            Name = "Vikas",
            Age = 30,
            Salary = 85000,
            DepartmentId = 4,
            City = "Delhi",
            IsActive = true,
            JoiningDate = new DateTime(2020, 11, 5)
        },

        new Employee
        {
            Id = 6,
            Name = "Neha",
            Age = 29,
            Salary = 78000,
            DepartmentId = 1,
            City = "Pune",
            IsActive = false,
            JoiningDate = new DateTime(2021, 8, 12)
        },

        new Employee
        {
            Id = 7,
            Name = "Rohit",
            Age = 40,
            Salary = 125000,
            DepartmentId = 3,
            City = "Bangalore",
            IsActive = true,
            JoiningDate = new DateTime(2016, 6, 1)
        },

        new Employee
        {
            Id = 8,
            Name = "Pooja",
            Age = 27,
            Salary = 65000,
            DepartmentId = 5,
            City = "Pune",
            IsActive = true,
            JoiningDate = new DateTime(2023, 2, 18)
        },

        new Employee
        {
            Id = 9,
            Name = "Karan",
            Age = 33,
            Salary = 90000,
            DepartmentId = 4,
            City = "Delhi",
            IsActive = true,
            JoiningDate = new DateTime(2019, 9, 25)
        },

        new Employee
        {
            Id = 10,
            Name = "Anjali",
            Age = 31,
            Salary = 88000,
            DepartmentId = 5,
            City = "Mumbai",
            IsActive = false,
            JoiningDate = new DateTime(2020, 4, 10)
        },

        new Employee
        {
            Id = 11,
            Name = "Suresh",
            Age = 38,
            Salary = 115000,
            DepartmentId = 1,
            City = "Pune",
            IsActive = true,
            JoiningDate = new DateTime(2017, 10, 2)
        },

        new Employee
        {
            Id = 12,
            Name = "Meena",
            Age = 25,
            Salary = 55000,
            DepartmentId = 2,
            City = "Mumbai",
            IsActive = true,
            JoiningDate = new DateTime(2024, 1, 8)
        }
    };


    // =========================================================
    // CUSTOMERS
    // =========================================================

    public static List<Customer> Customers = new()
    {
        new Customer
        {
            Id = 1,
            Name = "John",
            Email = "john@gmail.com",
            City = "Pune",
            Country = "India",
            IsActive = true
        },

        new Customer
        {
            Id = 2,
            Name = "Alice",
            Email = "alice@gmail.com",
            City = "Mumbai",
            Country = "India",
            IsActive = true
        },

        new Customer
        {
            Id = 3,
            Name = "Bob",
            Email = "bob@gmail.com",
            City = "Delhi",
            Country = "India",
            IsActive = true
        },

        new Customer
        {
            Id = 4,
            Name = "David",
            Email = "david@gmail.com",
            City = "Bangalore",
            Country = "India",
            IsActive = false
        },

        new Customer
        {
            Id = 5,
            Name = "Emma",
            Email = "emma@gmail.com",
            City = "Pune",
            Country = "India",
            IsActive = true
        },

        new Customer
        {
            Id = 6,
            Name = "Michael",
            Email = "michael@gmail.com",
            City = "Chennai",
            Country = "India",
            IsActive = true
        },

        new Customer
        {
            Id = 7,
            Name = "Sophia",
            Email = "sophia@gmail.com",
            City = "Mumbai",
            Country = "India",
            IsActive = true
        },

        new Customer
        {
            Id = 8,
            Name = "James",
            Email = "james@gmail.com",
            City = "Delhi",
            Country = "India",
            IsActive = false
        }
    };


    // =========================================================
    // CATEGORIES
    // =========================================================

    public static List<Category> Categories = new()
    {
        new Category { Id = 1, Name = "Electronics" },
        new Category { Id = 2, Name = "Mobile" },
        new Category { Id = 3, Name = "Laptop" },
        new Category { Id = 4, Name = "Accessories" },
        new Category { Id = 5, Name = "Home Appliances" }
    };


    // =========================================================
    // PRODUCTS
    // =========================================================

    public static List<Product> Products = new()
    {
        new Product
        {
            Id = 1,
            Name = "iPhone 15",
            CategoryId = 2,
            Price = 70000,
            Stock = 25,
            IsActive = true
        },

        new Product
        {
            Id = 2,
            Name = "Samsung Galaxy S24",
            CategoryId = 2,
            Price = 65000,
            Stock = 30,
            IsActive = true
        },

        new Product
        {
            Id = 3,
            Name = "Dell Inspiron",
            CategoryId = 3,
            Price = 75000,
            Stock = 15,
            IsActive = true
        },

        new Product
        {
            Id = 4,
            Name = "HP Pavilion",
            CategoryId = 3,
            Price = 68000,
            Stock = 20,
            IsActive = true
        },

        new Product
        {
            Id = 5,
            Name = "MacBook Air",
            CategoryId = 3,
            Price = 110000,
            Stock = 10,
            IsActive = true
        },

        new Product
        {
            Id = 6,
            Name = "AirPods",
            CategoryId = 4,
            Price = 18000,
            Stock = 50,
            IsActive = true
        },

        new Product
        {
            Id = 7,
            Name = "Wireless Mouse",
            CategoryId = 4,
            Price = 1500,
            Stock = 100,
            IsActive = true
        },

        new Product
        {
            Id = 8,
            Name = "Keyboard",
            CategoryId = 4,
            Price = 2500,
            Stock = 75,
            IsActive = true
        },

        new Product
        {
            Id = 9,
            Name = "Washing Machine",
            CategoryId = 5,
            Price = 45000,
            Stock = 12,
            IsActive = true
        },

        new Product
        {
            Id = 10,
            Name = "Refrigerator",
            CategoryId = 5,
            Price = 55000,
            Stock = 8,
            IsActive = false
        }
    };


    // =========================================================
    // ORDERS
    // =========================================================

    public static List<Order> Orders = new()
    {
        new Order
        {
            Id = 1,
            CustomerId = 1,
            OrderDate = new DateTime(2025, 1, 10),
            Status = "Completed",
            TotalAmount = 71500
        },

        new Order
        {
            Id = 2,
            CustomerId = 2,
            OrderDate = new DateTime(2025, 1, 15),
            Status = "Completed",
            TotalAmount = 65000
        },

        new Order
        {
            Id = 3,
            CustomerId = 1,
            OrderDate = new DateTime(2025, 2, 5),
            Status = "Pending",
            TotalAmount = 75000
        },

        new Order
        {
            Id = 4,
            CustomerId = 3,
            OrderDate = new DateTime(2025, 2, 12),
            Status = "Completed",
            TotalAmount = 18000
        },

        new Order
        {
            Id = 5,
            CustomerId = 4,
            OrderDate = new DateTime(2025, 3, 1),
            Status = "Cancelled",
            TotalAmount = 55000
        },

        new Order
        {
            Id = 6,
            CustomerId = 5,
            OrderDate = new DateTime(2025, 3, 15),
            Status = "Completed",
            TotalAmount = 110000
        },

        new Order
        {
            Id = 7,
            CustomerId = 6,
            OrderDate = new DateTime(2025, 4, 2),
            Status = "Pending",
            TotalAmount = 45000
        },

        new Order
        {
            Id = 8,
            CustomerId = 7,
            OrderDate = new DateTime(2025, 4, 10),
            Status = "Completed",
            TotalAmount = 1500
        },

        new Order
        {
            Id = 9,
            CustomerId = 2,
            OrderDate = new DateTime(2025, 5, 5),
            Status = "Completed",
            TotalAmount = 2500
        },

        new Order
        {
            Id = 10,
            CustomerId = 8,
            OrderDate = new DateTime(2025, 5, 20),
            Status = "Pending",
            TotalAmount = 68000
        },

        new Order
        {
            Id = 11,
            CustomerId = 5,
            OrderDate = new DateTime(2025, 6, 1),
            Status = "Completed",
            TotalAmount = 18000
        },

        new Order
        {
            Id = 12,
            CustomerId = 3,
            OrderDate = new DateTime(2025, 6, 15),
            Status = "Completed",
            TotalAmount = 70000
        }
    };


    // =========================================================
    // ORDER ITEMS
    // =========================================================

    public static List<OrderItem> OrderItems = new()
    {
        new OrderItem { Id = 1, OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 70000 },
        new OrderItem { Id = 2, OrderId = 1, ProductId = 7, Quantity = 1, UnitPrice = 1500 },

        new OrderItem { Id = 3, OrderId = 2, ProductId = 2, Quantity = 1, UnitPrice = 65000 },

        new OrderItem { Id = 4, OrderId = 3, ProductId = 3, Quantity = 1, UnitPrice = 75000 },

        new OrderItem { Id = 5, OrderId = 4, ProductId = 6, Quantity = 1, UnitPrice = 18000 },

        new OrderItem { Id = 6, OrderId = 5, ProductId = 10, Quantity = 1, UnitPrice = 55000 },

        new OrderItem { Id = 7, OrderId = 6, ProductId = 5, Quantity = 1, UnitPrice = 110000 },

        new OrderItem { Id = 8, OrderId = 7, ProductId = 9, Quantity = 1, UnitPrice = 45000 },

        new OrderItem { Id = 9, OrderId = 8, ProductId = 7, Quantity = 1, UnitPrice = 1500 },

        new OrderItem { Id = 10, OrderId = 9, ProductId = 8, Quantity = 1, UnitPrice = 2500 },

        new OrderItem { Id = 11, OrderId = 10, ProductId = 4, Quantity = 1, UnitPrice = 68000 },

        new OrderItem { Id = 12, OrderId = 11, ProductId = 6, Quantity = 1, UnitPrice = 18000 },

        new OrderItem { Id = 13, OrderId = 12, ProductId = 1, Quantity = 1, UnitPrice = 70000 }
    };


    // =========================================================
    // PROJECTS
    // =========================================================

    public static List<Project> Projects = new()
    {
        new Project
        {
            Id = 1,
            Name = "E-Commerce",
            DepartmentId = 1,
            Budget = 500000,
            Status = "Completed"
        },

        new Project
        {
            Id = 2,
            Name = "HR Portal",
            DepartmentId = 2,
            Budget = 200000,
            Status = "In Progress"
        },

        new Project
        {
            Id = 3,
            Name = "Financial Dashboard",
            DepartmentId = 3,
            Budget = 350000,
            Status = "In Progress"
        },

        new Project
        {
            Id = 4,
            Name = "Sales CRM",
            DepartmentId = 4,
            Budget = 450000,
            Status = "Completed"
        },

        new Project
        {
            Id = 5,
            Name = "Marketing Automation",
            DepartmentId = 5,
            Budget = 300000,
            Status = "Planning"
        }
    };
}


// =============================================================
// MODELS
// =============================================================

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public int DepartmentId { get; set; }
    public string City { get; set; } = "";
    public bool IsActive { get; set; }
    public DateTime JoiningDate { get; set; }
}


public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Location { get; set; } = "";
}


public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string City { get; set; } = "";
    public string Country { get; set; } = "";
    public bool IsActive { get; set; }
}


public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public bool IsActive { get; set; }
}


public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; } = "";
    public decimal TotalAmount { get; set; }
}


public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}


public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int DepartmentId { get; set; }
    public decimal Budget { get; set; }
    public string Status { get; set; } = "";
}