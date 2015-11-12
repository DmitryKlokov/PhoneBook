using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    class NewControl
    {
        public string type;
        public Control key;
        public Control value;

        public NewControl(string type, Control key, Control value )
        {
            this.type = type;
            this.key = key;
            this.value = value;
        }
    }
}
