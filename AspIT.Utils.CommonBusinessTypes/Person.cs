using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.Utils.CommonBusinessTypes
{
  /// <summary>
  /// Abstract base class representing a person.
  /// </summary>
  public abstract class Person
  {
    protected string firstName;
    protected string lastName;

    /// <summary>
    /// Initializes a new instances of <see cref="Person"/>.
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    public Person(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }

    /// <summary>
    /// Gets or Sets the <see cref="Person"/> firstname.
    /// </summary>
    public string FirstName
    {
      get
      {
        return firstName;
      }

      set
      {
        firstName = value;
      }
    }

    /// <summary>
    /// Gets or Sets the <see cref="Person"/> lastname.
    /// </summary>
    public string LastName
    {
      get
      {
        return lastName;
      }

      set
      {
        lastName = value;
      }
    }

    /// <summary>
    /// Gets a string of the <see cref="Person"/> informating.
    /// </summary>
    /// <returns>Returns a string with the <see cref="Person"/> informatin.</returns>
    public override string ToString()
    {
      return $"Navn: {firstName} {lastName}";
    }
  }
}
