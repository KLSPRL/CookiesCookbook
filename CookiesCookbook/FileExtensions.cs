using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook.Models
{
    public static class FileExtensions
    {
        public static string GetFileExtension(this FileFormat format)
        {
            return format switch
            {
                FileFormat.Txt => ".txt",
                FileFormat.Json => ".json",
                _ => throw new ArgumentOutOfRangeException(nameof(format), $"Unsupported file format: {format}")
            };
        }

    }
}
