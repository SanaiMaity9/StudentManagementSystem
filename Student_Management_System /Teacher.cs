using System;
using System.Collections.Generic;
using System.IO;

namespace NameSpaceTeacher
{
	public class Teacher 
	{
		public string Name;
		public string[] Class = new string[3];
		public string State;
		public string PhoneNo;
		public string Subject;
		public string EmailId;


		public  Teacher( string name , string[] className , string state , string phoneNo , string subject , string emailId )
		{
			Array.Clear(Class, 0, Class.Length);
			int i = 0;
			this.Name = name;
		bool check = className [i] != null;
			while(check && i < 3)
			{
				this.Class[i] = className[i];
				i++;
			}
			this.State = state;
			this.PhoneNo = phoneNo;
			this.Subject = subject;
			this.EmailId = emailId;
		}
	
		public String GetPrintable(){
			int i = 0;
			string format;
			format = Name + "\t";
			bool check = Class [i] != null;
			while(check && i < 3)
			{
				format += Class[i] + "\t";
				i++;

			}
				format	+=  State + "\t" + PhoneNo + "\t" + Subject + "\t" + EmailId;
			return format;
		}
	}

}


