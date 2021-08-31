// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\Pages\Index.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\bmcma\Documents\CollegeWork\WinterSemester\EAD\Repeat\BlazorApp\Pages\Index.razor"
       
    private IEnumerable<University> unis = Array.Empty<University>();
    private bool getUniErr;
    private bool render;

    protected override bool ShouldRender() => render;

    protected override async Task OnInitializedAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get,
            "http://universities.hipolabs.com/search?country=Ireland");
        request.Headers.Add("Accept", "application/vnd.github.v3+json");
        request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

        var client = ClientFactory.CreateClient();

        var response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            using var responseStream = await response.Content.ReadAsStreamAsync();
            unis = await JsonSerializer.DeserializeAsync
                <IEnumerable<University>>(responseStream);
        }
        else
        {
            getUniErr = true;
        }
            render = true;
    }

    public class University
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("state-province")]
        public string State { get; set; }
                    
        [JsonPropertyName("web_pages")]
        public string[] Web { get; set; }
                    
        [JsonPropertyName("alpha_two_code")]
        public string Code { get; set; }
                    
        [JsonPropertyName("name")]
        public string Name { get; set; }
                    
        [JsonPropertyName("domains")]
        public string[] Domain { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
