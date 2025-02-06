using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrApp.UI
{
    internal class Employee
    {
		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

		private DateTime _birthDate;

		public DateTime BirthDate
		{
			get { return _birthDate; }
			set { _birthDate = value; }
		}

		private decimal _salary;

		public decimal Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}

		public int Age
		{
			get { return DateTime.Today.Year - this.BirthDate.Year; }
		}

        public Employee()
        {
            
        }

        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
			_lastName = lastName;
        }

		public void IncreaseSalary(int percentage)
		{
            this.Salary += this.Salary * Convert.ToDecimal(percentage) / 100;
		}

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
