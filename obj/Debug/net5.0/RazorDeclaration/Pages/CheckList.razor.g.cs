// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTestProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\_Imports.razor"
using BlazorTestProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\_Imports.razor"
using BlazorTestProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\Pages\CheckList.razor"
using BlazorTestProject.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\Pages\CheckList.razor"
using BlazorTestProject.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\Pages\CheckList.razor"
using BlazorTestProject.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\Pages\CheckList.razor"
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CheckList")]
    public partial class CheckList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\Pages\CheckList.razor"
       
    
    public List<Entities.CheckList> CheckLists { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        CheckLists = UnitOfWork.CheckLists.GetAll().ToList();
        Console.WriteLine(CheckLists.Count);
    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
    }


    void DeleteEntry(Guid index)
    {
       Entry entry = UnitOfWork.Entries.Find(e => e.Id.ToString().Equals(index.ToString())).FirstOrDefault();
        UnitOfWork.Entries.Remove(entry);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnityOfWork UnitOfWork { get; set; }
    }
}
#pragma warning restore 1591