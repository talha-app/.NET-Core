using System;

namespace TodoApplication.Dto
{
    public class TodoInfoDTO
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Completed { get; set; }
    }
}
