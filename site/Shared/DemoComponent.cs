﻿using System.Collections.Generic;

namespace AntBlazor.Docs
{
    public class DemoComponent
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Doc { get; set; }

        public List<DemoItem> DemoList { get; set; }
    }

    public class DemoItem
    {
        public int Order { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public string Type { get; set; }
    }
}