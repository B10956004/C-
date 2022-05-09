namespace WebApplication2.Model
{
    public class TodoItem
    {
       /// <summary>
     /// 識別id
     /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 待辦事項名稱
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 是否完成
        /// </summary>
        public bool isComplete { get; set; }
    }
}
