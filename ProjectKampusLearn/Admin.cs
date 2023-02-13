using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKampusLearn
{
    internal class Admin
    {
        private string _name, _contact, _email, _address,_password;
        private int _admin_id;
        bool _isActive;
        DateTime _created_at, _updated_at;

        public Admin(string name, string contact, string email, string address, string password, int admin_id, bool isActive, DateTime created_at, DateTime updated_at)
        {
            _name = name;
            _contact = contact;
            _email = email;
            _address = address;
            _password = password;
            _admin_id = admin_id;
            _isActive = isActive;
            _created_at = created_at;
            _updated_at = updated_at;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Contact { get { return _contact; } set { _contact = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public int Admin_Id { get { return _admin_id; } set { _admin_id = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public DateTime Created_At { get { return _created_at; } set { _created_at = value; } }
        public DateTime Updated_At { get { return _updated_at; } set { _updated_at = value; } }



    }
}
