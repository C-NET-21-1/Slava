using System;

namespace Student_Class
{
    class Student
    {
        private string _name;
        private string _lastName;
        private uint _studNum;
        private DateTime _enterDate;

        public void SetName(string input)
        {
            _name = input;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetLastName(string input)
        {
            _lastName = input;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public void SetStudNumber(uint input)
        {
            _studNum = input;
        }

        public uint GetStudNumber()
        {
            return _studNum;
        }

        public void SetEnterDate(DateTime input)
        {
            _enterDate = input;
        }

        public DateTime GetEnterDate()
        {
            return _enterDate;
        }

        public Student(string name, string lastName, uint studNum,
                DateTime enterDate)
        {
            _name = name;
            _lastName = lastName;
            _studNum = studNum;
            _enterDate = enterDate;
        }

        public Student()
        {

        }
    }
}
