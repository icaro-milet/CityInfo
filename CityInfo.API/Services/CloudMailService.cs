﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private readonly IConfiguration _configuration;

        public CloudMailService(IConfiguration configuration)
        {
            _configuration = configuration ??
                throw new ArgumentException(nameof(configuration));
        }

        public void Send(string subject, string message)
        {
            // Send mail - output to debug window
            Debug.WriteLine($"Mail from {_configuration["mailSettings:mailFromAddress"]} to {_configuration["mailSettings:mailToAddress"]}, with LocalMail ");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }
    }
}
