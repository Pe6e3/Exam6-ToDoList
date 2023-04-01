using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Task
    {
        public Task()
        {
            // При создании задачи сразу записываем текущее время - время создания задачи
            DateCreate = DateTime.Now; 
        }


        [Key] public int TaskId { get; set; }

        [Display(Name = "Имя задачи")]
        [DataType(DataType.MultilineText)]
        public string? TaskName { get; set; }
        [Display(Name = "Описание задачи")]

        public string? TaskDesc { get; set; }

        [Display(Name = "Приоритет")]
        public Priority? Priority { get; set; }


        [Display(Name = "Статус")]
        public string? Status { get; set; }



        [Display(Name = "Дата создания задачи")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateCreate { get; set; }

        [Display(Name = "Дата открытия задачи")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateOpen { get; set; }

        [Display(Name = "Дата закрытия задачи")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateClose { get; set; }

        
    }
    
}
