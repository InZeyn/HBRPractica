using HBRPractica.Services;
using HBRPractica.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HBRPractica.Components
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly ProductService _service;
        public ProductViewComponent(ProductService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync(
        int maxPriority, bool isDone)
        {
            var items = await GetProductsAsync(maxPriority, isDone);
            return View(items);
        }

        private Task<string> GetProductsAsync(int maxPriority, bool isDone)
        {
            return _service.WriteMessage("TEST");
        }
    }
}
