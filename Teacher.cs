using System;
using System.Collections.Generic;
using System.IO;



namespace StudentManagementSystem
{
	
	public class Teacher : PersonalDetails
	{
		public  Teacher( string name, string[] standard, string state, string phoneNo, string[] subject, string emailId )
		{
			base.Details(name,standard,state,phoneNo,subject,emailId);
			
		}
		public Teacher()
		{
			
		}
		public string print()
        {
            return base.GetTeacherPrintable();
        }
		
		
	}

}


