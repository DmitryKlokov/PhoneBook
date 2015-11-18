using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace PhoneBook
{
    [Serializable]
    public class Person:IComparable
    {
        public string Id => ToString();
        public string Name;
        public string Surname;
        public List<Field> Phones;
        public List<Field> Emails;
        public List<Field> Addresses;
        public string Description;

        [XmlIgnore]
        public Bitmap LargeIcon { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("LargeIcon")]
        public byte[] LargeIconSerialized
        {
            get
            { // serialize
                if (LargeIcon == null) return null;
                using (var ms = new MemoryStream())
                {
                    LargeIcon.Save(ms, ImageFormat.Bmp);
                    return ms.ToArray();
                }
            }
            set
            { // deserialize
                if (value == null)
                {
                    LargeIcon = null;
                }
                else
                {
                    using (var ms = new MemoryStream(value))
                    {
                        LargeIcon = new Bitmap(ms);
                    }
                }
            }
        }

        public Person()
        {
            Phones = new List<Field>();
            Emails = new List<Field>();
            Addresses = new List<Field>();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            var otherPerson = obj as Person;
            if (otherPerson != null) return string.Compare(Name, otherPerson.Name, StringComparison.Ordinal);
            throw new ArgumentException("Object is not a Person");
        }

        public override string ToString()
        {
            var str = Name + " " + Surname + " \n";
            str += "\n";
            str = Phones.Aggregate(str, (current, number) => current + (number.Name + " " + number.Value + "\n"));
            str += "\n";
            str = Emails.Aggregate(str, (current, email) => current + (email.Name + " " + email.Value + "\n"));
            str += "\n";
            str = Addresses.Aggregate(str, (current, addess) => current + (addess.Name + " " + addess.Value + "\n"));
            return str+"\n"+ Description;
        }
    }
}
