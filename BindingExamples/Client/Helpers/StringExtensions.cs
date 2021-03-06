﻿using System;

namespace BindingExamples.Client.Helpers
{
    internal static class StringExtensions
    {
        private static readonly string[] Separators = {"\r\n", "\r", "\n"};

        public static string[] GetLines(this string self, bool removeEmptyLines = false)
        {
            var options = removeEmptyLines
                ? StringSplitOptions.RemoveEmptyEntries
                : StringSplitOptions.None;

            var result = self.Split(Separators, options);
            return result;
        }
    }
}
