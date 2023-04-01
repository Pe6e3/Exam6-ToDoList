using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Status
    {
        [Key] public int StatusId { get; set; }

        [Display(Name = "Статус задачи")]
        public string? StatusName { get; set; }
    }
}
