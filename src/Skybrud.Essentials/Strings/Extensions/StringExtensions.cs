﻿using System;
using System.Collections.Generic;

namespace Skybrud.Essentials.Strings.Extensions {

    /// <summary>
    /// Static class with various extension methods for <see cref="String"/>.
    /// </summary>
    public static class StringExtensions {

        /// <summary>
        /// Converts a comma separated string into an array of integers.
        /// </summary>
        /// <param name="str">The comma separated string to be converted.</param>
        /// <returns>Returns an array of <see cref="Int32"/>.</returns>
        public static int[] CsvToInt(this string str) {
            return StringUtils.CsvToInt(str);
        }

        /// <summary>
        /// Converts the specified <code>str</code> to camel case (also referred to as lower camel casing).
        /// </summary>
        /// <param name="str">The string to be converted.</param>
        /// <returns>Returns the camel cased string.</returns>
        public static string ToCamelCase(this string str) {
            return StringUtils.ToCamelCase(str);
        }

        /// <summary>
        /// Converts the name of the specified enum <code>value</code> to a camel cased string.
        /// </summary>
        /// <param name="value">The enum value to be converted.</param>
        /// <returns>Returns the camel cased string.</returns>
        public static string ToCamelCase(Enum value) {
            return StringUtils.ToCamelCase(value);
        }

        /// <summary>
        /// Converts the specified <code>str</code> to Pascal case (also referred to as upper camel casing).
        /// </summary>
        /// <param name="str">The string to be converted.</param>
        /// <returns>Returns the Pascal cased string.</returns>
        public static string ToPascalCase(this string str) {
            return StringUtils.ToPascalCase(str);
        }

        /// <summary>
        /// Converts the name of the specified enum <code>value</code> to a Pascal cased string.
        /// </summary>
        /// <param name="value">The enum value to be converted.</param>
        /// <returns>Returns the Pascal cased string.</returns>
        public static string ToPascalCase(Enum value) {
            return StringUtils.ToPascalCase(value);
        }

        /// <summary>
        /// Converts the specified <code>str</code> to a lower case string with words separated by underscores.
        /// </summary>
        /// <param name="str">The string to be converted.</param>
        /// <returns>Returns the converted string.</returns>
        public static string ToUnderscore(this string str) {
            return StringUtils.ToUnderscore(str);
        }

        /// <summary>
        /// Converts the specified enum value to a lower case string with words separated by underscores.
        /// </summary>
        /// <param name="value">The enum value to be converted.</param>
        /// <returns>Returns the converted string.</returns>
        public static string ToUnderscore(this Enum value) {
            return StringUtils.ToUnderscore(value);
        }

        /// <summary>
        /// Uppercases the first character of a the specified <code>str</code>. If <code>str</code> is either
        /// <code>null</code> or empty, an empty string will be returned instead.
        /// </summary>
        /// <param name="str">The string which first character should be uppercased.</param>
        /// <returns>The input string with the first character has been uppercased.</returns>
        public static string FirstCharToUpper(this string str) {
            return StringUtils.FirstCharToUpper(str);
        }

        /// <summary>
        /// Encodes a URL string.
        /// </summary>
        /// <param name="str">The string to be encoded.</param>
        /// <returns>Returns the encoded string.</returns>
        public static string UrlEncode(this string str) {
            return StringUtils.UrlEncode(str);
        }

        /// <summary>
        /// Decodes a URL string.
        /// </summary>
        /// <param name="str">The string to be decoded.</param>
        /// <returns>Returns the decoded string.</returns>
        public static string UrlDecode(this string str) {
            return StringUtils.UrlDecode(str);
        }



        /// <summary>
        /// Counts number of words in the specified <paramref name="str"/>.
        /// </summary>
        /// <param name="str">The string to parse.</param>
        /// <returns>An integer with the number of words found.</returns>
        public static int WordCount(this string str) {
            return StringUtils.WordCount(str);
        }

        /// <summary>
        /// Highlights specified <paramref name="keywords"/> in the <paramref name="input"/> string with the specified
        /// <paramref name="className"/> by using a <code>&lt;span&gt;</code> element.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="className">The class name.</param>
        /// <param name="keywords">The keywords to highlight.</param>
        /// <returns>The input string with highlighted keywords.</returns>
        public static string HighlightKeywords(string input, string className, IEnumerable<string> keywords) {
            return StringUtils.HighlightKeywords(input, className, keywords);
        }

        /// <summary>
        /// Highlights specified <paramref name="keywords"/> in the <paramref name="input"/> string with the specified
        /// <paramref name="className"/> by using a <code>&lt;span&gt;</code> element.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="className">The class name.</param>
        /// <param name="keywords">The keywords to highlight.</param>
        /// <returns>The input string with highlighted keywords.</returns>
        public static string HighlightKeywords(string input, string className, params string[] keywords) {
            return StringUtils.HighlightKeywords(input, className, keywords);
        }
        
        /// <summary>
        /// Removes markup from string
        /// </summary>
        /// <param name="html">The input string containing markup.</param>
        /// <returns>The input string without html markup.</returns>
        public static string RemoveMarkup(this string html)
        {
            string text = Regex.Replace(html, "<.*?>", "");
            return HttpUtility.HtmlDecode(text);
        }

    }

}
