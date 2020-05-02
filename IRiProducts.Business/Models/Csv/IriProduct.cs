﻿using CsvHelper.Configuration.Attributes;

namespace IRiProducts.Business.Models.Csv
{
    public class IriProduct
    {
        [Index(0)]
        public int Id { get; set; }

        [Index(1)]
        public string Name { get; set; }
    }
}