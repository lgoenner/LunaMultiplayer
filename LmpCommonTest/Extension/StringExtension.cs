﻿using System;

namespace LmpCommonTest.Extension
{
    public static class StringExtension
    {
        public static string ToUnixString(this string stringToFix)
        {
            return stringToFix.Replace(Environment.NewLine, "\n");
        }
    }
}
