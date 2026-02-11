using System.ComponentModel.DataAnnotations;

namespace datasource_aspnet_efcore.Models.Entities
{
    public class TodoListItem
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string Title { get; set; } = null!;

        [DataType(DataType.Text)]
        public string Description { get; set; } = null!;

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; private init; } = DateTime.Now;
    }
}
