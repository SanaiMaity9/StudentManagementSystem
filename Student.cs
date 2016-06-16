using System;
using System.Collections.Generic;
using System.IO;


namespace StudentManagementSystem
{
	
	public class Student : PersonalDetails
    {
		
		
		public  Student( string name, string[] standard, string state, string phoneNo, string[] subject, string emailId )
		{
			base.Details(name,standard,state,phoneNo,subject,emailId);
			
		}
		
		public Student()
		{
			
		}
		
		public string print()
        {
            return base.GetStudentPrintable() ;
            
        }
		
	}
}