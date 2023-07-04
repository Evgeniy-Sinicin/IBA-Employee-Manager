using System;
using System.Collections.Generic;
using System.Linq;
using Task1.BusinessLogic.Helpers;
using Task1.DataAccess.EF;
using Task1.DataAccess.Entities;
using Task1.DataAccess.Interfaces;
using Task1.DataAccess.Repositories;
using Task1.Extractor.Extractors;
using Task1.Extractor.Interfaces;
using Task1.Printer.Interfaces;
using Task1.Printer.Printers;

namespace Task1.BusinessLogic.ExtractorsControl
{
    public static class Controller
    {
        private static IExtractor extractor = null;
        private static IObjectPrinter printer = null;

        /// <summary>
        /// Метод извлекает данные из csv-файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Возвращает коллекцию объектов типа PersonDto</returns>
        public static IEnumerable<BusinessLogic.Dtos.PersonDto> GetPeopleFromCsvFile(string path)
        {
            try
            {
                extractor = new CsvExtractor();
                var peopleEx = extractor.Extract(path);
                var peopleBL = peopleEx.Select(p => Mapper.Map<Extractor.Dtos.PersonDto, BusinessLogic.Dtos.PersonDto>(p));
                return peopleBL;
            }
            catch
            {
                throw new Exception("Could not load data. The file may be corrupted or contain incorrect data.");
            }
        }

        /// <summary>
        /// Метод извлекает данные из базы данных
        /// </summary>
        /// <returns>Возвращает коллекцию объектов типа PersonDto</returns>
        public static IEnumerable<BusinessLogic.Dtos.PersonDto> GetPeopleFromDatabase()
        {
            var people = new List<BusinessLogic.Dtos.PersonDto>();
            var context = new ProjectContext("DbConnection");
            using (IUnitOfWork rep = new EFUnitOfWork(context))
            {
                var dbPeople = rep.Persons.GetAll().ToArray();
                people.AddRange(dbPeople.Select(p => Mapper.Map<DataAccess.Entities.Person, BusinessLogic.Dtos.PersonDto>(p)));
            };
            return people;
        }

        /// <summary>
        /// Метод добавляет данные типа PersonDto к базе данных
        /// </summary>
        /// <param name="person">Добавляемый объект</param>
        public static void AddPersonToDatabase(BusinessLogic.Dtos.PersonDto person)
        {
            var context = new ProjectContext("DbConnection");
            using (IUnitOfWork rep = new EFUnitOfWork(context))
            {
                var repOptions = new PersonRepository(context);
                repOptions.Create(Mapper.Map<BusinessLogic.Dtos.PersonDto, Person>(person));
                rep.Save();
            };
        }

        /// <summary>
        /// Метод обновляет данные в базе данных
        /// </summary>
        /// <param name="id">Id обновляемого объекта в базе данных</param>
        /// <param name="newPerson">Объект содержащий новые данные</param>
        public static void UpdatePersonFromDatabase(int id, BusinessLogic.Dtos.PersonDto newPerson)
        {
            var context = new ProjectContext("DbConnection");
            using (IUnitOfWork rep = new EFUnitOfWork(context))
            {
                var repOptions = new PersonRepository(context);
                var selectedPerson = repOptions.Get(id);
                selectedPerson.Date = newPerson.Date;
                selectedPerson.LastName = newPerson.LastName;
                selectedPerson.FirstName = newPerson.FirstName;
                selectedPerson.MiddleName = newPerson.MiddleName;
                selectedPerson.City = newPerson.City;
                selectedPerson.Country = newPerson.Country;
                repOptions.Update(selectedPerson);
                rep.Save();
            }
        }

        /// <summary>
        /// Метод удаляет данные в базе данных
        /// </summary>
        /// <param name="id">Id удаляемого объекта</param>
        public static void DeletePersonFromDatabase(int id)
        {
            var context = new ProjectContext("DbConnection");
            using (IUnitOfWork rep = new EFUnitOfWork(context))
            {
                var repOptions = new PersonRepository(context);
                repOptions.Delete(id);
                rep.Save();
            }
        }

        /// <summary>
        /// Метод фильтрующий коллекцию людей
        /// </summary>
        /// <param name="people">Коллекция людей</param>
        /// <param name="date">Дата, по которой следует фильтровать</param>
        /// <param name="lastName">Фамилия, по которой следует фильтровать</param>
        /// <param name="firstName">Имя, по которому следует фильтровать</param>
        /// <param name="middleName">Отчество, по которому следует фильтровать</param>
        /// <param name="city">Город, по которому следует фильтровать</param>
        /// <param name="country">Страна, по которой следует фильтровать</param>
        /// <returns>Возвращает коллекцию объектов типа PersonDto</returns>
        public static IEnumerable<BusinessLogic.Dtos.PersonDto> ToFilterPeople(IEnumerable<BusinessLogic.Dtos.PersonDto> people,
            string date, string lastName, string firstName, string middleName, string city, string country)
        {
            return from p in people
                   where p.Date.ToShortDateString().StartsWith(date)
                           && p.FirstName.ToUpper().StartsWith(firstName.ToUpper())
                           && p.MiddleName.ToUpper().StartsWith(middleName.ToUpper())
                           && p.LastName.ToUpper().StartsWith(lastName.ToUpper())
                           && p.City.ToUpper().StartsWith(city.ToUpper())
                           && p.Country.ToUpper().StartsWith(country.ToUpper())
                   orderby p
                   select p;
        }

        /// <summary>
        /// Метод печатает объекты типа PersonDto в Excel-файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="people">Коллекция объектов печати</param>
        public static void PrintPeopleToExcel(string path, IEnumerable<BusinessLogic.Dtos.PersonDto> people)
        {
            printer = new ExcelPrinter();
            var preparedPeople = people.Select(p => Mapper.Map<BusinessLogic.Dtos.PersonDto, Extractor.Dtos.PersonDto>(p));
            printer.PrintObjects(path, preparedPeople);
        }
    }
}
