using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entites
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }

        public required string PublisherName { get; set; }
    }
}
