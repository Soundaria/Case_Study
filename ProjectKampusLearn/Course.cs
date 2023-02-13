using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKampusLearn
{
    internal class Course
    {
        private string _course_name, _course_category;
        private int _course_id, _admin_id, _fees;
        bool _isActive;
        DateTime _created_at, _updated_at;

        public Course(string course_name, string course_category, int course_id, int admin_id, int fees, bool isActive, DateTime created_at, DateTime updated_at)
        {
            _course_name = course_name;
            _course_category = course_category;
            _course_id = course_id;
            _admin_id = admin_id;
            _fees = fees;
            _isActive = isActive;
            _created_at = created_at;
            _updated_at = updated_at;
        }

        public string Course_Name { get { return _course_name; } set { _course_name = value; } }
        public string Course_Category { get { return _course_category; } set { _course_category = value; } }
        public int Course_Id { get { return _course_id; } set { _course_id = value; } }
        public int Admin_Id { get { return _admin_id; } set { _admin_id = value; } }
        public int Fees { get { return _fees; } set { _fees = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public DateTime Created_At { get { return _created_at; } set { _created_at = value; } }
        public DateTime Updated_At { get { return _updated_at; } set { _updated_at = value; } }

    }
}
