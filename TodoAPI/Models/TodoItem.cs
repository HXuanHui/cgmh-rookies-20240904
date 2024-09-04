namespace TodoAPI.Models
{
    public class TodoItem
    {
        /*
         * 對應資料庫表格
         */

        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
