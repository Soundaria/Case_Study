using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKampusLearn
{
    internal class Trainer_To_Course
    {
        private int _id, _trainer_id, _course_id;
        private bool _isActive;
        private DateTime _created_at, _updated_at;

        public Trainer_To_Course(int id, int trainer_id, int course_id, bool isActive, DateTime created_at, DateTime updated_at)
        {
            _id = id;
            _trainer_id = trainer_id;
            _course_id = course_id;
            _isActive = isActive;
            _created_at = created_at;
            _updated_at = updated_at;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public int Trainer_Id { get { return _trainer_id; } set { _trainer_id = value; } }
        public int Course_Id { get { return _course_id; } set { _course_id = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public DateTime Created_At { get { return _created_at; } set { _created_at = value; } }
        public DateTime Updated_At { get { return _updated_at; } set { _updated_at = value; } }

    }
}
