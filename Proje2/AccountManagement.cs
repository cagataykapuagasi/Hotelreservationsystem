using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    public class AccountManagement //giriş yönetimi
    {
        UserLists list = new UserLists();
        internal CurrentUser currentUser = null;

        public AccountManagement(bool isAdmin)
        {
            loginAdmin();
        }

        public AccountManagement()
        {
            
        }

        public void firstUser(string username)
        {
            list.firstUser(username);
            currentUser = list.getCurrent();
        }

        public void updateUserList(string name, string surname, string phone ,int index)
        {
            list.updateUserList(name, surname, phone, index);
        }

        public bool loginUser(string username )
        {
            bool temp = list.loadCurrentUser(username);
            if (temp != false)
            {
                currentUser = list.getCurrent();
            }

            return temp;
        }

        public bool Register(string username)
        {
            bool temp = list.addUsers(username);
            if (temp != false)
            {
                list.loadCurrentUser(username);
                currentUser = list.getCurrent();
            }

            return temp;
        }

        public void loadTxt()
        {
            list.loadTxt();
        }

        public void saveTxt()
        {
            list.saveTxt();
        }

        void loginAdmin()
        {
            list.loginAdmin();
        }
    }
}
