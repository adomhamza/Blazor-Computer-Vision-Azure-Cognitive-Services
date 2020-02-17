#pragma checksum "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "324ae7ffc96047dedb1638f4f490e5f34c606639"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorComputerVision.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using BlazorComputerVision;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using BlazorComputerVision.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
using BlazorComputerVision.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/computer-vision-ocr")]
    public partial class OCR : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Optical Character Recognition (OCR) using Blazor and Azure Computer Vision Cognitive Services</h2>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "textarea");
            __builder.AddAttribute(8, "disabled", true);
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "rows", "15");
            __builder.AddAttribute(11, "cols", "30");
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
                                                                     textData

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-md-5");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "image-container");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "class", "preview-image");
            __builder.AddAttribute(23, "src", 
#nullable restore
#line 14 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
                                            imagePreview

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(26);
            __builder.AddAttribute(27, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 16 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
                             ViewFile

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, 
#nullable restore
#line 17 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
            status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        <hr>\r\n        ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "disabled", 
#nullable restore
#line 19 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
                           loading

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "btn btn-primary btn-lg");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
                                                                             GetText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 20 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
             if (loading)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "                <span class=\"spinner-border spinner-border-sm mr-1\"></span>\r\n");
#nullable restore
#line 23 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "            Extract Text\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
       
    string imagePreview;
    string textData;
    bool loading = false;
    byte[] imageFileBytes;
    const string status = "Max image size allowed is 5 MB";

    async Task ViewFile(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file == null)
        {
            return;
        }
        else
        {
            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);
            imageFileBytes = memoryStream.ToArray();
            string base64String = Convert.ToBase64String(imageFileBytes, 0, imageFileBytes.Length);

            imagePreview = string.Concat("data:image/png;base64,", base64String);
            memoryStream.Flush();
        }
    }

    private async Task GetText()
    {
        loading = true;
        textData = await computerVisionService.GetTextFromImage(imageFileBytes);
        loading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ComputerVisionService computerVisionService { get; set; }
    }
}
#pragma warning restore 1591