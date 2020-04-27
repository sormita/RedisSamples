using System;
using System.Collections.Generic;
using System.Text;

namespace RedisConnector
{
    public class DataRepository
    {
        public SampleObject GenerateSampleObject()
        {
            SampleObject sampleObject = new SampleObject
            {
                Country = "India",
                Id = 7,
                Name = "Sormita"
            };

            return sampleObject;
        }

        public List<SampleObject> GenerateListSampleObjects()
        {
            List<SampleObject> lstSampleObject = new List<SampleObject>();
            lstSampleObject.Add(new SampleObject
            {
                Country = "Argentina",
                Id = 1,
                Name = "Maradona"
            });
            lstSampleObject.Add(new SampleObject
            {
                Country = "Portugal",
                Id = 2,
                Name = "Ronaldo"
            });
            lstSampleObject.Add(new SampleObject
            {
                Country = "Puskas",
                Id = 3,
                Name = "Hungary"
            });

            return lstSampleObject;
        }
        
        public Company GenerateSampleCompany()
        {
            List<User> lstUser = new List<User>();
            lstUser.Add(new User
            {
                UserId = 100,
                Firstname = "Sam",
                Lastname = "Piotr"
            });
            lstUser.Add(new User
            {
                UserId = 101,
                Firstname = "Pam",
                Lastname = "sssiotr"
            });
            lstUser.Add(new User
            {
                UserId = 102,
                Firstname = "Bam",
                Lastname = "NNiotr"
            });

            Company compObject = new Company
            {
                CompanyId = 1001,
                CompanyName = "ABC",
                UserList = lstUser
            };

            return compObject;
        }

        public List<Company> GenerateListSampleCompany()
        {
            List<User> lstUser = new List<User>();
            lstUser.Add(new User
            {
                UserId = 100,
                Firstname = "Sam",
                Lastname = "Piotr"
            });
            lstUser.Add(new User
            {
                UserId = 101,
                Firstname = "Pam",
                Lastname = "sssiotr"
            });
            lstUser.Add(new User
            {
                UserId = 102,
                Firstname = "Bam",
                Lastname = "NNiotr"
            });

            List<User> lstUser1 = new List<User>();
            lstUser1.Add(new User
            {
                UserId = 100,
                Firstname = "Tam",
                Lastname = "Piotr"
            });
            lstUser1.Add(new User
            {
                UserId = 101,
                Firstname = "Lam",
                Lastname = "sssiotr"
            });
            lstUser1.Add(new User
            {
                UserId = 102,
                Firstname = "NNam",
                Lastname = "NNiotr"
            });

            Company compObject = new Company
            {
                CompanyId = 1001,
                CompanyName = "ABC",
                UserList = lstUser
            };

            Company compObject1 = new Company
            {
                CompanyId = 1002,
                CompanyName = "ABC",
                UserList = lstUser1
            };

            List<Company> lstCompany = new List<Company>();
            lstCompany.Add(compObject);
            lstCompany.Add(compObject1);

            return lstCompany;
        }

    }
}
