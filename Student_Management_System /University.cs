using System;
using NameSpaceStudent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NameSpaceTeacher;

namespace NameSpaceUniversity
{
	public class University
	{
		public List<Student> StudentList = new List<Student>();
		public List<Teacher> TeacherList = new List<Teacher>();

		public void Insert(string name , string[] className , string state , string phoneNo , string subject, string emailId, int choice )
		{
			if (choice == 1) {
				var student = new Student (name, className[0], state, phoneNo, emailId);
				StudentList.Add (student);
			}
			else 
			{
				var teacher = new Teacher (name, className, state, phoneNo, subject, emailId);
				TeacherList.Add (teacher);
			}

		}
		public int GetCount()
		{
			int i = 0;
			while(TeacherList.Exists (x => x.Class[i] != null))
			{
				i++;

			}
			return i;
		}

		public string Print(int choice ){

		string studentDetails = "";
		string teacherDetails = "";
			if (choice == 1) 
			{
				foreach (var student in StudentList)
				{
					studentDetails += student.GetPrintable () + "\n";
				}
				return studentDetails;
			}
		    else
		    {
				foreach (var teacher in TeacherList)
				{
					teacherDetails += teacher.GetPrintable () + "\n";
				}
				return teacherDetails;	
			}
		}

		public bool Update(string emailId )
		{

			return StudentList.Exists (x => x.EmailId == emailId);
			
		}

		public bool Search(string name )
		{

			return StudentList.Exists (x => x.Name == name);

		}


	}
}

