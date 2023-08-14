namespace ContactsApp.Model
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    /// <summary>
    /// Список контактов.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список всех контактов.
        /// </summary>
        public List<Contact> Contacts { get; private set; } = new List<Contact>();

        /// <summary>
        /// Сортировка контактов.
        /// </summary>
        /// <param name="contacts">Список всех контактов.</param>
        /// <returns>Отсортированный список контактов.</returns>
        public List<Contact> SortContacts(List<Contact> contacts)
        {
            return contacts.OrderBy(contact => contact.FullName).ToList();
        }

        /// <summary>
        /// Поиск именинников.
        /// </summary>
        /// <param name="contacts">Список всех контактов.</param>
        /// <returns>Список всех именинников.</returns>
        public List<Contact> FindBirthdays(List<Contact> contacts, DateTime date)
        {
            List<Contact> birthDayContacts = new List<Contact>();
            foreach (var contact in contacts)
            {
                if (contact.DateOfBirth.Day == date.Day &&
                    contact.DateOfBirth.Month == date.Month)
                {
                    birthDayContacts.Add(contact);
                }
            }
            return birthDayContacts;
        }

        /// <summary>
        /// Поиск контакта по подстроке.
        /// </summary>
        /// <param name="contacts">Список всех контактов.</param>
        /// <param name="substring">Подстрока поиска.</param>
        /// <returns>Список контактов содержащих подстроку.</returns>
        public List<Contact> FindContactsBySubstring(List<Contact> contacts, string substring)
        {
            if (substring == "")
            {
                return SortContacts(contacts);
            }
            substring = substring.ToLower();
            return SortContacts(contacts.FindAll(contact => contact.FullName.ToLower().Contains(substring)));
        }
    }
}