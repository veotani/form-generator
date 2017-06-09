using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Form.Models
{
    public class Form
    {
        public enum SampleEnum
        {
            EnumPosition1,
            EnumPosition2,
            EnumPosition3
        }
        public string Name;
        public string Surname;
        public int Age;
        public string Lala;
        [EnumDataType(typeof(SampleEnum))]
        public string EnumProperty { get; set; }
        public string[] someStrings { get; set; }
    }
}