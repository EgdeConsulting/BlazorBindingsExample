using System;
using Microsoft.AspNetCore.Components;

namespace BindingExamples.Client.Components
{
    public partial class Breadcrumb
    {
        [Parameter] public string[] Sections { get; set; }

        [Parameter] public string ActiveSection { get; set; }

        [Parameter] public EventCallback<string> ActiveSectionChanged { get; set; }

        private void OnClick(string section)
        {
            ActiveSection = section;
            ActiveSectionChanged.InvokeAsync(section);
        }

        private string CssClass(string section)
        {
            return section != ActiveSection
                ? "text-primary"
                : "text-success";
        }

        protected override void OnParametersSet()
        {
            Sections ??= Array.Empty<string>();
        }
    }
}
