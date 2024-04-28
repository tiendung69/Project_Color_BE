using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class ElasticField
    {
        public int Id { get; set; }
        public string? TableName { get; set; }
        public string? FieldName { get; set; }
    }
}
