﻿using Nop.Plugin.Api.MVC;

namespace Nop.Plugin.Api.Models.CustomersParameters
{
    public class CustomersSearchParametersModel
    {
        public CustomersSearchParametersModel()
        {
            Order = "Id";
            Query = string.Empty;
            Page = Configurations.DefaultPageValue;
            Limit = Configurations.DefaultLimit;
            Fields = string.Empty;
        }

        public string Order { get; set; }
        public string Query { get; set; }
        public int Page { get; set; }
        public byte Limit { get; set; }
        public string Fields { get; set; }
    }
}