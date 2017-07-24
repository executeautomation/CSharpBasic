using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class CollectionExample
    {
        public static void ArrayExample()
        {
            int[] testcaseid = new int[] { 101, 102, 103, 104 };

            for (int i = 0; i < testcaseid.Length; i++)
            {
                Console.WriteLine(testcaseid[i]);
            }

            string[] testcaseName = new string[] { "UserForm", "Login", "Hover" };

            foreach (var testcase in testcaseName)
            {
                Console.WriteLine(testcase);
            }
        }

        public static void NonGenericCollection()
        {
            Hashtable table = new Hashtable();
            table.Add("UserName", "ea");
            table.Add("Password", "ea123");
            table.Add("Button", "Submit");

            foreach (var key in table.Keys)
            {
                Console.WriteLine("The value for " + key + " is :" + table[key]);
            }
        }


        public static void GenericCollections()
        {
            string[] user1 = new string[] { "Karthik", "30", "kk@kk.com", "234234" };
            string[] user2 = new string[] { "Sam", "20", "sam@sam.com", "23423" };
            string[] user3 = new string[] { "Jacob", "30", "jacob@jacob.com", "23423" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();

            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);

            foreach (var value in dict)
            {
                string[] usersInfo = value.Value;

                foreach (var user in usersInfo)
                {
                    Console.WriteLine(user);
                }
            }

        }

        public static void GenericCollectionsWithCustomClass()
        {
            List<User> users = new List<User>();
            users.Add(new User { UserId = 1, Name = "Karthik", Age = 30, Email = "kk@kk.com", Phone = 234234, Addresses = new List<Address>() { new Address { Street = "DemoStreet1", Country = "Malaysia", FlatName = "Panorama" }, new Address() { Street = "Chennai Street", Country = "India", FlatName = "Vembu" } } });
            //users.Add(new User { UserId = 2, Name = "Sam", Age = 40, Email = "sam@sam.com", Phone = 35443, Addresses = new Address { Street = "DemoStreet2", Country = "India", FlatName = "Panorama" } });
            //users.Add(new User { UserId = 3, Name = "Jacob", Age = 40, Email = "jacob@jacob.com", Phone = 23452354, Addresses = new Address { Street = "DemoStreet3", Country = "US", FlatName = "Panorama" } });

            //foreach (var user in users)
            //{
            //    Console.WriteLine(String.Format("The User {0} with Age {1} has Email {2} and Phone {3}", user.Name, user.Age, user.Email, user.Phone));
            //}

            //var userlist = from user in users
            //               from address in user.Addresses
            //               where user.Age == 30
            //               select new { FirstName = user.Name, PhoneNumber = user.Phone, Address = address };

            //var addresses = users.Where(x => x.Age == 40).SelectMany(x => x.Addresses);

            //foreach (var user in userlist)
            //{
            //    Console.WriteLine("User {0} has Phone number {1} with country {2}", user.FirstName, user.PhoneNumber, user.Address.Country);
            //}

        }
    }


    /// <summary>
    /// Custom type user
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Int64 Phone { get; set; }
        public List<Address> Addresses { get; set; }

    }

    public class Address
    {
        public string FlatName { get; set; }

        public string Street { get; set; }

        public string Country { get; set; }

    }

}
