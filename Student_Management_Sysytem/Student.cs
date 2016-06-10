using System;
using System.Collections.Generic;
using System.IO;

namespace Student_Management_Sysytem
{

	public class Student
	{

		static void Main(string[] args)
		{
			List<List<string>> _student = new List<List<string>> ();
			List<string> student_Details = new List<string> ();

			List<List<string>> teacher = new List<List<string>> ();
			List<string> teacher_Details = new List<string> ();
		Option:
			Console.WriteLine ("\nChoose the option :\n");
			Console.WriteLine ("1. Registration\t");
			Console.WriteLine ("2. Searching\t");
			Console.WriteLine ("3. Update Details");
			Console.WriteLine ("4. Delete Details");
			Console.WriteLine ("5. Exit\n");
			//string input = Console.ReadLine();
			int selection =Convert.ToInt32(Console.ReadLine()); ;
		switch (selection) 
			{

			case 1:
				Console.WriteLine ("\nChoose the option for Registration :\n");
				Console.WriteLine ("1. Student\t");
				Console.WriteLine ("2. Teacher\n");


				int Reg_Selection = Convert.ToInt32(Console.ReadLine());;

				switch (Reg_Selection) {
				// student entry
				case 1:
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
								goto Option;
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
						for (int v = 0; v < 5; v++) 
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
							default:
								break;
							}

							student_Details.Add (Console.ReadLine ());
						}
						_student.Add (student_Details);
					}
					break;
				// teacher entry 
				case 2:
					for (int i = 0;; i++) 
					{
						if (i == 0)
						{
							goto TeacherStart;
						}
						TeacherCheck:
						if (i > 0) 
						{
							Console.WriteLine ("Do you want to entry more teacher details[y/n]");

							string s = Console.ReadLine ().ToString ();
							if (s == "n")
							{ // Check string
								goto Option;
							}
							else if (s == "y") 
							{
								goto TeacherStart;
							} 
							else
							{
								Console.WriteLine ("Invalide input");
								goto TeacherCheck;
							}

						}
						TeacherStart:
						for (int v = 0; v < 6; v++)
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
								Console.WriteLine ("Subject");
								break;
							case 5:
								Console.WriteLine ("State");
								break;
							default:
								break;
							}

