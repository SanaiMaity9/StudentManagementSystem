using System;
using System.Collections.Generic;
using System.IO;

namespace Student_Management_Sysytem
{
	public class Student
	{
		static void Main(string[] args)
		{

			List<List<string>> _student = new List<List<string>>();

			for (int i = 0; ; i++) 
			{
				List<string> student_Details = new List<string> ();
				if (i == 0) 
				{
					goto start;
				}
			check:
				if(i > 0) 
				{
					Console.WriteLine ("Do you want to entry more student details[y/n]");

				    string s= Console.ReadLine().ToString();
					if (s == "n") // Check string
					{
						break;
					}
					else if(s == "y")
					{
						goto start;
					}
					else
					{
						Console.WriteLine("Invalide input");
						goto check;
					}

				}
			start:
				for (int v = 0; v < 5; v++)
				{
					switch(v)
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

					student_Details.Add(Console.ReadLine());
				}
				_student.Add (student_Details);
			}

			foreach (var sublist in _student)
			{
				foreach (var value in sublist)
				{
					Console.Write(value);
					Console.Write(' ');
				}
				Console.WriteLine();
			}
		Search:
			Console.WriteLine ("Do you want to search student details[y/n]");

			string a = Console.ReadLine().ToString();
			if (a == "n") // Check string
			{
				System.Environment.Exit(1);
			}
			else if(a == "y")
			{
				string name = Console.ReadLine ();

				foreach (var sublist in _student)
				{
					foreach (var x in sublist)
					{
						if (x == name)
						{
							Console.WriteLine (x);
						} else {
							Console.WriteLine ("Not found");
						}
					}

				}
			
			}
			else{
				Console.WriteLine("Invalide input");
				goto Search;
			}


		}
	}
}