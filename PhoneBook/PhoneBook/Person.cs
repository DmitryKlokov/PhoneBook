using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Serialization;

namespace PhoneBook
{
    public class Person:IComparable
    {
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
                using (MemoryStream ms = new MemoryStream())
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
                    using (MemoryStream ms = new MemoryStream(value))
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

            Person otherPerson = obj as Person;
            if (otherPerson != null)
                return Name.CompareTo(otherPerson.Name);
            else
                throw new ArgumentException("Object is not a Person");
        }

        public override string ToString()
        {
            string str = Name + " " + Surname + " \n";
            str += "\n";
            foreach (var number in Phones)
            {
                str += number.Name+" " + number.Value+"\n";
            }
            str += "\n";
            foreach (var email in Emails)
            {
                str += email.Name + " " + email.Value+ "\n";
            }
            str += "\n";
            foreach (var addess in Addresses)
            {
                str += addess.Name + " " + addess.Value + "\n";
            }
            return str+"\n"+ Description;
        }
    }
}
