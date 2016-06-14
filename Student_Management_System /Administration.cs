using System;
using NameSpaceUniversity;
using NameSpaceStudent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Administration
{
	public class Administration
	{
	    string name;
	    string className;
		string state;
		string phoneNo;
		string emailId;
		University student = new University ();

		public static void Main(string[] args)
		{
			Administration administration = new Administration ();
			administration.Options ();
		}

		public  void Options()
		{
			Console.WriteLine ("\nChoose the option :\n");
			Console.WriteLine ("1. Registration\t");
			Console.WriteLine ("2. Search Details\t");
			Console.WriteLine ("3. Update Details \t");
			Console.WriteLine ("4. Delete Details\t");
			Console.WriteLine ("5. Display All Deatails\t");
			Console.WriteLine ("6. Exit\n");

			int Selection;
			bool conversionSucceed = int.TryParse(Console.ReadLine(), out Selection);
			if (conversionSucceed) {
				this.SwitchCase(Selection);
			} else {
				Console.WriteLine ("Invalid input");
				this.Options ();
			}
		}

		public void SwitchCase(int Selection)
		{
			
			switch (Selection) {
			case 1:
				this.StudentDetails ();
				break;

			case 2:
				this.SearchStudent ();
				break;

			case 3:
				this.UpdateStudent ();
				break;
			case 4:
				this.DeleteStudent ();
				break;
			case 5:
				Console.WriteLine ("Name\tClass\tState\tPhoneNo.\tEmailId");
				Console.WriteLine (student.Print ());
				this.Options ();
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

		public void StudentDetails()
		{
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
					this.Options ();

			}
		}

		public void SearchStudent()
		{
			Console.WriteLine ("Enter the name for search");
			string SearchName = Console.ReadLine ();

				if (student.Search (SearchName)) {
					var studentList = student.StudentList.Find(x => x.Name.Contains(SearchName));
					Console.WriteLine ("{0}\t{1}\t{2}\t{3}\t{4}", studentList.Name, studentList.Class, studentList.State, studentList.PhoneNo, studentList.EmailId);
				} else {
					Console.WriteLine ("Data Not Found");
			
				}

			this.Options();
		}

		public  void UpdateStudent()
		{
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
			this.Options();
		}

		public void DeleteStudent()
		{
			Console.WriteLine ("Enter the name for Delete");
			string SearchEmail = Console.ReadLine ();

			if (student.Update (SearchEmail)) {
				var index = student.StudentList.FindIndex(i => i.EmailId == SearchEmail);
				student.StudentList.RemoveAt (index);
				Console.WriteLine ("Data Deleted");
			} else {
				Console.WriteLine ("Data Not Found");

			}

			this.Options();
		}

	}
}