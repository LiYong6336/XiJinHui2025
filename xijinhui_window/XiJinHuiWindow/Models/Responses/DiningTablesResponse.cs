using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models.Responses
{
    public class DiningTablesResponse
    {
            [JsonPropertyName("dining")]
            public List<DiningTable> Dining { get; set; }

        [JsonPropertyName("busyTable")]
        public List<SaleTable> BusyTables  { get; set; }

}
}
