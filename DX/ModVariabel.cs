using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DX
{
    public static class modVariabel
    {
        public static ThemeItem _activeTheme = ThemeItem.Default;
        public static Dictionary<string, string[]> GroupedThemes = new()
        {
            ["Color Themes"] = new[] { "default" },
            ["DevExpress Themes"] = new[] { "blazing-berry", "purple", "office-white" },
            ["Bootswatch Themes"] = new[] {
            "cerulean", "cosmo", "cyborg", "darkly", "flatly", "journal", "litera",
            "lumen", "lux", "materia", "minty", "pulse", "sandstone", "simplex", "sketchy", "slate",
            "solar", "spacelab", "superhero", "united", "yeti" }
        };
        public static string urlstyle { get; set; } = "css/bootstrap/bootstrap.min.css";
    }
}
