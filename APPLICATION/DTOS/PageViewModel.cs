using System.Collections.Generic;

namespace APPLICATION.DTOS
{
    public class PageViewModel<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}