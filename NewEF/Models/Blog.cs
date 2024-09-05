using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEF.Models
{
    public class Blog
    {
      
        public int Id { get; set; }
      
        public string URL { get; set; }

        // navigation propirity  .........
        // class post become a domain model ...
        // then there are a relation between blog and posts (one to many)



        // data anotation to drop table from DB
        //[NotMapped]


        public List<Posts> Posts { get; set; }








    }
}
