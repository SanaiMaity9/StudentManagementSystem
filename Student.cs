using System;
using System.Collections.Generic;
using System.IO;

namespace NameSpaceStudent
{
	public class Student 
	{
		public string Name;
		public string Class;
		public string State;
		public string PhoneNo;
		public string EmailId;

	
		public  Student( string name , string className , string state , string phoneNo , string emailId )
		{
			this.Name = name;
			this.Class = className;
			this.State = state;
			this.PhoneNo = phoneNo;
			this.EmailId = emailId;
		}
	
		public String GetPrintable(){
		
			string format;
			format = Name + "\t" + Class + "\t" + State + "\t" + PhoneNo + "\t" + EmailId;
			return format;
		}
	}



}