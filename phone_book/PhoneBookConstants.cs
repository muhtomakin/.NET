using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_book {
    class PhoneBookConstants {
        
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
   
        public PhoneBookConstants(string firstName, string lastName, string phoneNumber) {
            firstName = firstName;
            lastName = lastName;
            phoneNumber = phoneNumber;
        }
        public PhoneBookConstants() {}
    }
}