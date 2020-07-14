using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a single college course
    /// and the number of possible credits earned at CPTC
    /// </summary>
    class Course
    {
        /// <summary>
        /// The title of the course
        /// Example 
        /// CPW  212 = Advanced.NET Programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The course catalog official description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of college credits awarded for passing the course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The instructor that fteaches the course
        /// </summary>        
        public Instructor CourseInstructor { get; set; }

        /// <summary>
        /// All the students currently enrolled in the class
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}
