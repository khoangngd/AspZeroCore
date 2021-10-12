﻿using System;

namespace tls.demo.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime? GetEndOfDate(this DateTime? date)
        {
            return date?.Date.AddDays(1).AddTicks(-1);
        }
    }
}