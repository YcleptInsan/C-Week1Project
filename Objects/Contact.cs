using System.Collections.Generic;


namespace AddressBook.Objects
{
	public class Contact
	{
		//VARIABLES
		private string _name;
		private string _address;
		private string _phoneNumber;
		private int _id;
		private static List<Contact> _instances = new List<Contact> {};
		//CONSTRUCTOR
		public Contact(string newDescription, string newAddress, string newPhoneNumber)
		{
			_name = newName;
			_address = newAddress;
			_phoneNumber = newPhoneNumber;
			_doesExist = true;
		}
		//Getters and Setters
		public  string GetDescription()
		{
			return _description;
		}
		public int GetId()
		{
			return _id;
		}
		public void SetDescription(string Description)
		{
			_description = Description;
		}
		public string GetAddress()
		{
			return _address;
		}
		public void SetAddress(string Address)
		{
			_address = Address;
		}
		public string GetPhoneNumber()
		{
			return _phoneNumber;
		}
		public void SetPhoneNumber(string PhoneNumber)
		{
			_phoneNumber = PhoneNumber;
		}
		public static List<Contact> GetAll()
		{
			return _instances;
		}
		public static void ClearAll()
		{
			_instances.Clear();
		}
		public static Contact Find(int searchId)
		{
			return _instances[searchId];
		}
		public bool GetExistence()
		{
			return _doesExist;
		}
		public void SetExistance(bool newExistence)
		{
			_doesExist = newExistence;
		}
	}
}
