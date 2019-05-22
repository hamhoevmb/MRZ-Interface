using Newtonsoft.Json;
using System.ComponentModel;

namespace MrzApp
{
    public class MrzDto : INotifyPropertyChanged
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
        public bool ValidNumber { get; set; }

        [JsonProperty("valid_date_of_birth")]
        public bool ValidDateOfBirth { get; set; }

        [JsonProperty("valid_expiration_date")]
        public bool ValidExpirationDate { get; set; }

        [JsonProperty("valid_composite")]
        public bool ValidComposite { get; set; }

        [JsonProperty("valid_personal_number")]
        public bool ValidPersonalNumber { get; set; }

        [JsonProperty("valid_line_lengths")]
        public bool[] ValidLineLengths { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
