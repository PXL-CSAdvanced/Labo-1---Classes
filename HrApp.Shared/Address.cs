using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrApp.Shared
{
    public class Address
    {
		private string _street;

		public string Street
		{
			get { return _street; }
			set { _street = value; }
		}
		private string _number;

		public string Number
		{
			get { return _number; }
			set { _number = value; }
		}

		private string _zipcode;

		public string ZipCode
		{
			get { return _zipcode; }
			set { _zipcode = value; }
		}

		private string _city;

		public string City
		{
			get { return _city; }
			set { _city = value; }
		}

	}
}
