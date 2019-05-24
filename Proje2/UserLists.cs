using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class UserLists //üyelerin tutulduğu liste
    {
        List<User> list = new List<User>();
        CurrentUser currentUser = null;


        public CurrentUser getCurrent()
        {
            return currentUser;
        }

        public void firstUser(string username)
        {
            currentUser = new CurrentUser(list[0].Username, 0);
        }

        public void updateUserList(string name, string surname, string phone, int index)
        {
            User temp = list[index];
            temp.Name = name;
            temp.Surname = surname;
            temp.PhoneNumber = phone;

            list[index] = temp;
        }

        public bool loadCurrentUser(string username)
        {
            int index = 0;
            

            if (list.Count == 0)
                return false;

            foreach(User i in list)
            {
                if (i.Username == username)
                {
                    currentUser = new CurrentUser(i.Username, index);
                    currentUser.Name = i.Name;
                    currentUser.Surname = i.Surname;
                    currentUser.PhoneNumber = i.PhoneNumber;
                    currentUser.ReservationList = i.ReservationList;
                    return true;
                }

                index++;
            }

            return false;
        }

        public bool addUsers(string username)
        {
            bool possible = true;

            if (list.Count == 0)
            {
                list.Add(new User(username));
                return true;
            }

            foreach (User i in list)
            {
                if (i.Username == username)
                {
                    possible = false;
                }
            }

            if (possible)
                list.Add(new User(username));


            return possible;
        }

        public void loadTxt()
        {
            string stream_read = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "datas.txt");
            
            if(stream_read.Length > 10)
                list = JsonConvert.DeserializeObject<List<User>>(stream_read);


            foreach (User i in list)
                Debug.WriteLine(i.PhoneNumber);

            //string js_data = stream_read.ReadToEnd();


            //User u = new User("dana");
            //u.RezervationList.Add(new Reservation());
            //list.Add(u);

            //User a = new User("lala");
            //a.RezervationList.Add(new Reservation());
            //a.RezervationList.Add(new Reservation());
            //a.RezervationList.Add(new Reservation());
            //list.Add(a);

            //var deneme = JsonConvert.SerializeObject(list);

            //File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "deneme.txt", deneme);


            //Debug.WriteLine(list[0].RezervationList[0].Deneme);
        }

        public void saveTxt()
        {
            var datas = JsonConvert.SerializeObject(list);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "datas.txt", datas);
        }

        public void loginAdmin()
        {
            list.Clear();
            var datas = JsonConvert.SerializeObject(list);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "admin.txt", datas);
        }

    }
}
