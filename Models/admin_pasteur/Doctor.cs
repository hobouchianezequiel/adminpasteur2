using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace delSur_Solutions.Models.admin_pasteur
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("last_name")]
            public string LastName { get; set; }

            [JsonProperty("full_name")]
            public string FullName { get; set; }

            [JsonProperty("CUIT")]
            public long Cuit { get; set; }

            [JsonProperty("prestador_number")]
            public long PrestadorNumber { get; set; }

            [JsonProperty("consulting_room")]
            public string ConsultingRoom { get; set; }   
    }
}