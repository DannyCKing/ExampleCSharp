using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCSharpCode.Models
{
    public interface IPerson
    {
        /// <summary>
        /// GUID meant to ensure each objects uniqueness - would be used as a PK in the database 
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// First name or given name or a individual
        /// </summary>
        string FirstName { get; }

        /// <summary>
        /// The last name or surname of an individual
        /// </summary>
        string LastName { get; }

        /// <summary>
        /// The Social Security of an individual
        /// </summary>
        string SSN { get; }
    }
}
