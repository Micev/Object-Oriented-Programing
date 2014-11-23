using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class PropertyChangedEventArgs : EventArgs
    {
        private string property;
        private string oldName;
        private string newName;

        public string Property
        {
            get { return this.property; }
        }

        public string OldName
        {
            get { return this.oldName; }
        }

        public string NewName
        {
            get { return this.newName; }
        }

        public PropertyChangedEventArgs(string property, string oldName, string newName)
        {
            this.property = property;
            this.oldName = oldName;
            this.newName = newName;
        }
    }
}
