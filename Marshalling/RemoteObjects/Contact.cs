using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshalling.RemoteObjects
{
    [Serializable]
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public string LastFirstName
        {
            get { return _lastName + ", " + _firstName; }
        }
    }

    [Serializable]
    public class Contact
    {
        private Person _person;
        private string _number;
        private string _email;

        public Contact() { }
        public Contact(string firstName, string lastName, string number)
        {
            _person = new Person(firstName, lastName);
            _number = number;
        }
        public Contact(string firstName, string lastName, string number, string email) : this(firstName, lastName, number)
        {
            _email = email;
        }
        
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string LastFirstName
        {
            get { return _person.LastFirstName; }
        }

        public string FirstLastName
        {
            get { return _person.FullName; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
