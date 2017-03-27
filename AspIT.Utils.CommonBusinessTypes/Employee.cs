using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.Utils.CommonBusinessTypes
{
  /// <summary>
  /// Class derived from <see cref="Person"/> representing an monthly payed employee.
  /// </summary>
  public class Employee : Person
  {
    protected double monthlyIncome;

    /// <summary>
    /// Initializes a new instances of <see cref="Employee"/>.
    /// </summary>
    /// <param name="monthlyIncome">The monthlyincome of the <see cref="Employee"/>.</param>
    /// <param name="firstName">The <see cref="Employee"/> FirstName.</param>
    /// <param name="lastName">The <see cref="Employee"/> LastnNme.</param>
    public Employee(double monthlyIncome, string firstName, string lastName) : base(firstName, lastName)
    {
      MonthlyIncome = monthlyIncome;
    }

    /// <summary>
    /// Gets or Sets the <see cref="Employee"/> monthlyincome.
    /// </summary>
    public virtual double MonthlyIncome
    {
      get
      {
        return monthlyIncome;
      }

      set
      {
        monthlyIncome = value;
      }
    }

    /// <summary>
    /// Gets a string of the <see cref="Employee"/> informating.
    /// </summary>
    /// <returns>Returns a string with the <see cref="Employee"/> informatin.</returns>
    public override string ToString()
    {
      return base.ToString() + $"Månedlige indkomst: {monthlyIncome} kr";
    }
  }
}
