using System.ComponentModel.DataAnnotations.Schema;
using TodoApps.Models.Enum;

namespace TodoApps.Models
{
    
        public class Todo
        {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Priority priority { get; set; } = Priority.Medium;
        public bool IsCompeleted { get; set; } = false;
        public DateTime DueDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }

    }

