using System;
using System.Collections.Generic;
using System.IO;

namespace NameSpaceTeacher
{
	public class Teacher
	{
		public string Name;
		public string[] Class = new string[100];
		public string State;
		public string PhoneNo;
		public string Subject;
		public string EmailId;


		public  Teacher( string name , string[] className , string state , string phoneNo , string subject , string emailId )
		{
			int i = 0;
			this.Name = name;
			while(className[i] != null)
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
			while(Class[i] != null)
			{
				format += Class[i] + "\t";
				i++;

			}
				format	+=  State + "\t" + PhoneNo + "\t" + Subject + "\t" + EmailId;
			return format;
		}
	}

}


