﻿using System;

namespace FubuMVC.Authentication.Tickets.Basic
{
    public class CookieSettings
    {
        public static readonly string DefaultCookieName = "FubuAuthTicket";

        public CookieSettings()
        {
            Name = DefaultCookieName;
            ExpirationInDays = 30;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public string Domain { get; set; }

        public bool Secure { get; set; }
        public bool HttpOnly { get; set; }

        public int ExpirationInDays { get; set; }

        public DateTime ExpirationFor(DateTime date)
        {
            return date.AddDays(ExpirationInDays);
        }
    }
}