							teacher_Details.Add (Console.ReadLine ());
						}
						teacher.Add (teacher_Details);
					}
					break;
				default:
					break;
				}
				break;
			case 2:
				Console.WriteLine ("\nSearching for :\n");
				Console.WriteLine ("1. Student\t");
				Console.WriteLine ("2. Teacher\n");

				int searchSelection = Convert.ToInt32(Console.ReadLine());;
				switch (searchSelection) {
				case 1:
						Console.WriteLine ("Enter the name of the student you want to find");
						string SearchName = Console.ReadLine ();
						int index = student_Details.IndexOf (SearchName);
						if (student_Details.Contains (SearchName)) {
							for (var i = index; i < student_Details.Count && i <= index + 4; i++) {

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

								Console.WriteLine ("{0}", student_Details [i]);
							}

							Console.WriteLine ();
						} else 
						{
							Console.WriteLine ("Not Found");
						}
					
					goto Option;
				//	break;

				case 2:
					Console.WriteLine ("Enter the name of the teacher you want to find");
					string SearchTeacherName = Console.ReadLine ();
					int TeacherIndex = teacher_Details.IndexOf (SearchTeacherName);
					if (teacher_Details.Contains (SearchTeacherName)) {
						for (var i = TeacherIndex; i < teacher_Details.Count && i <= TeacherIndex + 5; i++) {

							if (i == TeacherIndex) {
								Console.WriteLine ("\nName");

							}
							if (i == TeacherIndex + 1) {
								Console.WriteLine ("Email id");

							}
							if (i == TeacherIndex + 2) {
								Console.WriteLine ("Phone no");

							}
							if (i == TeacherIndex + 3) {
								Console.WriteLine ("Class");

							}
							if (i == TeacherIndex + 4) {
								Console.WriteLine ("Subject");

							}
							if (i == TeacherIndex + 5) {
								Console.WriteLine ("State");

							}


							Console.WriteLine ("{0}", teacher_Details [i]);
						}

						Console.WriteLine ();
					}
					else 
					{
						Console.WriteLine ("Not Found");
					}

					goto Option;
					//break;
				default:
					break;
				}
				break;
			case 3:
				Console.WriteLine ("\nUpdate for :\n");
				Console.WriteLine ("1. Student\t");
				Console.WriteLine ("2. Teacher\n");

				int UpdateSelection = Convert.ToInt32(Console.ReadLine());;
				switch(UpdateSelection)
				{
				case 1:
					Console.WriteLine ("Enter the name of the student you want to update");
					string SearchName = Console.ReadLine();
					int index = student_Details.IndexOf (SearchName);

					if(student_Details.Contains(SearchName))
					{
					for (var i = index; i < student_Details.Count && i <= index + 4 ; i++)
					{

						if(i == index)
						{
							Console.WriteLine ("\nName");

						}
						if(i == index + 1)
						{
							Console.WriteLine ("Email id");

						}
						if(i == index + 2)
						{
							Console.WriteLine ("Phone no");

						}
						if(i == index + 3)
						{
							Console.WriteLine ("Class");

						}
						if(i == index + 4)
						{
							Console.WriteLine ("State");

						}

						student_Details [i] = Console.ReadLine();
					}
					}
					else 
					{
						Console.WriteLine ("Not Found");
					}

					goto Option;
				case 2:

					Console.WriteLine ("Enter the name of the teacher you want to update");
					string SearchTeacherName = Console.ReadLine();
					int TeacherIndex = teacher_Details.IndexOf (SearchTeacherName);

					if(teacher_Details.Contains(SearchTeacherName))
					{
					for (var i = TeacherIndex; i < teacher_Details.Count && i <= TeacherIndex + 5 ; i++)
					{

						if(i == TeacherIndex)
						{
							Console.WriteLine ("\nName");

						}
						if(i == TeacherIndex + 1)
						{
							Console.WriteLine ("Email id");

						}
						if(i == TeacherIndex + 2)
						{
							Console.WriteLine ("Phone no");

						}
						if(i == TeacherIndex + 3)
						{
							Console.WriteLine ("Class");

						}
						if(i == TeacherIndex + 4)
						{
							Console.WriteLine ("Subject");

						}
						if(i == TeacherIndex + 5)
						{
							Console.WriteLine ("State");

						}


						 teacher_Details[i] = Console.ReadLine();
					}
					}
					else 
					{
						Console.WriteLine ("Not Found");
					}

					goto Option;
				default:
					break;


				}
				break;


			case 4:

				Console.WriteLine ("\nSearching for :\n");
				Console.WriteLine ("1. Student\t");
				Console.WriteLine ("2. Teacher\n");

				int DeleteSelection = Convert.ToInt32(Console.ReadLine());;
				switch(DeleteSelection)
				{
				case 1:
					Console.WriteLine ("Enter the name of the student you want to delete");
					string SearchName = Console.ReadLine ();
					int index = student_Details.IndexOf (SearchName);
					if (student_Details.Contains (SearchName)) {
						for (var i = index; i < student_Details.Count && i <= index + 4; i++) {
							student_Details.RemoveAt (i);
						}
						Console.WriteLine ("Student details deleted");
					} else {
						Console.WriteLine ("Not Found");
					}
					goto Option;
				case 2:
					Console.WriteLine ("Enter the name of the teacher you want to delete");
					string SearchTeacherName = Console.ReadLine();
					int TeacherIndex = student_Details.IndexOf (SearchTeacherName);
					if(teacher_Details.Contains(SearchTeacherName)){
					for (var i = TeacherIndex; i < student_Details.Count && i <= TeacherIndex + 5 ; i++)
					{
						teacher_Details.RemoveAt(i);
					}
					Console.WriteLine ("Teacher details deleted");
				} else {
					Console.WriteLine ("Not Found");
				}
					goto Option;

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
	}
}