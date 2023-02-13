using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKampusLearn
{
    internal class Payment
    {
        private int _payment_id, _course_id, _candidate_id;
        bool _isActive;
        DateTime _created_at, _updated_at;

        public Payment(int payment_id, int course_id, int candidate_id, bool isActive, DateTime created_at, DateTime updated_at)
        {
            _payment_id = payment_id;
            _course_id = course_id;
            _candidate_id = candidate_id;
            _isActive = isActive;
            _created_at = created_at;
            _updated_at = updated_at;
        }

        public int Payment_Id { get { return _payment_id; } set { _payment_id = value; } }
        public int Course_Id { get { return _course_id; } set { _course_id = value; } }
        public int Candidate_Id { get { return _candidate_id; } set { _candidate_id = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public DateTime Created_At { get { return _created_at; } set { _created_at = value; } }
        public DateTime Updated_At { get { return _updated_at; } set { _updated_at = value; } }
    }
}
