using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKampusLearn
{
    internal class Candidate_to_Course
    {
        private int _id, _candidate_id, _course_id;
        private bool _isPaymentDone, _isActive;
        private DateTime _created_at, _updated_at;

        public Candidate_to_Course(int id, int candidate_id, int course_id, bool isPaymentDone, bool isActive, DateTime created_at, DateTime updated_at)
        {
            _id = id;
            _candidate_id = candidate_id;
            _course_id = course_id;
            _isPaymentDone = isPaymentDone;
            _isActive = isActive;
            _created_at = created_at;
            _updated_at = updated_at;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public int Candidate_Id { get { return _candidate_id; } set { _candidate_id = value; } }
        public int Course_Id { get { return _course_id; } set { _course_id = value; } }
        public bool IsPaymentDone { get { return _isPaymentDone; } set { _isPaymentDone = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public DateTime Created_At { get { return _created_at; } set { _created_at = value; } }
        public DateTime Updated_At { get { return _updated_at; } set { _updated_at = value; } }


    }
}
