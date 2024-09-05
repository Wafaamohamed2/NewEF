using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewEF.Models
{

    //To chang table name  in DB by using data anotation
    // [Table("MyPosts")]

    //change schema name
  //  [Table("Posts" , Schema ="blogging")]


    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //navigation propirity ......  Blog become domain model
        public Blog Blog { get; set; }

    }
}
