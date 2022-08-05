using System;
using System.Threading.Tasks;
using HBRPractica.Interfaces;

namespace HBRPractica.Services
{
    public class ProductService : IProductService
    {
        public async Task<string> WriteMessageAsync(string message)
        {
            Console.WriteLine($"Message: {message}");
            return message;
        }
    }
}
