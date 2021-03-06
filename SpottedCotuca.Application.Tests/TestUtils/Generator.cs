﻿using System;
using System.Linq;

namespace SpottedCotuca.Application.Tests.TestUtils
{
    public static class Generate
    {
        private static Random _random = new Random();

        public static long NewId()
        {
            const string numbers = "0123456789";

            var id = _random.Next(1, 10) + new string(Enumerable.Repeat(numbers, 15)
                                                        .Select(s => s[_random.Next(s.Length)]).ToArray());

            return Convert.ToInt64(id);
        }

        public static string NewString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var generatedString =  new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());

            return generatedString;
        }
        
        public static string NewMessage()
        {
            var message =  new string(NewString(278));
            return $"\"{message}\"";
        }
    }
}
