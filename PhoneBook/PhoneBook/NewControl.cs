using System.Windows.Forms;

namespace PhoneBook
{
    internal class NewControl
    {
        public string Type;
        public Control Key;
        public Control Value;

        public NewControl(string type, Control key, Control value )
        {
            Type = type;
            Key = key;
            Value = value;
        }
    }
}
