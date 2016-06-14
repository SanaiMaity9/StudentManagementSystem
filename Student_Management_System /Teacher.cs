using System;
using System.Collections.Generic;
using System.IO;

namespace NameSpaceTeacher
{
	public class Teacher
	{
		public string Name;
		public string[] Class;
		public string State;
		public string PhoneNo;
		public string Subject;
		public string EmailId;


		public  Teacher( string name , string[] className , string state , string phoneNo , string subject , string emailId )
		{
			int i = 0;
			this.Name = name;
			foreach(var x in className)
			{
			this.Class[i] = x.ToString();
				i++;

			}
			this.State = state;
			this.PhoneNo = phoneNo;
			this.Subject = subject;
			this.EmailId = emailId;
		}

		public String GetPrintable(){

			string format;
			format = Name + "\t" + Class + "\t" + State + "\t" + PhoneNo + "\t" + Subject + "\t" + EmailId;
			return format;
		}
	}

}


