// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingShop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using BlazingShop.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/{id:int}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor"
       
    private Product _product = new();
    
    [Parameter]
    public int Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        // if (ProductService.Products == null || ProductService.Products.Count == 0)
        // {
        //     ProductService.LoadProducts();
        //     return;
        // }

        _product = await ProductService.GetProduct(Id);
        // ProductService.Products.FirstOrDefault(p => p.Id == int.Parse(Id));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
