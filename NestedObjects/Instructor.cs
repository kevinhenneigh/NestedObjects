using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// represents an Instructor at CPTC
    /// </summary>
    class Instructor
    {
        /// <summary>
        /// Instructors legal full name
        /// Example Jane Doe
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Instructors company email address
        /// Example Jane.Doe@cptc.edu
        /// </summary>
        public string Email { get; set; }
    }
}
