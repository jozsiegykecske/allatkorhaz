using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkorhaz
{
    public class User
    {
        int id;
        string nev;
        int jogkor;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Jogkor { get => jogkor; set => jogkor = value; }

        public User(int id, string nev, int jogkor)
        {
            Id = id;
            Nev = nev;
            Jogkor = jogkor;
        }
    }
}
