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
#line 2 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\Pages\AddChecklistEntry.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\Pages\AddChecklistEntry.razor"
using BlazorTestProject.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\Pages\AddChecklistEntry.razor"
using BlazorTestProject.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\Pages\AddChecklistEntry.razor"
using BlazorTestProject.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddChecklistEntry")]
    public partial class AddChecklistEntry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\paddy\RiderProjects\BlazorTestProject\BlazorTestProject\Pages\AddChecklistEntry.razor"
       

    [Parameter] 
    public Guid CheckListId { get; set; }
    
    
    public string EntryText = "";

    [Parameter]
    public EventCallback EntryAdded { get; set; }

    void SubmitForm()
    {
        UnitOfWork.Entries.Add(new Entry
        {
            Id =  new Guid(),
            EntryText = EntryText,
            IsDone = false,
            CheckListId = CheckListId
        });
        UnitOfWork.Complete();
        this.EntryAdded.InvokeAsync(null);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnityOfWork UnitOfWork { get; set; }
    }
}
#pragma warning restore 1591