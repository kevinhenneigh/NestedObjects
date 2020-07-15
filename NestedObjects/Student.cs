using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    class Student
    {
        /// <summary>
        /// Students legal first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Students legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// List of courses student is enrolled in
        /// </summary>
        public List<Course> Schedule { get; set; }
    }
}
