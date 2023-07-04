using System;

namespace Task1.DataAccess.Entities
{
    public class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public int CompareTo(Person other)
        {
            Person p = other as Person;
            if(p != null)
            {
                return this.Id.CompareTo(p.Id);
            }
            else
            {
                throw new Exception("Ошибка! Сортировка невозможна.");
            }
        }
    }
}
