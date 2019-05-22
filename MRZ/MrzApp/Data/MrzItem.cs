using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MrzApp.Data
{
    public class MrzItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Names { get; set; }
        public string Country { get; set; }
        public string Number { get; set; }
        public string DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Sex { get; set; }
        public string PersonalNumber { get; set; }
    }
}
