using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public  class UserService
    {
        private FileUserStore _fileStore;

        public UserService(FileUserStore fileStore)
        {
            _fileStore = fileStore;
        }
       
        public User Register(string name, string username, string password)
        {
            var user = new User()
            {
                Name = name,
                Password = password,
                Username = username
            };
            MessageBox.Show("You're registered!");
            _fileStore.AddUser(user);
            return user;
        }
        public bool Check(string username, string password)
        {
            var user = _fileStore.GetUsers()
                .Where(x => x.Username == username && x.Password == password)
                .FirstOrDefault();
            return user != null;
        }


    }
}
