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
		public int GetClass()
		{
			Array Class = new Array[3];
			int i=0;
			foreach (var item in MemberList)
			{
			   Class = item.teacher.GetClass();
			  
			}
			foreach (var item in Class)
			{
				if(item != null)
				{
					i++;
				}
			}
			return i;
		}
		
		public int GetSubject()
		{
			Array Subject = new Array[3];
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
		
    }
}

