namespace Customers
{

    class Customer{
        public string? Name {get; set;}
        public int Age {get; set;}
        public string? Email {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3]; 
            customers[0] = new Customer { Name = "John Doe", Age = 30, Email = "john.doe@example.com" };
            customers[1] = new Customer { Name = "Jane Doe", Age = 25, Email = "jane.doe@example.com" };
            customers[2] = new Customer { Name = "Jim Smith", Age = 35, Email = null };


        foreach (Customer customer in customers){
            //Null-conditional operator that first checks whether the Email property of the customer object is null. 
            //If it is, the entire expression evaluates to null. 
            //If it's not null, the ToLower() method is called on the email address to convert it to lowercase. 
            //If the Email property is null, the expression evaluates to the string "Email not available".
            Console.WriteLine($"Name: {customer.Name} Age: {customer.Age}, Email: {customer.Email?.ToLower() ?? "Email not available"}"); 
        
            switch(customer.Age){
                case int age when age < 30: 
                Console.WriteLine("the customer is under 30"); 
                break; 
                case int age when age >= 30 && age < 40: 
                Console.WriteLine("the customer is between 30 and 40"); 
                break; 
                default: 
                Console.WriteLine("the customer is over 40");
                break; 
            }
        }
    }
}
}
