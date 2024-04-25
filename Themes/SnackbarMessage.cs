using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFinanse.Themes
{
    public class SnackbarMessage
    {
        public string Content { get; set; }

        public SnackbarMessage(string content)
        {
            Content = content;
        }
    }
}
