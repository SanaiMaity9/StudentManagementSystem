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
		
		public void SearchBySubject(string subject ,int type)
		{
			Array Subject = new Array[10];
			Members a = new Members();
			if(type == 1)
			{
			for(int i=0;i<MemberList.Count;i++)
			{
				int j=0;
				while(MemberList[i].student.GetSubject()[j] != null)
				{
				   if(MemberList[i].student.GetSubject()[j] == subject)
				   {
					    a = new Members();
					    a =	MemberList.FirstOrDefault(x => x.student.GetSubject()[j] == subject);
				   }
				  j++;
				}
				Console.WriteLine(a.student.print());
			}
		}
		else{
			for(int i=0;i<MemberList.Count; i++)
			{
				int j=0;
				while(MemberList[i].teacher.GetSubject()[j] != null)
				{
				   if(MemberList[i].teacher.GetSubject()[j] == subject)
				   {
					    a = new Members();
					    a =	MemberList.FirstOrDefault(x => x.teacher.GetSubject()[j] == subject);
				   }
				  j++;
				}
			}
			Console.WriteLine(a.teacher.print());
		}
		}
	
    }
}

