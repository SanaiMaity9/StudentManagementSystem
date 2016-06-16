using System;
using System.IO;

namespace StudentManagementSystem
{
    class SaveDetails
    {
        string name;
	    string[] className = new string[3];
		string state;
		string phoneNo;
		string[] subject = new string[10];
		string emailId;
        Student StudentObj = new Student();
		Administrator administrator = new Administrator ();
        UserInterface userinterface = new UserInterface();
        
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
					
					break;
					default:
					Console.WriteLine ("Invalid Input");
					userinterface.Options();
					break;
				}
			} else {
				Console.WriteLine ("Invalid input");
				this.InsertDecision ();
			}
			userinterface.Options();
		}
      
	  public void TeacherDetails()
		{
			while (true) {
				Console.WriteLine ("Name");
				name = Console.ReadLine ();
				this.NoOfClasses ();
				Console.WriteLine ("State");
				state = Console.ReadLine ();
				Console.WriteLine ("Phone Number");
				phoneNo = Console.ReadLine ();
				Console.WriteLine ("Subject");
				subject[0] = Console.ReadLine();
				Console.WriteLine ("Email Id");
				emailId = Console.ReadLine ();
				Teacher  teacher = new Teacher(name,className,state,phoneNo,subject,emailId);
				administrator.Insert(teacher);
				userinterface.Options();

			}
		}
			public void NoOfClasses()
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
			while (true) {
				Console.WriteLine ("Name");
				name = Console.ReadLine ();
				Console.WriteLine ("Class");
				className[0] = Console.ReadLine ();
				Console.WriteLine ("State");
				state = Console.ReadLine ();
				Console.WriteLine ("Phone Number");
				phoneNo = Console.ReadLine ();
				this.NoOfSubjects();
				Console.WriteLine ("Email Id");
				emailId = Console.ReadLine ();
				Student  student = new Student(name,className,state,phoneNo,subject,emailId);
				administrator.Insert(student);
			    userinterface.Options();

			}
		}
        
        public void NoOfSubjects()
		{
			Array.Clear(subject,0,subject.Length);
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

    }
}