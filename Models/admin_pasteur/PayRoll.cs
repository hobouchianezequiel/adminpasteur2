using delSur_Solutions.Models.admin_pasteur;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace delSur_Solutions.Models
{
    public class PayRoll
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("affiliate")]
        public Affiliate Affiliate { get; set; }

        [JsonProperty("doctor")]
        public Doctor Doctor { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("cod_prest")]
        public long CodPrest { get; set; }

        [JsonProperty("trans")]
        public string Trans { get; set; }

        [JsonProperty("authorization_number")]
        public long AuthorizationNumber { get; set; }

        [JsonProperty("diagnosis")]
        public string Diagnosis { get; set; }

        [JsonProperty("coseg")]
        public long Coseg { get; set; }

        [JsonProperty("invoiced_period")]
        public DateTime InvoicedPeriod { get; set; }

        [JsonProperty("consulting_room")]
        public string ConsultingRoom { get; set; }

        [JsonProperty("observations")]
        public string Observations { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("total_amount")]
        public long TotalAmount { get; set; }

    }
}