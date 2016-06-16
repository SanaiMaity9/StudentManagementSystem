using System.IO;
using System;
using StudentManagementSystem;

namespace  StudentManagementSystem
{
    public class StudentManagementSystemMain
    {
        public static void Main(string[] args)
		{
            UserInterface userinterface = new UserInterface ();
			userinterface.Options ();
		}
    }
}
