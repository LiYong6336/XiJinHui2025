using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models
{
    public class Printer
    {
        public static List<string> PrinterTypes = new List<string>
        {
            "network",
            "bluetooth",
            "usb",
        };

        private bool isBlue = false;

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("printer_brand")]
        public string PrinterBrand { get; set; }

        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }

        [JsonPropertyName("printer_ip_address")]
        public string PrinterIpAddress { get; set; }

        [JsonPropertyName("port")]
        public string Port { get; set; }

        //[JsonPropertyName("isBle")]
        //public bool IsBle { get
        //    {
        //        return isBlue;
        //    }
        //    set
        //    {
        //        isBlue = bool.TryParse( value.ToString(), out bool result)? result: false;
        //    }
        //}

        [JsonPropertyName("printer_type")]
        public string PrinterType { get; set; }

        [JsonPropertyName("print_location")]
        public string PrintLocation { get; set; }

        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

    }
}
