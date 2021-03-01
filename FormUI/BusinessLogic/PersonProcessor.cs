using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI.BusinessLogic
{
    //a class which is used to process data, either to create or load through sql statements.
    public static class PersonProcessor
    {
        public static int CreatePerson(int personId, string firstName, 
            string lastName, string emailAddress, string phoneNumber)
        {
            Person data = new Person
            {
                Id = personId,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                PhoneNumber = phoneNumber
            };

            string sql = @"insert into dbo.Person (Id, FirstName, LastName, EmailAddress, PhoneNumber)
                           values (@Id, @FirstName, @LastName, @EmailAddress, @PhoneNumber);";

            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<Person> LoadPerson(int id)
        {
            string sql = @"select Id, FirstName, LastName, EmailAddress, PhoneNumber
                            from dbo.Person
                            where Id = " +id+ ";";    
                                
            return SQLDataAccess.LoadData<Person>(sql);
        }
    }
}
