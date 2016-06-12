using System;
using NameSpaceStudents;
using NameSpaceStudent;
using System.Collections.Generic;
using System.IO;

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

			while(true) {
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
			check:
				Console.WriteLine ("Do you want to entry more student details[y/n]");
				string UserInput = Console.ReadLine ();
			
				if (UserInput == "n")
				{
					break;
				}
				else if (UserInput == "y")
				{
					continue;
				} 
				else
				{
					Console.WriteLine ("Invalid input");
					goto check;
				}
			}
			Console.WriteLine (student.Print ());


		}
	}
}

