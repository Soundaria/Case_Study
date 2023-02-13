using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKampusLearn
{
    internal class Trainer_Avail_Time
    {
        private int _id, _trainer_id;
        private DateTime _avail_time;
        bool _isActive;

        public Trainer_Avail_Time(int id, int trainer_id, DateTime avail_time, bool isActive)
        {
            _id = id;
            _trainer_id = trainer_id;
            _avail_time = avail_time;
            _isActive = isActive;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public int Trainer_Id { get { return _trainer_id; } set { _trainer_id = value; } }
        public DateTime Avail_Time { get { return _avail_time; } set { _avail_time = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
    }
}
