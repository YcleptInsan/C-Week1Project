using System.Collections.Generic;


namespace AddressBook.Objects
{
	public class Contact
	{
		//VARIABLES
		private string _description;
		// private string _address;
		// private string _phoneNumber;
		private int _id;
		private bool _doesExist;
		private static List<Contact> _instances = new List<Contact> {};
		//CONSTRUCTOR
		public Contact(string newDescription)
		{
			_description = newDescription;
			// _address = newAddress;
			// _phoneNumber = newPhoneNumber;
			_id = _instances.Count;
			_instances.Add(this);
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
		public void SetDescription(string newDescription)
		{
			_description = newDescription;
		}
		// public string GetAddress()
		// {
		// 	return _address;
		// }
		// public void SetAddress(string newAddress)
		// {
		// 	_address = newAddress;
		// }
		// public string GetPhoneNumber()
		// {
		// 	return _phoneNumber;
		// }
		// public void SetPhoneNumber(string newPhoneNumber)
		// {
		// 	_phoneNumber = newPhoneNumber;
		// }
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
