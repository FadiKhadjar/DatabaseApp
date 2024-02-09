using DatabaseApp;
using DatabaseApp.Contexts;
using DatabaseApp.Repositories;
using DatabaseApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databaser\DatabaseApp\DatabaseApp\Data\database.mdf;Integrated Security=True;Connect Timeout=30"));
    
    services.AddScoped<AddressRepository>();
    services.AddScoped<CategoryRepository>();
    services.AddScoped<RoleRepository>();
    services.AddScoped<ProductRepository>();
    services.AddScoped<CustomerRepository>();

    services.AddScoped<AddressService>();
    services.AddScoped<CategoryService>();
    services.AddScoped<RoleService>();
    services.AddScoped<ProductService>();
    services.AddScoped<CustomerService>();

    services.AddSingleton<ConsoleUI>();

}).Build();

bool menu = true;

var consoleUI = builder.Services.GetRequiredService<ConsoleUI>();



//consoleUI.CreateProduct_UI();
//consoleUI.GetProducts_UI();
//consoleUI.UpdateProduct_UI();
//consoleUI.DeleteProduct_UI();


//consoleUI.CreateCustomer_UI();
//consoleUI.GetCustomers_UI();
//consoleUI.UpdateCustomer_UI();
//consoleUI.DeleteCustomer_UI();



while (menu)
{
    Console.Clear();
    Console.WriteLine(" ---------------MENU------------");
    Console.WriteLine("|1. Create a product.           |");
    Console.WriteLine("|2. Show all products.          |");
    Console.WriteLine("|3. Update a product.           |");
    Console.WriteLine("|4. Delete a product.           |");
    Console.WriteLine("|5. Create a customer.          |");
    Console.WriteLine("|6. Show all customers.         |");
    Console.WriteLine("|7. Update customer's last name.|");
    Console.WriteLine("|8. Delete a customer.          |");
    Console.WriteLine("|0. Exit program.               |");
    Console.WriteLine(" -------------------------------");

    var option = Console.ReadLine();
    

    switch (option)
    {
        case "1":
            consoleUI.CreateProduct_UI();
            break;
        case "2":
            consoleUI.GetProducts_UI();
            break;
        case "3":
            consoleUI.UpdateProduct_UI();
            break;
        case "4":
            consoleUI.DeleteProduct_UI();
            break;
        case "5":
            consoleUI.CreateCustomer_UI();
            break;
        case "6":
            consoleUI.GetCustomers_UI();
            break;
        case "7":
            consoleUI.UpdateCustomer_UI();
            break;
        case "8":
            consoleUI.DeleteCustomer_UI();
            break;
        case "0":
            menu = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Invalid option, please press any key to try again.");
            Console.ReadKey();
            break;

    }
}
