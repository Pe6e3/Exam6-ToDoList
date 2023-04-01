using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class MyTask
    {

        [Display(Name = "Номер задачи")]
        [Key] public int TaskId { get; set; }

        [Display(Name = "Имя задачи")]
        [DataType(DataType.MultilineText)]
        public string? TaskName { get; set; }


        [Display(Name = "Описание задачи")]
        [DataType(DataType.MultilineText)]
        public string? TaskDesc { get; set; }


        public int PriorityId { get; set; }
        [Display(Name = "Приоритет")]
        public virtual Priority? Priority { get; set; }


        public int StatusId { get; set; }
        [Display(Name = "Статус")]
        public Status? Status { get; set; }



        [Display(Name = "Дата создания задачи")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateCreate { get; set; }

        [Display(Name = "Дата открытия задачи")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateOpen { get; set; }

        
    }
    
}
