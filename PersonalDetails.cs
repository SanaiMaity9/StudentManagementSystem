using System;
using System.IO;
using System.Text;

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
            
           Name = name;
           Standard = standard;
           State = state;
           PhoneNo = phoneNo;
           Subject = subject;
           EmailId = emailId;
       }
       
       public String Print()
       {
			StringBuilder format = new StringBuilder();
            format.Append(Name +"\t");
            format.Append(string.Join("\t",Standard));
            format.Append(State +"\t");
            format.Append(PhoneNo +"\t");
            format.Append(string.Join("\t",Subject));
            format.Append(EmailId +"\t");
            return format.ToString();
		}

        private bool join(string v, string[] standard)
        {
            throw new NotImplementedException();
        }
       public String[] GetClass()
       {
           return Standard;
       }
       public string[] GetSubject()
       {
           return Subject;
       }
     
    }
}