using System.Collections.Generic;



namespace AddressBook
{
	public class Contact
	{
		//VARIABLES
		private string _name;
		private string _address;
		private string _phoneNumber;
		private int _id;
		private bool  _doesExist;
		private static List<Contact> _instances = new List<Contact> {};
		//CONSTRUCTOR
		public Contact(string name, string address, string phoneNumber)
		{
			_name = name;
			_address = address;
			_phoneNumber = phoneNumber;
			_doesExist = true;
			_id = _instances.Count;
    
		}
		//Getters and Setters
		public  string GetName()
		{
			return _name;
		}
		public int GetId()
		{
			return _id;
		}

		public string GetAddress()
		{
			return _address;
		}

		public string GetPhoneNumber()
		{
			return _phoneNumber;
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
