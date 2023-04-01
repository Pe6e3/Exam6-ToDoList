using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Priority
    {
        [Key] public int PriorityId { get; set; }

        [Display(Name ="Название приоритета")]
        public string? PriorityName { get; set; }
    }
}
