﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Business
{
	public class ClientCode
	{

        // Alle private en public properties van de class Clënt

        private int _client_id;

        public int Client_ID
        {
            get { return _client_id; }
            set { _client_id = value; }
        }

        private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _adress;

		public string Adress
		{
			get { return _adress; }
			set { _adress = value; }
		}

		private string _postal_code;

		public string Postal_Code
		{
			get { return _postal_code; }
			set { _postal_code = value; }
		}

		private string _city;

		public string City
		{
			get { return _city; }
			set { _city = value; }
		}

		private string _country;

		public string Country
		{
			get { return _country; }
			set { _country = value; }
		}

		private string _contact_person;

		public string Contact_Person
		{
			get { return _contact_person; }
			set { _contact_person = value; }
		}

		private string _invoice_info;

		public string Invoice_Info
		{
			get { return _invoice_info; }
			set { _invoice_info = value; }
		}

		private string _kind_of_client;

		public string Kind_of_Client
		{
			get { return _kind_of_client; }
			set { _kind_of_client = value; }
		}

        private int _user_id;

        public int User_ID
        {
            get { return _user_id; }
            set { _user_id = value; }
        }

        private DateTime _date_added;

        public DateTime Date_Added
        {
            get { return _date_added; }
            set { _date_added = value; }
        }

        private DateTime _date_last_edited;

        public DateTime Date_Last_Edited
        {
            get { return _date_last_edited; }
            set { _date_last_edited = value; }
        }
        
        public ClientCode(int ID_p, string Name_p, string Adress_p, string Postal_code_p, string City_p, string Country_p, string Contact_person_p, string Invoice_info_p, string Kind_of_client_p, 
            int User_ID_p, DateTime Date_Added_p, DateTime Date_Last_Edited_p)
        {
            _client_id = ID_p;
            _name = Name_p;
            _adress = Adress_p;
            _postal_code = Postal_code_p;
            _city = City_p;
            _country = Country_p;
            _contact_person = Contact_person_p;
            _invoice_info = Invoice_info_p;
            _kind_of_client = Kind_of_client_p;
            _user_id = User_ID_p;
            _date_added = Date_Added_p;
            _date_last_edited = Date_Last_Edited_p;
        }

    }
}
