﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Domain.Business;

namespace Domain.Persistence
{
	public class PersistenceCode
	{
		//Private properties
		string _connectionString;

        public PersistenceCode()
        {
            //Maak een connectionString die de programmacode verbind met de databank
            _connectionString = "server=localhost; port = 3306; user id=root; persistsecurityinfo = true; database = CliniresearchDB; password = Ratava989";
        }

        //Getting the data from every table
        public List<ClientCode> getClients()
		{
            List<ClientCode> ListClients = new List<ClientCode>();
			MySqlConnection conn = new MySqlConnection(_connectionString);
			MySqlCommand cmd = new MySqlCommand("SELECT Name, Adress, Postal_code AS 'Postal Code', City, Country, Contact_person AS 'Contact Person', Invoice_info AS 'Invoice Info', Kind_of_Client AS 'Kind of Client' FROM cliniresearchdb.tblclient;", conn);
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				//int id = Convert.ToInt16(dataReader["Client_ID"]);
				string name = Convert.ToString(dataReader["Name"]);
				string adress = Convert.ToString(dataReader["Adress"]);
				string postal_code = Convert.ToString(dataReader["Postal Code"]);
				string city = Convert.ToString(dataReader["City"]);
				string country = Convert.ToString(dataReader["Country"]);
				string contact_person = Convert.ToString(dataReader["Contact Person"]);
				string invoice_info = Convert.ToString(dataReader["Invoice Info"]);
				string kind_of_client = Convert.ToString(dataReader["Kind of Client"]);

				ClientCode c = new ClientCode(name,adress,postal_code,city,country,contact_person,invoice_info,kind_of_client);

				ListClients.Add(c);
			}

            conn.Close();
            return ListClients;
		}
		public List<ContractCode> getContract()
		{
            List<ContractCode> ListContract = new List<ContractCode>();
			MySqlConnection conn = new MySqlConnection(_connectionString);
			MySqlCommand cmd = new MySqlCommand("select * from tblContract",conn);
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string legal_country = Convert.ToString(dataReader["Legal_country"]);
				double fee = Convert.ToDouble(dataReader["Fee"]);
				DateTime duration = Convert.ToDateTime(dataReader["Duration"]);
				DateTime date = Convert.ToDateTime(dataReader["Date"]);

				ContractCode c = new ContractCode(legal_country,fee,duration.ToShortDateString(),date.ToShortDateString());

				ListContract.Add(c);
			}

