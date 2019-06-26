using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesClasses
{
    class Adress
    {
        private string street;
        private int streetNumber;
        private string city;
        private string zipcode;

        public string FullStreet
        {
            get { return $"{street} {streetNumber}"; }
            private set { }
        }
        public string ZipCode
        {
            get { return zipcode; }
            set
            {
                bool validation = validateZip(value);
                if (validation == true)
                {
                    zipcode = value;
                    Console.WriteLine("Setter - Zip changed! ");
                }
                if (validation == false)
                {
                    Console.WriteLine("Setter - Entered zip was wrong format! ");
                }
            }
        }
        public Adress(string street, int streetNumber, string city, string zipcode)
        {
            this.street = street;
            this.streetNumber = streetNumber;
            this.city = city;
            this.zipcode = zipcode;
        }

        public string GetStreet()
        {
            return $"{street} {streetNumber}";
        }
        public void ChangeZidCode(string s)
        {
            bool value = validateZip(s);
            if (value == true)
            {
                zipcode = s;
                Console.WriteLine("Method - Zip changed! ");
            }
            if (value == false)
            {
                Console.WriteLine("Method - Entered zip was wrong format! ");
            }
        }
        public string GetZidCode()
        {
            return zipcode;
        }
        bool validateZip(string s)
        {
            bool value = true;
            string[] stringArray = s.Split(" ");
            if (
                stringArray.Length != 2 ||
                stringArray[0].Length != 3 || stringArray[1].Length != 2 ||
                Int32.TryParse(stringArray[0], out int left) == false || Int32.TryParse(stringArray[1], out int right) == false
                )
            {
                value = false;
            }
            return value;
        }
    }
}
