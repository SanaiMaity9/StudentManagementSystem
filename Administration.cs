using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;


namespace StudentManagementSystem
{
	public class Administrator
	{
		
        
		public List<Members> MemberList = new List<Members>();
		 
		public void Insert(Object member)
		{
			var members = new Members();
			if(member is Student)
			{
				members.student = member as Student;
			}
			else if(member is Teacher)
			{
				members.teacher = member as Teacher;
			}
		  MemberList.Add(members);
		}
		public int GetClassCount()
		{
			Array standard = new Array[3];
			int i=0;
			foreach (var item in MemberList)
			{
			   standard = item.teacher.GetClass();
			  
			}
			foreach (var item in standard)
			{
				if(item != null)
				{
					i++;
				}
			}
			return i;
		}
		
		public int GetSubjectCount()
		{
			Array Subject = new Array[10];
			int i=0;
			foreach (var item in MemberList)
			{
			   Subject = item.student.GetSubject();
			  
			}
			foreach (var item in Subject)
			{
				if(item != null)
				{
					i++;
				}
			}
			return i;
		}
		
		public String SearchBySubject(string subject)
		{
			Array Subject = new Array[10];
			int  i =0;
			string student = ""; 
			foreach (var item in MemberList)
			{
				Subject = item.student.GetSubject();
			}
			foreach (var item in Subject)
			{
				i = Array.IndexOf(Subject,subject);
			student = MemberList[i].student.print();
			}
			return student;
		}
		
    }
}

