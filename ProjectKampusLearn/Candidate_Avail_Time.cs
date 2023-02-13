using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKampusLearn
{
    internal class Candidate_Avail_Time
    {
        private int _id, _candidate_id;
        private DateTime _avail_time;
        bool _isActive;

        public Candidate_Avail_Time(int id, int candidate_id, DateTime avail_time, bool isActive)
        {
            _id = id;
            _candidate_id = candidate_id;
            _avail_time = avail_time;
            _isActive = isActive;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public int Candidate_Id { get { return _candidate_id; } set { _candidate_id = value; } }
        public DateTime Avail_Time { get { return _avail_time; } set { _avail_time = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
    }
}
