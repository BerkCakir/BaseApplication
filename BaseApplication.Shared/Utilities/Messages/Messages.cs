using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApplication.Shared.Utilities.Messages
{
    public static class Messages
    {
        public static class Category
        {
            public static string NotFound(bool isPlural = false)
            {
                if (isPlural) return "No category found";
                return "Category not found";
            }

            public static string Add()
            {
                return "Category is successfully saved";
            }

            public static string Update()
            {
                return "Category is successfully updated";
            }
            public static string Delete()
            {
                return "Category is successfully deleted";
            }
            public static string HardDelete()
            {
                return "Successfully is deleted from database";
            }
        }

        public static class Article
        {
            public static string NotFound(bool isPlural = false)
            {
                if (isPlural) return "No article found";
                return "Article not found";
            }

            public static string Add(string title)
            {
                return $"Article named:{title} was successfully saved";
            }

            public static string Update(string title)
            {
                return $"Article named:{title} was successfully updated";
            }
            public static string Delete(string title)
            {
                return $"Article named:{title} was successfully deleted";
            }
            public static string HardDelete(string title)
            {
                return $"Article named:{title} was successfully deleted from database";
            }
        }
    }
}
