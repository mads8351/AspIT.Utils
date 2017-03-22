using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.Utils.CommonBusinessTypes
{
  /// <summary>
  /// Class derived from <see cref="Person"/> representing a student.
  /// </summary>
  public class Student : Person
  {
    private string subject;

    /// <summary>
    /// Initializes a new instances of <see cref="Student"/>.
    /// </summary>
    /// <param name="subject">The subject the <see cref="Student"/> is studying.</param>
    /// <param name="firstName">The <see cref="Student"/> firstname.</param>
    /// <param name="lastName">The <see cref="Student"/> lastname.</param>
    public Student(string subject, string firstName, string lastName) : base(firstName, lastName)
    {
      Subject = subject;
    }

    /// <summary>
    /// Gets or Sets the <see cref="Student"/> subject.
    /// </summary>
    public string Subject
    {
      get
      {
        return subject;
      }

      set
      {
        subject = value;
      }
    }

    /// <summary>
    /// Gets a string of the <see cref="Student"/> informating.
    /// </summary>
    /// <returns>Returns a string with the <see cref="Student"/> informatin.</returns>
    public override string ToString()
    {
      return base.ToString() + $" Fag: {subject}";
    }
  }
}
