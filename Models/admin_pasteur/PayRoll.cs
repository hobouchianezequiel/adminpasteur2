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

        [Display(Name = "AFILIAD@")]
        [JsonProperty("affiliate")]
        public Affiliate Affiliate { get; set; }

        [Display(Name = "PSICOLOG@")]
        [JsonProperty("doctor")]
        public Doctor Doctor { get; set; }

        [Display(Name = "FECHA")]
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [Display(Name = "COD. PREST.")]
        [JsonProperty("cod_prest")]
        public long CodPrest { get; set; }

        [Display(Name = "TRANS. (*)")]
        [JsonProperty("trans")]
        public string Trans { get; set; }

        [Display(Name = "N° AUTORIZ.")]
        [JsonProperty("authorization_number")]
        public long AuthorizationNumber { get; set; }

        [Display(Name = "DIAGNOSTICO")]
        [JsonProperty("diagnosis")]
        public string Diagnosis { get; set; }

        [Display(Name = "COSEG.")]
        [JsonProperty("coseg")]
        public long Coseg { get; set; }

        [Display(Name = "PERIODO FACTURADO")]
        [JsonProperty("invoiced_period")]
        public DateTime InvoicedPeriod { get; set; }

        [Display(Name = "CONSULTORIO")]
        [JsonProperty("consulting_room")]
        public string ConsultingRoom { get; set; }

        [Display(Name = "OBSERVACIONES")]
        [JsonProperty("observations")]
        public string Observations { get; set; }

        [Display(Name = "IMPORTE")]
        [JsonProperty("amount")]
        public long Amount { get; set; }
        
        [Display(Name = "TOTAL FACTURADO")]
        [JsonProperty("total_amount")]
        public long TotalAmount { get; set; }

    }
}