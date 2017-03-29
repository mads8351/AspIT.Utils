using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.Utils.CommonBusinessTypes
{
  /// <summary>
  /// Class derived from <see cref="Employee"/> representing an commission payed employee.
  /// </summary>
  public class CommissionEmployee: Employee
  {
    protected float procent;
    protected float sale;

    /// <summary>
    /// Initializes a new instances of <see cref="CommissionEmployee"/>.
    /// </summary>
    /// <param name="procent">The <see cref="CommissionEmployee"/> Procent.</param>
    /// <param name="sale">The <see cref="CommissionEmployee"/> Sale.</param>
    /// <param name="monthlyIncome">The <see cref="CommissionEmployee"/> MonthlyIncome.</param>
    /// <param name="firstName">The <see cref="CommissionEmployee"/> FirstName.</param>
    /// <param name="lastName">The <see cref="CommissionEmployee"/> LastName.</param>
    public CommissionEmployee(float procent, float sale, double monthlyIncome, string firstName, string lastName) : base(monthlyIncome, firstName, lastName)
    {
      Procent = procent;
      Sale = sale;
      MonthlyIncome = Math.Round(monthlyIncome + ((sale / 100) * procent), 2);
    }

    /// <summary>
    /// Gets or Sets the <see cref="CommissionEmployee"/> Procent.
    /// </summary>
    public float Procent
    {
      get
      {
        return procent;
      }

      set
      {
        procent = value;
      }
    }

    /// <summary>
    /// Gets or Sets the <see cref="CommissionEmployee"/> Sale.
    /// </summary>
    public float Sale
    {
      get
      {
        return sale;
      }

      set
      {
        sale = value;
      }
    }

    /// <summary>
    /// Gets or Sets the <see cref="CommissionEmployee"/> MonthlyIncome. Overrides inherited property <see cref="Employee.MonthlyIncome"/>.
    /// </summary>
    public override double MonthlyIncome
    {
      get
      {
        return base.MonthlyIncome;
      }

      set
      {
        base.MonthlyIncome = value;
      }
    }
  }
}
