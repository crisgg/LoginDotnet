using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


public class AddressViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}