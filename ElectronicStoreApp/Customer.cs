using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicStoreApp
{
    public class Customer
    {
        public string username;
        public int adminRights;
        public Array cart;

        public Customer(string cUsername, int cAdminRights, Array cCart)
        {
            username = cUsername;
            adminRights = cAdminRights;
            cart = cCart;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int AdminRights
        {
            get { return adminRights; }
            set { adminRights = value; }
        }

        public Array Cart
        {
            get { return cart; }
            set { cart = value; }
        }
    }
}
