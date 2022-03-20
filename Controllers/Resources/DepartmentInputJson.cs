using System;
using System.Text.Json.Serialization;


namespace Department_Backend.Controllers.Resources
{
    public class DepartmentInputJson
    {
        [JsonPropertyName("departmentId")]
        public int DepartmentId { get; set; }

        [JsonPropertyName("departmentName")]
        public string DepartmentName { get; set; }
    }
}
