using System;

namespace Task1.BusinessLogic.Dtos
{
    public class PersonDto : IComparable<PersonDto>
    {
        private DateTime date;
        private string firstName;
        private string lastName;
        private string middleName;
        private string city;
        private string country;

        public int Id { get; set; }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                if (!DateTime.TryParse(value.ToString(), out date))
                {
                    throw new Exception("Date entered incorrectly.");
                }
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The first name cannot be empty.");
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The last name cannot be empty!");
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The middle name cannot be empty!");
                }
                else
                {
                    middleName = value;
                }
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The country name cannot be empty!");
                }
                else
                {
                    country = value;
                }
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The city name cannot be empty!");
                }
                else
                {
                    city = value;
                }
            }
        }

        public int CompareTo(PersonDto other)
        {
            PersonDto p = other as PersonDto;
            if (p != null)
            {
                return this.Id.CompareTo(p.Id);
            }
            else
            {
                throw new Exception("Sorting is not possible.");
            }
        }
    }
}