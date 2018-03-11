﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Business
{
	public class ProjectManagerCode
	{

		// All private and public properties of class Project Manager
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _cv;

		public string CV
		{
			get { return _cv; }
			set { _cv = value; }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		private string _phone1;

		public string Phone1
		{
			get { return _phone1; }
			set { _phone1 = value; }
		}

		private string _phone2;

		public string Phone
		{
			get { return _phone2; }
			set { _phone2 = value; }
		}

		// All constructors

		public ProjectManagerCode()
		{

		}

		public ProjectManagerCode(string name_p,string cv_p,string email_p,string phone1_p,string phone2_p)
		{
			_name = name_p;
			_cv = cv_p;
			_email = email_p;
			_phone1 = phone1_p;
			_phone2 = phone2_p;
		}

	}
}