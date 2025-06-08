using TodoApps.Models.Enum;
using TodoApps.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TodoApps.ViewsModels
{
    public class TodoViewes
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }=false;
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DueDate { get; set; }
        public int CategoryId { get; set; }
        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

    }
}
