using Newtonsoft.Json;

namespace MrzApp
{
    public class MrzData
    {
        [JsonProperty("check_number")]
        public string CheckNumber { get; set; }

        [JsonProperty("check_date_of_birth")]
        public string CheckDateOfBirth { get; set; }

        [JsonProperty("check_expiration_date")]
        public string CheckExpirationDate { get; set; }

        [JsonProperty("check_composite")]
        public string CheckComposite { get; set; }

        [JsonProperty("check_personal_number")]
        public string CheckPersonalNumber { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("names")]
        public string Names { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("personal_number")]
        public string PersonalNumber { get; set; }

        [JsonProperty("valid_number")]
        public string ValidNumber { get; set; }

        [JsonProperty("valid_date_of_birth")]
        public string ValidDateOfBirth { get; set; }

        [JsonProperty("valid_expiration_date")]
        public string ValidExpirationDate { get; set; }

        [JsonProperty("valid_composite")]
        public string ValidComposite { get; set; }

        [JsonProperty("valid_personal_number")]
        public string ValidPersonalNumber { get; set; }

        [JsonProperty("valid_line_lengths")]
        public string[] ValidLineLengths { get; set; }

    }
}
