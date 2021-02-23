﻿using System;
using System.Collections.Generic;

namespace hc.Http
{
    public class HttpCheckSettings
    {
        public string? Uri { get; set; }

        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(10);

        public ushort[] SuccessStatusCodes { get; set; } = { 200 };

        public string? TelegramChatId { get; set; }

        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();
    }
}