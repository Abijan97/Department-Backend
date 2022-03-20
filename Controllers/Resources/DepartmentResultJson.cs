using System;
using System.Text.Json.Serialization;


namespace Department_Backend.Controllers.Resources
{
    public class DepartmentResultJson
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
