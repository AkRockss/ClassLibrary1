using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Student
    {

        public string _name;
        public string _adress;
        public int _semester;



        public string Name 
        {
            get => _name;

            set
            {
                if (value.Length < 2) throw new ArgumentException("Name is smaller then 2");
                _name = value;
            }
}
                
        public string Adress 
        { 
            get => _adress; 
            
            set
            {
                if (value == null) throw new ArgumentException("Adress value is null");
                _adress = value;
            }
        
        }
        public int Semester 
        {
            get => _semester;
            
        set
         {
                if (1 <= value || value <= 8) _semester = value;
                else throw new ArgumentOutOfRangeException("semester", value, "illegal Semester");

         }
       
        }


        public enum GenderType { Male, Female }

        public override string ToString()
        {
            return base.ToString();
        }


        public Student (string Name, string Adress, int Semester)
        {

        }


    }


    class Teacher
    {


    }

}
