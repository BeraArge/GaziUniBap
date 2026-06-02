using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.Helpers
{
    public class ModuleHelper
    {
        public const string Category = "Category";
        public const string Page = "Page";
        public const string Feature = "Feature";

        public static readonly List<string> ModulesKeys = new List<string>(){ "Category", "Page", "Feature" };
    }
}
