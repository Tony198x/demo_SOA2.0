using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testLib
{
    public class HelloRequestType
    {
        private string nameField;

        /// <summary>
        /// If provided, service will response with Hello 'Name'.
        /// </summary>
        //[ProtoMember(1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
}
