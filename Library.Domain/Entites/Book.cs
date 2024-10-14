using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entites
{
    public class Book
    {
        [Key]
        public required int BookId { get; set; }

        public required string Title { get; set; }
        public string? Description { get; set; }

        public required int AuthorId { get; set; }
        public Author Author { get; set; }

        public DateOnly PublishedDate { get; set; }

        public int? PageCount { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
