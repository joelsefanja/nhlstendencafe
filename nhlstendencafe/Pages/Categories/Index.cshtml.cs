using Microsoft.AspNetCore.Mvc.RazorPages;
using nhlstendencafe.Models;
using nhlstendencafe.Repositories;

namespace nhlstendencafe.Pages.Categories;

public class Index : PageModel
{
    public IEnumerable<Category> Categories { get; set; } = null!;
    
    public void OnGet()
    {
        Categories = new CategoryRepository().GetCategoriesWithProducts();
    }

    
}