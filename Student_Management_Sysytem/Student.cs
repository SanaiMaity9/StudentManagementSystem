using System;
using System.Collections.Generic;
using System.IO;

namespace StudentManagementSysytem
{
	public class Repository : Student
	{
		public void  Choice()
		{
			Console.WriteLine ("\nChoose the option :\n");
			Console.WriteLine ("1. Registration\t");
			Console.WriteLine ("2. Searching\t");
			Console.WriteLine ("3. Update Details");
			Console.WriteLine ("4. Delete Details");
			Console.WriteLine ("5. Exit\n");
			//string input = Console.ReadLine();
			int selection =Convert.ToInt32(Console.ReadLine()); ;
			Process (selection);
		
		}
		

		public void Insert(ref List<List<string>>  ListParameter,ref List<String> ListDetailsParameter,int SwitchSelection)
		{
			int Limit = 0;
			if (SwitchSelection == 1) 
			{
				Limit = 5;
			}
			else if (SwitchSelection == 2)
			{
				Limit = 6;
			} 
			else 
			{
				Limit = 5;
			}
			for (int i = 0;; i++)
			{
				if (i == 0)
				{
					goto Start;
				}
				Check:
					if (i > 0) 
				{
					Console.WriteLine ("Do you want to entry more student details[y/n]");

					string s = Console.ReadLine ().ToString ();
					if (s == "n")
					{ // Check string
						this.Choice();
					}
					else if (s == "y")
					{
						goto Start;
					} 
					else
					{
						Console.WriteLine ("Invalide input");
						goto Check;
					}

				}
				Start:
					for (int v = 0; v < Limit; v++) 
				{
					switch (v)
					{
						case 0:
						Console.WriteLine ("Name");
						break;
						case 1:
						Console.WriteLine ("Email id");
						break;
						case 2:
						Console.WriteLine ("Phone no");
						break;
						case 3:
						Console.WriteLine ("Class");
						break;
					    case 4:
						Console.WriteLine ("State");
						break;
					    case 5:
						if (SwitchSelection == 2) {
							Console.WriteLine ("Subject");
						}
						break;
						default:
						break;
					}

					ListDetailsParameter.Add (Console.ReadLine ());
				}
				ListParameter.Add (ListDetailsParameter);
			}
		}

		public void Search(ref List<String> ListDetailsParameter,int SwitchSelection)
		{
			Console.WriteLine ("Enter the name of the student you want to find");
			string SearchName = Console.ReadLine ();
			int index = ListDetailsParameter.IndexOf (SearchName);
			if (ListDetailsParameter.Contains (SearchName)) {
				for (var i = index; i < ListDetailsParameter.Count && i <= index + 4; i++) {
					if (i == index) {
						Console.WriteLine ("\nName");
					}
					if (i == index + 1) {
						Console.WriteLine ("Email id");
					}
					if (i == index + 2) {
						Console.WriteLine ("Phone no");
					}
					if (i == index + 3) {
						Console.WriteLine ("Class");
					}
					if (i == index + 4) {
						Console.WriteLine ("State");
					}
					Console.WriteLine ("{0}", ListDetailsParameter [i]);
				}
				Console.WriteLine ();
			} else
			{
				Console.WriteLine ("Not Found");
			}

			Choice ();
		}


	}


	public class Student
	{
		public void Process(int UserInput)
		{
			List<List<string>> _student = new List<List<string>> ();
			List<string> student_Details = new List<string> ();

			List<List<string>> teacher = new List<List<string>> ();
			List<string> teacher_Details = new List<string> ();

			Repository Details = new Repository ();


				switch (UserInput) 
			{

				case 1:
				Console.WriteLine ("\nChoose the option for Registration :\n");
				Console.WriteLine ("1. Student\t");
				Console.WriteLine ("2. Teacher\n");


				int Reg_Selection = Convert.ToInt32(Console.ReadLine());;

				switch (Reg_Selection) {
					// student entry
					case 1:
					Details.Insert (ref _student,ref student_Details,1);
					break;
					// teacher entry 
					case 2:
					Details.Insert (ref teacher, ref teacher_Details, 2);
					break;
				default:
					break;
				}
				break;
			case 2:
				Console.WriteLine ("\nSearching for :\n");
				Console.WriteLine ("1. Student\t");
				Console.WriteLine ("2. Teacher\n");
				int searchSelection = Convert.ToInt32 (Console.ReadLine ());
				switch (searchSelection) {
					// student search
					case 1:
					Details.Search (ref student_Details,1);
					break;
					// teacher search 
					case 2:
					Details.Search (ref teacher_Details, 2);
					break;
					default:
					break;
				}
				break;
			case 5:
				System.Environment.Exit (1);
				break;
				default:
				break;
			}
		}

		static void Main(string[] args) 
		{
			Repository Details = new Repository ();
			Details.Choice();
		}
	}
}