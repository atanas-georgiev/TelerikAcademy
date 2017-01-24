using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    /// <summary>
    /// Problem 16.*
    /// Create a class Group with properties GroupNumber and DepartmentName.
    /// Introduce a property Group in the Student class.
    /// Extract all students from "Mathematics" department.
    /// Use the Join operator.
    /// </summary>
    class Group
    {
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }
        public Group(int groupNumber, string departmentName) 
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
    }
}
