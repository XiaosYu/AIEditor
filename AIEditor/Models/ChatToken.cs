using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AIEditor.Models
{
    public class ChatToken
    {
        [JsonPropertyName("role")]
        public string Role { set; get; }

        [JsonPropertyName("content")]
        public string Content { set; get; }
    }
}
