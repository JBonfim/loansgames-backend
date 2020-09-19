using System;

namespace Api.Domain.Dtos.Person
{
    public class PersonResponseDomainModel
    {
         public long Id { get; set; }
         public string Name { get; set; }
        public string Address { get; set; }

         public string phone { get; set; }

           public DateTime CreateAt { get; set; }
    }
}