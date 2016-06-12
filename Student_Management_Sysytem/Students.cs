using System;
using NameSpaceStudent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSpaceStudents
{
	public class Students
	{
		public List<Student> StudentList = new List<Student>();

		public void Insert(string name , string className , string state , string phoneNo , string emailId )
		{
			var student = new Student (name,className,state,phoneNo,emailId);

			StudentList.Add (student);

		}

		public string Print(){
			string studentDetails = null;
			foreach (var student in StudentList)
			{

				studentDetails += student.GetPrintable () + "\n";

			}

			return studentDetails;
		}

		public bool Update(string emailId )
		{

			if (StudentList.Exists (x => x.EmailId == emailId)) {
				return true;
			} else {
				return false;
			}
		}

		public bool Search(string name )
		{

			if (StudentList.Exists (x => x.EmailId == name)) {
				return true;
			} else {
				return false;
			}
		}


	}
}

