using System;
using System.IO;

namespace StudentManagementSystem
{
     public class PersonalDetails
    {
        private string Name { get; set; }
		private string[] Standard = new string[3]; 
		private  string State { get; set; }
		private string PhoneNo { get; set; }
        private string[] Subject = new string[10];
        private  string EmailId { get; set; }
        
       public void  Details(string name, string[] standard, string state, string phoneNo, string[] subject, string emailId)
       {
           Array.Clear(Subject,0,Subject.Length);
           Name = name;
           Standard = standard;
           State = state;
           PhoneNo = phoneNo;
           Subject = subject;
           EmailId = emailId;
       }
       
       public String GetTeacherPrintable(){
			int i = 0;
			string format;
			format = Name + "\t";
			foreach(var item in Standard)
			{
				if(item != null)
				{
				    format += Standard[i] + "\t";	
					i++;
				}
			}
			format	+=  State + "\t" + PhoneNo + "\t" + Subject[0] + "\t" + EmailId;
			return format;
		}
        
       public string GetStudentPrintable()
       {
           int i = 0;
			string format;
			format = Name + "\t" + Standard[0] + "\t" + State + "\t" + PhoneNo + "\t" ;
            foreach(var item in Subject)
			{
				if(item != null)
				{
				    format += Subject[i] + "\t";	
					i++;
				}
			}
            format	+=  EmailId;
            
			return format;
           
       }
       
       public Array GetClass()
       {
           return Standard;
       }
       public Array GetSubject()
       {
           return Subject;
       }
     
    }
}