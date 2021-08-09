using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace delSur_Solutions.Models.admin_pasteur
{
    public class Affiliate
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("credential_number")]
        public long CredentialNumber { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }
    }
}