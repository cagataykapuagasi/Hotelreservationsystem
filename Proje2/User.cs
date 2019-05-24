﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class User //her üye için bilgiler
    {
        string username, name, surname,phone;

        List<Reservation> reservationList = new List<Reservation>();

        public User(string username)
        {
            this.username = username;
        }

        public List<Reservation> ReservationList
        {
            get { return reservationList; }
            set { reservationList = value; }
        }

        public string Username
        {
            get { return username; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string PhoneNumber
        {
            get { return phone; }
            set { phone = value; }
        }

    }
}
