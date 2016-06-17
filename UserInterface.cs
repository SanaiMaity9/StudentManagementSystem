using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentManagementSystem
{
	public class UserInterface
	{
		Administrator administrator = new Administrator ();

		public  void Options()
		{
			Console.WriteLine ("\nChoose the option :\n");
			Console.WriteLine ("1. Registration\t");
			Console.WriteLine ("2. Search student those have maths as subject\t");
			Console.WriteLine ("3. Search teacher who teaches maths\t");
			Console.WriteLine ("5. Display All Deatails\t");
			Console.WriteLine ("6. Exit\n");

			int Selection;
			bool conversionSucceed = int.TryParse(Console.ReadLine(), out Selection);
			if (conversionSucceed) {
				this.DecisionHandler(Selection);
			} else {
				Console.WriteLine ("Invalid input");
				this.Options ();
			}
		}

		public void DecisionHandler(int Selection)
		{
			
			switch (Selection) {
			case 1:
				this.InsertDecision ();
				break;
			case 2:
			Console.WriteLine("enter the subject");
			string a = Console.ReadLine();
			administrator.SearchBySubject(a,1);
			this.Options();
				break;
			case 3:
			Console.WriteLine("enter the subject");
			string x = Console.ReadLine();
			administrator.SearchBySubject(x,2);
			this.Options();
			break;
			case 5:
			this.DisplayDecision();
				break;
			case 6:
				System.Environment.Exit (1);
				break;
			default:
				Console.WriteLine ("Invalid Input");
				this.Options ();
				break;

			}
		}
        
		
		
		
		
		
		public void DisplayDecision()
		{
			Console.WriteLine ("\nChoose the option :\n");
			Console.WriteLine ("1. Student\t");
			Console.WriteLine ("2. Teacher\n");
			int Selection;
			bool conversionSucceed = int.TryParse(Console.ReadLine(), out Selection);
			if (conversionSucceed) {
				switch (Selection) {
					case 1:
					this.StudentDisplayFormat();
					this.PrintStudent();
					break;
				case 2:
					this.TeacherDisplayFormat();
					this.PrintTeacher();
					break;
					default:
					Console.WriteLine ("Invalid Input");
					this.Options ();
					break;
				}
			} else {
				Console.WriteLine ("Invalid input");
				this.DisplayDecision ();
			}
			this.Options ();
		}

		public void TeacherDisplayFormat()
		{
			string PrintFormat = "Name\t";
					int Limit = administrator.GetClassCount();
					for (int i = 1; i < Limit + 1; i++) 
					{
						PrintFormat += "Class" + i + "\t";
					}
					PrintFormat += "State\tPhoneNo\tSubject\tEmailId";
					Console.WriteLine (PrintFormat);
		}
		public void StudentDisplayFormat()
		{
			string PrintFormat = "Name\tClass\tState\tPhoneNo\t";
					int Limit = administrator.GetSubjectCount();
					for (int i = 1; i < Limit + 1; i++) 
					{
						PrintFormat += "Subject" + i + "\t";
					}
					PrintFormat += "EmailId";
					Console.WriteLine (PrintFormat);
		}

		public void InsertDecision()
		{
			Console.WriteLine ("\nChoose the option :\n");
			Console.WriteLine ("1. Student\t");
			Console.WriteLine ("2. Teacher\n");
			int Selection;
			bool conversionSucceed = int.TryParse(Console.ReadLine(), out Selection);
			if (conversionSucceed) {
				switch (Selection) {
					case 1:
					this.StudentDetails ();
					break;
				case 2:
					this.TeacherDetails();
					break;
					default:
					Console.WriteLine ("Invalid Input");
					this.Options ();
					break;
				}
			} else {
				Console.WriteLine ("Invalid input");
				this.InsertDecision ();
			}
			this.Options ();
		}
      
	  public void TeacherDetails()
		{
			string name, state, phoneNo,emailId;
			string[] classNames = new string[3];
			string[] subject = new string[3];
			while (true) {
				Console.WriteLine ("Name");
				name = Console.ReadLine ();
				classNames = new string[3];
				this.NoOfClasses (classNames);
				Console.WriteLine ("State");
				state = Console.ReadLine ();
				Console.WriteLine ("Phone Number");
				phoneNo = Console.ReadLine ();
				Console.WriteLine ("Subject");
				subject[0] = Console.ReadLine();
				Console.WriteLine ("Email Id");
				emailId = Console.ReadLine ();
				Teacher  teacher = new Teacher(name,classNames,state,phoneNo,subject,emailId);
				administrator.Insert(teacher);
				this.Options ();

			}
		}
			public void NoOfClasses(string[] className)
		{
		  int i = 0;
			while (i < 3) {
				Console.WriteLine ("Class");
				int classes;
				bool conversionSucceed = int.TryParse(Console.ReadLine(), out classes);
				if (conversionSucceed) {
					className [i] = classes.ToString();
					if (i < 2) {
						Console.WriteLine ("Do you want to enter more classes[y/n]");
						string x = Console.ReadLine ();
						if (x != "y") {
							break;
						}
					}
				} else {
					Console.WriteLine ("Invalid input");
					i--;
				}
				i++;
			}
        }

       	public void StudentDetails()
		{
			string name, state, phoneNo,emailId;
			string[] classNames = new string[3];
			string[] subject = new string[3];
			while (true) {
				Console.WriteLine ("Name");
				name = Console.ReadLine ();
				Console.WriteLine ("Class");
				classNames[0] = Console.ReadLine ();
				Console.WriteLine ("State");
				state = Console.ReadLine ();
				Console.WriteLine ("Phone Number");
				phoneNo = Console.ReadLine ();
				subject = new string[10];
				this.NoOfSubjects(subject);
				Console.WriteLine ("Email Id");
				emailId = Console.ReadLine ();
				Student  student = new Student(name,classNames,state,phoneNo,subject,emailId);
				administrator.Insert(student);
			    this.Options ();

			}
		}
		
		public void NoOfSubjects(string[] subject)
		{
			
		  int i = 0;
			while (i < 10) {
				Console.WriteLine ("subject");
					subject [i] = Console.ReadLine();
					if (i < 9) {
						Console.WriteLine ("Do you want to enter more subject[y/n]");
						string x = Console.ReadLine ();
						if (x != "y") {
							break;
						}
				} else {
					Console.WriteLine ("Invalid input");
					i--;
				}
				i++;
			}
       }
	   public void PrintStudent()
	    {
				foreach(var item in administrator.MemberList)
				{
					Console.WriteLine(item.student.Print());
				}
			    this.Options ();
		}
		
		public void PrintTeacher()
	    {
				foreach(var item in administrator.MemberList)
				{
					Console.WriteLine(item.teacher.Print());
				}
			    this.Options ();
		}	


	}
}