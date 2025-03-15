using BookHaven.Business.services;
using BookHaven.Data.repository;
using BookHaven.Data;
using BookHaven.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace BookHaven
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Register DbContext
            services.AddDbContext<AppDbContext>();

            // Register Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<IStockOrderRepository, StockOrderRepository>();

            // Register Business Services
            services.AddScoped<AuthService>();

            // Register Windows Forms
            services.AddTransient<Login>(); // Register Login Form
            services.AddTransient<AdminDashboard>(); // Register Admin Dashboard
            //services.AddTransient<ClearkDashboard>(); // Register Clerk Dashboard

            var serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Resolve Login Form from Service Provider
            var loginForm = serviceProvider.GetRequiredService<Login>();
            Application.Run(loginForm);
        }
    }
}