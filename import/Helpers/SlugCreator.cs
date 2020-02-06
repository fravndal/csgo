using System;
using System.Collections.Generic;
using System.Text;

namespace Import.Helpers
{
    public static class SlugCreator
    {
        public static string CreateSlug(this string slug)
        {
            return slug.Replace(" ", "_").ToLower();
        }
    }
}