            conn.Close();
            return ListContract;
		}
		public List<CRACode> getCRA()
		{
            List<CRACode> ListCRA = new List<CRACode>();
			MySqlConnection conn = new MySqlConnection(_connectionString);
			MySqlCommand cmd = new MySqlCommand("select * from tblCRA",conn);
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string name = Convert.ToString(dataReader["Name"]);
				string cv = Convert.ToString(dataReader["CV"]);
				string email = Convert.ToString(dataReader["E_mail"]);
				string phone1 = Convert.ToString(dataReader["Phone1"]);
				string phone2 = Convert.ToString(dataReader["Phone2"]);

				CRACode c = new CRACode(name,cv,email,phone1,phone2);

				ListCRA.Add(c);
			}

            conn.Close();
            return ListCRA;
		}
		public List<DepartmentCode> getDepartment()
		{
            List<DepartmentCode> ListDepartment = new List<DepartmentCode>();
			MySqlConnection conn = new MySqlConnection(_connectionString);
			MySqlCommand cmd = new MySqlCommand("select * from tblDepartment",conn);
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string name = Convert.ToString(dataReader["Name"]);
				string email = Convert.ToString(dataReader["E_mail"]);
				string phone1 = Convert.ToString(dataReader["Phone1"]);

				DepartmentCode c = new DepartmentCode(name,email,phone1);

				ListDepartment.Add(c);
			}

            conn.Close();
            return ListDepartment;
		}
		public List<DoctorCode> getDoctor()
		{
            List<DoctorCode> ListDoctor = new List<DoctorCode>();
			MySqlConnection conn = new MySqlConnection(_connectionString);
			MySqlCommand cmd = new MySqlCommand("select * from tblDoctor",conn);
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string name = Convert.ToString(dataReader["Name"]);
				string email = Convert.ToString(dataReader["E_mail"]);
				string phone1 = Convert.ToString(dataReader["Phone1"]);
				string phone2 = Convert.ToString(dataReader["Phone2"]);
				string adress = Convert.ToString(dataReader["Adress"]);
				string postal_code = Convert.ToString(dataReader["Postal_code"]);
				string city = Convert.ToString(dataReader["City"]);
				string country = Convert.ToString(dataReader["Country"]);
				string specialisation = Convert.ToString(dataReader["Specialisation"]);
				string cv = Convert.ToString(dataReader["CV"]);

				DoctorCode c = new DoctorCode(name,email,phone1,phone2,adress,postal_code,city,country,specialisation,cv);

				ListDoctor.Add(c);
			}

            conn.Close();
            return ListDoctor;
		}
		public List<EvaluationCode> getEvaluation()
		{
            List<EvaluationCode> ListEvaluation = new List<EvaluationCode>();
			MySqlConnection conn = new MySqlConnection(_connectionString);
			MySqlCommand cmd = new MySqlCommand("select * from tblEvaluation",conn);
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				DateTime date = Convert.ToDateTime(dataReader["Date"]);
				string feedback = Convert.ToString(dataReader["Feedback"]);
				string accuracy = Convert.ToString(dataReader["Accuracy"]);
				string quality = Convert.ToString(dataReader["Quality"]);
				string evalauation_txt = Convert.ToString(dataReader["Evaluation_txt"]);
				string label = Convert.ToString(dataReader["Label"]);

				EvaluationCode c = new EvaluationCode(date.ToShortDateString(),feedback,accuracy,quality,evalauation_txt,label);

				ListEvaluation.Add(c);
			}

            conn.Close();
            return ListEvaluation;
		}
		public List<HospitalCode> getHospital()
		{
            List<HospitalCode> ListHospital = new List<HospitalCode>();
			MySqlConnection conn = new MySqlConnection(_connectionString);
			MySqlCommand cmd = new MySqlCommand("select * from tblHospital",conn);
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string name = Convert.ToString(dataReader["Name"]);
				string adress = Convert.ToString(dataReader["Adress"]);
				string postal_code = Convert.ToString(dataReader["Postal_code"]);
				string city = Convert.ToString(dataReader["City"]);
				string country = Convert.ToString(dataReader["Country"]);
				string central_number = Convert.ToString(dataReader["Central_number"]);

				HospitalCode c = new HospitalCode(name,adress,postal_code,city,country,central_number);

				ListHospital.Add(c);
			}

            conn.Close();
            return ListHospital;
		}
		public List<ProjectCode> getProject()
		{
            List<ProjectCode> ListProject = new List<ProjectCode>();
			MySqlConnection conn = new MySqlConnection(_connectionString);
			MySqlCommand cmd = new MySqlCommand("select * from tblProject",conn);
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string title = Convert.ToString(dataReader["Title"]);
				DateTime start_date = Convert.ToDateTime(dataReader["Start_date"]).Date;
				DateTime end_date = Convert.ToDateTime(dataReader["End_date"]).Date;

				ProjectCode c = new ProjectCode(title,start_date.ToShortDateString(),end_date.ToShortDateString());

				ListProject.Add(c);
			}

            conn.Close();
            return ListProject;
		}
		public List<ProjectManagerCode> getProjectManager()
		{
            List<ProjectManagerCode> ListProjectManager = new List<ProjectManagerCode>();
			MySqlConnection conn = new MySqlConnection(_connectionString);
			MySqlCommand cmd = new MySqlCommand("select * from tblProjectManager",conn);
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string name = Convert.ToString(dataReader["Name"]);
				string cv = Convert.ToString(dataReader["CV"]);
				string email = Convert.ToString(dataReader["E_mail"]);
				string phone1 = Convert.ToString(dataReader["Phone1"]);
				string phone2 = Convert.ToString(dataReader["Phone2"]);

				ProjectManagerCode c = new ProjectManagerCode(name,cv,email,phone1,phone2);

				ListProjectManager.Add(c);
			}

            conn.Close();
            return ListProjectManager;
		}
		public List<StudyCoördinatorCode> getStudyCoördinator()
		{
            List<StudyCoördinatorCode> ListStudyCoördinator = new List<StudyCoördinatorCode>();
			MySqlConnection conn = new MySqlConnection(_connectionString);
			MySqlCommand cmd = new MySqlCommand("select * from tblStudyCoördinator",conn);
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string name = Convert.ToString(dataReader["Name"]);
				string cv = Convert.ToString(dataReader["CV"]);
				string email = Convert.ToString(dataReader["E_mail"]);
				string phone1 = Convert.ToString(dataReader["Phone1"]);
				string phone2 = Convert.ToString(dataReader["Phone2"]);
				string specialisation = Convert.ToString(dataReader["Specialisation"]);

				StudyCoördinatorCode c = new StudyCoördinatorCode(name,cv,email,phone1,phone2,specialisation);

				ListStudyCoördinator.Add(c);
			}

            conn.Close();
			return ListStudyCoördinator;
		}

		//Setting the data to every table
		public void addClient(string name_p,string adress_p,string postalcode_p,string city_p,string country_p,string contactperson_p,string invoiceinfo_p,string kindofclinet_p)
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);

			conn.Open();

			MySqlCommand cmd = new MySqlCommand("INSERT INTO tblClient (Name, Adress, Postal_code, City, Country, Contact_person, Invoice_info, Kind_of_Client) VALUES (@name, @adress, @postal_code, @city, @country, @contact_person, @invoice_info, @kind_of_client);",conn);

			cmd.Parameters.Add("@name",MySqlDbType.VarChar).Value = name_p;
			cmd.Parameters.Add("@adress",MySqlDbType.VarChar).Value = adress_p;
			cmd.Parameters.Add("@postal_code",MySqlDbType.VarChar).Value = postalcode_p;
			cmd.Parameters.Add("@city",MySqlDbType.VarChar).Value = city_p;
			cmd.Parameters.Add("@country",MySqlDbType.VarChar).Value = country_p;
			cmd.Parameters.Add("@contact_person",MySqlDbType.VarChar).Value = contactperson_p;
			cmd.Parameters.Add("@invoice_info",MySqlDbType.VarChar).Value = invoiceinfo_p;
			cmd.Parameters.Add("@kind_of_client",MySqlDbType.VarChar).Value = kindofclinet_p;
			cmd.ExecuteNonQuery();

			conn.Close();
		}
		public void addContract(string legalcountry_p,double fee_p,DateTime duration_p,DateTime date_p)
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);

			conn.Open();

			MySqlCommand cmd = new MySqlCommand("INSERT INTO tblContract (Legal_country, Fee, Duration, Date) VALUES (@legal_country, @fee, @duration, @date);",conn);

			cmd.Parameters.Add("@legal_country",MySqlDbType.VarChar).Value = legalcountry_p;
			cmd.Parameters.Add("@fee",MySqlDbType.Double).Value = fee_p;
			cmd.Parameters.Add("@duration",MySqlDbType.DateTime).Value = duration_p;
			cmd.Parameters.Add("@date",MySqlDbType.DateTime).Value = date_p;
			cmd.ExecuteNonQuery();

			conn.Close();
		}
		public void addCRA(string name_p,string cv_p,string email_p,string phone1_p,string phone2_p)
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);

			conn.Open();

			MySqlCommand cmd = new MySqlCommand("INSERT INTO tblCRA (Name, CV, E_mail, Phone1, Phone2) VALUES (@name, @cv, @email, @phone1, @phone2);",conn);

			cmd.Parameters.Add("@name",MySqlDbType.VarChar).Value = name_p;
			cmd.Parameters.Add("@cv",MySqlDbType.VarChar).Value = cv_p;
			cmd.Parameters.Add("@email",MySqlDbType.VarChar).Value = email_p;
			cmd.Parameters.Add("@phone1",MySqlDbType.VarChar).Value = phone1_p;
			cmd.Parameters.Add("@phone2",MySqlDbType.VarChar).Value = phone2_p;
			cmd.ExecuteNonQuery();

			conn.Close();
		}
		public void addDepartment(string name_p,string email_p,string phone1_p)
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);

			conn.Open();

			MySqlCommand cmd = new MySqlCommand("INSERT INTO tblDepartment (Name, E_mail, Phone1) VALUES (@name, @email, @phone1);",conn);

			cmd.Parameters.Add("@name",MySqlDbType.VarChar).Value = name_p;
			cmd.Parameters.Add("@email",MySqlDbType.VarChar).Value = email_p;
			cmd.Parameters.Add("@phone1",MySqlDbType.VarChar).Value = phone1_p;
			cmd.ExecuteNonQuery();

			conn.Close();
		}
		public void addDoctor(string name_p,string email_p,string phone1_p,string phone2_p,string adress_p,string postalcode_p,string city_p,string country_p,string specialisation_p,string cv_p)
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);

			conn.Open();

			MySqlCommand cmd = new MySqlCommand("INSERT INTO tblDoctor (Name, E_mail, Phone1, Phone2, Adress, Postal_code, City, Country, Specialisation, CV) VALUES (@name, @email, @phone1, @phone2, @adress, @postal_code, @city, @country, @specialisation, @cv);",conn);

			cmd.Parameters.Add("@name",MySqlDbType.VarChar).Value = name_p;
			cmd.Parameters.Add("@email",MySqlDbType.VarChar).Value = email_p;
			cmd.Parameters.Add("@phone1",MySqlDbType.VarChar).Value = phone1_p;
			cmd.Parameters.Add("@phone2",MySqlDbType.VarChar).Value = phone2_p;
			cmd.Parameters.Add("@adress",MySqlDbType.VarChar).Value = adress_p;
			cmd.Parameters.Add("@postal_code",MySqlDbType.VarChar).Value = postalcode_p;
			cmd.Parameters.Add("@city",MySqlDbType.VarChar).Value = city_p;
			cmd.Parameters.Add("@country",MySqlDbType.VarChar).Value = country_p;
			cmd.Parameters.Add("@specialisation",MySqlDbType.VarChar).Value = specialisation_p;
			cmd.Parameters.Add("@cv",MySqlDbType.VarChar).Value = specialisation_p;
			cmd.ExecuteNonQuery();

			conn.Close();
		}
		public void addEvaluation(DateTime date_p,string feedback_p,string accuracy_p,string quality_p,string evaluationtxt_p,string label_p)
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);

			conn.Open();

			MySqlCommand cmd = new MySqlCommand("INSERT INTO tblEvaluation (Date, Feedback, Accuracy, Quality, Evaluation_txt, Label) VALUES (@date, @feedback, @accuracy, @quality, @evaluation_txt, @label);",conn);

			cmd.Parameters.Add("@date",MySqlDbType.Date).Value = date_p;
			cmd.Parameters.Add("@feedback",MySqlDbType.VarChar).Value = feedback_p;
			cmd.Parameters.Add("@accuracy",MySqlDbType.VarChar).Value = accuracy_p;
			cmd.Parameters.Add("@quality",MySqlDbType.VarChar).Value = quality_p;
			cmd.Parameters.Add("@evaluation_txt",MySqlDbType.VarChar).Value = evaluationtxt_p;
			cmd.Parameters.Add("@label",MySqlDbType.VarChar).Value = label_p;

			cmd.ExecuteNonQuery();

			conn.Close();
		}
		public void addHospital(string name_p,string adress_p,string postalcode_p,string city_p,string country_p,string centralnumber_p)
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);

			conn.Open();

			MySqlCommand cmd = new MySqlCommand("INSERT INTO tblHospital (Name, Adress, Postal_code, City, Country, Central_number) VALUES (@name, @adress, @postal_code, @city, @country, @central_number);",conn);

			cmd.Parameters.Add("@name",MySqlDbType.VarChar).Value = name_p;
			cmd.Parameters.Add("@adress",MySqlDbType.VarChar).Value = adress_p;
			cmd.Parameters.Add("@postal_code",MySqlDbType.VarChar).Value = postalcode_p;
			cmd.Parameters.Add("@city",MySqlDbType.VarChar).Value = city_p;
			cmd.Parameters.Add("@country",MySqlDbType.VarChar).Value = country_p;
			cmd.Parameters.Add("@central_number",MySqlDbType.VarChar).Value = centralnumber_p;
			cmd.ExecuteNonQuery();

			conn.Close();
		}
		public void addProject(string title_p,DateTime startdate_p, DateTime enddate_p)
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);

			conn.Open();

			MySqlCommand cmd = new MySqlCommand("INSERT INTO tblProject (Title, Start_date, End_date) VALUES (@title, @start_date, @end_date);",conn);

			cmd.Parameters.Add("@title",MySqlDbType.VarChar).Value = title_p;
			cmd.Parameters.Add("@start_date",MySqlDbType.Date).Value = startdate_p.Date;
			cmd.Parameters.Add("@end_date",MySqlDbType.Date).Value = enddate_p.Date;
			cmd.ExecuteNonQuery();

			conn.Close();
		}
		public void addProjectManager(string name_p,string cv_p,string email_p,string phone1_p,string phone2_p)
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);

			conn.Open();

			MySqlCommand cmd = new MySqlCommand("INSERT INTO tblProjectManager (Name, CV, E_mail, Phone1, Phone2) VALUES (@name, @cv, @email, @phone1, @phone2);",conn);

			cmd.Parameters.Add("@name",MySqlDbType.VarChar).Value = name_p;
			cmd.Parameters.Add("@cv",MySqlDbType.VarChar).Value = cv_p;
			cmd.Parameters.Add("@email",MySqlDbType.VarChar).Value = email_p;
			cmd.Parameters.Add("@phone1",MySqlDbType.VarChar).Value = phone1_p;
			cmd.Parameters.Add("@phone2",MySqlDbType.VarChar).Value = phone2_p;
			cmd.ExecuteNonQuery();

			conn.Close();
		}
		public void addStudyCoördinator(string name_p,string cv_p,string email_p,string phone1_p,string phone2_p,string specialisation_p)
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);

			conn.Open();

			MySqlCommand cmd = new MySqlCommand("INSERT INTO tblStudyCoördinator(Name, CV, E_mail, Phone1, Phone2, Specialisation) VALUES (@name, @cv, @email, @phone1, @phone2, @specialisation);",conn);

			cmd.Parameters.Add("@name",MySqlDbType.VarChar).Value = name_p;
			cmd.Parameters.Add("@cv",MySqlDbType.VarChar).Value = cv_p;
			cmd.Parameters.Add("@email",MySqlDbType.VarChar).Value = email_p;
			cmd.Parameters.Add("@phone1",MySqlDbType.VarChar).Value = phone1_p;
			cmd.Parameters.Add("@phone2",MySqlDbType.VarChar).Value = phone2_p;
			cmd.Parameters.Add("@specialisation",MySqlDbType.VarChar).Value = specialisation_p;
			cmd.ExecuteNonQuery();

			conn.Close();
		}

	}
}