namespace _09.StudentGroups.Extentions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StudentsGroupTwo
    {
        public static IEnumerable<Student> ExtensionSortByGroup(this IEnumerable<Student> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;
            return sorted;
        }
    }
}
