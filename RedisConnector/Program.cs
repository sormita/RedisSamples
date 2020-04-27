using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace RedisConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region SimpleObject
            string strKey1 = "TestKeys1234";

            RedisConnector.Set(strKey1, "1234");

            string strResult = RedisConnector.Get<string>(strKey1);


            DataRepository repos = new DataRepository();

            SampleObject sampleObject = repos.GenerateSampleObject();

            //Saving to Redis using object
            RedisConnector.Set("test1", sampleObject);

            SampleObject sampleObject1 = repos.GenerateSampleObject();

            //Saving a single object to Redis using HashSet
            RedisConnector.HashSet(sampleObject1,"testHash1");

            //Retreival using object
            var sampleGetObject1 = RedisConnector.Get<SampleObject>("testHash1");

            //Retrieve a single object using hashset
            var sampleObject1 = RedisConnector.GetDatabase().HashGetAll("sampleObject1").ConvertFromRedis<SampleObject>();

            List<SampleObject> lstSampleObject = repos.GenerateListSampleObjects();
            if (RedisConnector.GetDatabase() != null)
            {                
                //Saving a list to redis using object
                RedisConnector.Set("test2", lstSampleObject);
            }


                //Saving a list to redis using hash set
                var sampleObjects = new RedisList<int, SampleObject>("samples");
                sampleObjects.AddMultiple(lstSampleObject.ToDictionary(x => x.Id));

                //query an object by its id
                var lstObject = new RedisList<int, SampleObject>("samples");
                SampleObject obj1 = lstObject[2];
                var obj2= lstObject.Where(x => x.Value.Country == "Argentina").ToList().FirstOrDefault();
                SampleObject actualObj = obj2.Value;


                //updating an object in a list in redis
            obj1.Name = "New Name";
            lstObject.Remove(2);
            lstObject.Add(2, obj1);

            //    var lstObject1=new RedisList<int, SampleObject>("samples");
            //    SampleObject obj2 = lstObject1[2];

            //Getting a list of objects from Redis
            //if(RedisConnector.GetDatabase() != null)
            //{
            //    var lstSampleObject1=RedisConnector.Get<List<SampleObject>>("test2");
            //}
            #endregion

            #region ComplexObjects
            Company compObject = repos.GenerateSampleCompany();

            List<Company> lstCompany = repos.GenerateListSampleCompany();
            
            RedisConnector.SetComplexObject<Company>(compObject, "company");
                        
            var processedCompany = RedisConnector.GetComplexObject<Company>("company");

            //Saving and retrieval of a list of complex objects 
            RedisConnector.SetComplexList<Company>(lstCompany, "companies");

            List<Company> lstNewCompany = RedisConnector.GetComplexList<Company>("companies");            

            #endregion
                       

        }

    }

    }


