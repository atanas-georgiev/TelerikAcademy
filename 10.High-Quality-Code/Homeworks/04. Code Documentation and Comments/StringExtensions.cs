﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The string extensions component.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Telerik.ILS.Common
{   
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    ///     The string extensions.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// MD5 checksum calculation
        /// </summary>
        /// <param name="input">
        /// The input string, used for CRC calculation.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        ///     Checksum
        /// </returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (var i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Convert string to boolean
        /// </summary>
        /// <param name="input">
        /// Input string for conversion
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        ///     Converted boolean value
        /// </returns>
        public static bool ToBoolean(this string input)
        {
            // Define a structure with all posible true values
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Convert string to short
        /// </summary>
        /// <param name="input">
        /// Input string for conversion
        /// </param>
        /// <returns>
        /// The <see cref="short"/>.
        ///     Converted short value
        /// </returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Convert string to integer
        /// </summary>
        /// <param name="input">
        /// Input string for conversion
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        ///     Converted integer value
        /// </returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Convert string to long
        /// </summary>
        /// <param name="input">
        /// Input string for conversion
        /// </param>
        /// <returns>
        /// The <see cref="long"/>.
        ///     Converted long value
        /// </returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Convert string to date/time structure
        /// </summary>
        /// <param name="input">
        /// Input string for conversion
        /// </param>
        /// <returns>
        /// The <see cref="DateTime"/>.
        ///     Converted date/time
        /// </returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalize first letter of the string
        /// </summary>
        /// <param name="input">
        /// Input string for capitalization
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        ///     Resulted string with capitalized letter
        /// </returns>
        /// <remarks>
        /// Used current loaded culture
        /// </remarks>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Get a substring between two given strings
        /// </summary>
        /// <param name="input">
        /// The input string.
        /// </param>
        /// <param name="startString">
        /// The start string, marks the beginning
        /// </param>
        /// <param name="endString">
        /// The end string, marks the end
        /// </param>
        /// <param name="startFrom">
        /// Start position.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        ///     Resulted substring
        /// </returns>
        /// <remarks>
        /// Case not ignored
        /// </remarks>
        public static string GetStringBetween(
            this string input, 
            string startString, 
            string endString, 
            int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            // Find first marker
            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            // Find last marker
            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Convert cyrillic to latin letters
        /// </summary>
        /// <param name="input">
        /// Input cyrillic letters
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        ///     Converted latin letters
        /// </returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", 
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k", 
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h", 
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(
                    bulgarianLetters[i].ToUpper(), 
                    latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Convert cyrillic to latin letters in BDS standard
        /// </summary>
        /// <param name="input">
        /// Input cyrillic letters
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        ///     Converted latin letters
        /// </returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", 
                                       "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к", 
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж", 
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (var i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Convert string to valid username string
        /// </summary>
        /// <param name="input">
        /// Input username
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        ///     Converted valid username
        /// </returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Convert string to valid filename
        /// </summary>
        /// <param name="input">
        /// Input filename
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        ///     Converted valid filename
        /// </returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Gets the first N characters
        /// </summary>
        /// <param name="input">
        /// The input string to read
        /// </param>
        /// <param name="charsCount">
        /// Number of chars
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        ///     Substring of the characters.
        /// </returns>
        /// <remarks>
        /// If characters count are more than the input string length, the complete input string will be returned.
        /// </remarks>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Gets file extension
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        ///     Extension of the file
        /// </returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            var fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Convert file extension to contend type
        /// </summary>
        /// <param name="fileExtension">
        /// The file extension.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        ///     File content MIME string
        /// </returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" }, 
                                                     { "jpeg", "image/jpeg" }, 
                                                     { "png", "image/x-png" }, 
                                                     {
                                                         "docx", 
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     }, 
                                                     { "doc", "application/msword" }, 
                                                     { "pdf", "application/pdf" }, 
                                                     { "txt", "text/plain" }, 
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Convert string to array of characters
        /// </summary>
        /// <param name="input">
        /// The input string.
        /// </param>
        /// <returns>
        /// The <see cref="byte[]"/>.
        ///     Array of bytes, representing the input string
        /// </returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}