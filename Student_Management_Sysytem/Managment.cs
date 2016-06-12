using System;
using NameSpaceStudents;
using NameSpaceStudent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Management
{
	public class Managment
	{
		public static void Main(string[] args)
		{
			string name;
			string className;
			string state;
			string phoneNo;
			string emailId;
			Students student = new Students ();
		Start:
			Console.WriteLine ("\nChoose the option :\n");
			Console.WriteLine ("1. Registration\t");
			Console.WriteLine ("2. Search Details\t");
			Console.WriteLine ("3. Update Details \t");
			Console.WriteLine ("4. Delete Details\t");
			Console.WriteLine ("5. Display All Deatails\n");

			int Selection = Convert.ToInt32(Console.ReadLine());

			switch (Selection) {
			case 1:

				while (true) {
					Console.WriteLine ("Name");
					name = Console.ReadLine ();
					Console.WriteLine ("Class");
					className = Console.ReadLine ();
					Console.WriteLine ("State");
					state = Console.ReadLine ();
					Console.WriteLine ("Phone Number");
					phoneNo = Console.ReadLine ();
					Console.WriteLine ("Email Id");
					emailId = Console.ReadLine ();
					student.Insert (name, className, state, phoneNo, emailId);
					Console.WriteLine ("Do you want to entry more student details[y/n]");
					string UserInput = Console.ReadLine ();
					if (UserInput != "y") {
						goto Start;

					}
				}


			case 2:
				Console.WriteLine ("Enter the name for search");
				string SearchName = Console.ReadLine ();

				if (student.Search (SearchName)) {

					var studentList = student.StudentList.FirstOrDefault (x => x.EmailId == SearchName);
					Console.WriteLine ("{0}\t{1}\t{2}\t{3}\t{4}",studentList.Name,studentList.Class,studentList.State,studentList.PhoneNo,studentList.EmailId);
				} else {
					Console.WriteLine ("Data Not Found");
				}
				goto Start;

			case 3:
				Console.WriteLine ("Enter the emailid for Update");
				string searchEmail = Console.ReadLine ();

				if (student.Update (searchEmail)) {

					var studentList = student.StudentList.FirstOrDefault (x => x.EmailId == searchEmail);
					Console.WriteLine ("Name");
					studentList.Name = Console.ReadLine ();
					Console.WriteLine ("Class");
					studentList.Class = Console.ReadLine ();
					Console.WriteLine ("State");
					studentList.State = Console.ReadLine ();
					Console.WriteLine ("Phone Number");
					studentList.PhoneNo = Console.ReadLine ();

					Console.Write("Data Updated");
				} else {
					Console.WriteLine ("Data Not Found");
				}

				goto Start;
			case 4:
				break;
			case 5:
				Console.WriteLine ("Name\tClass\tState\tPhoneNo.\tEmailId");
				Console.WriteLine(student.Print ());
				goto Start;
			default:
				break;

			}

			
		}
	}
}