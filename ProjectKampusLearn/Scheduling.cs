using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKampusLearn
{
    internal class Scheduling
    {
        private int _id, _course_id, _trainer_id, _admin_id, _candidate_id;
        bool _isActive;
        DateTime _date_scheduled, _created_at, _updated_at;

        public Scheduling(int id, int course_id, int trainer_id, int admin_id, int candidate_id, bool isActive, DateTime date_scheduled, DateTime created_at, DateTime updated_at)
        {
            _id = id;
            _course_id = course_id;
            _trainer_id = trainer_id;
            _admin_id = admin_id;
            _candidate_id = candidate_id;
            _isActive = isActive;
            _date_scheduled = date_scheduled;
            _created_at = created_at;
            _updated_at = updated_at;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public int Candidate_Id { get { return _candidate_id; } set { _candidate_id = value; } }
        public int Trainer_Id { get { return _trainer_id; } set { _trainer_id = value; } }
        public int Course_Id { get { return _course_id; } set { _course_id = value; } }
        public int Admin_Id { get { return _admin_id; } set { _admin_id = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public DateTime Date_Scheduled { get { return _date_scheduled; } set { _date_scheduled = value; } }
        public DateTime Created_At { get { return _created_at; } set { _created_at = value; } }
        public DateTime Updated_At { get { return _updated_at; } set { _updated_at = value; } }
    }
}
