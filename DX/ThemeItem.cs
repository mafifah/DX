using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DX
{
    public record ThemeItem(string Name, string[] StylesheetLinkUrl)
    {
        public static readonly ThemeItem Default = Create("default");
        public static ThemeItem Create(string name)
        {

            if (Utils.DevExpressThemes.Contains(name))
                return new ThemeItem(name, new[] { $"_content/DevExpress.Blazor.Themes/{name}.bs5.min.css" });
            return new ThemeItem(name, new[] { "_content/DevExpress.Blazor.Themes/bootstrap-external.bs5.min.css", $"css/switcher-resources/themes/{name}/bootstrap.min.css" });
        }
    };
}
