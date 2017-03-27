using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.Utils.CommonBusinessTypes
{
  /// <summary>
  /// Class derived from <see cref="Employee"/> representing an hourly payed employee.
  /// </summary>
  public class HourlyEmployee : Employee
  {
    protected double hourlyPay;
    protected int hoursWorked;

    /// <summary>
    /// Initializes a new instances of <see cref="HourlyEmployee"/>.
    /// </summary>
    /// <param name="hourlyPay">The <see cref="HourlyEmployee"/> HourlyPay.</param>
    /// <param name="hoursWorked">The <see cref="HourlyEmployee"/> HoursWorked.</param>
    /// <param name="firstName">The <see cref="HourlyEmployee"/> FirstName.</param>
    /// <param name="lastName">The <see cref="HourlyEmployee"/> LastName.</param>
    public HourlyEmployee(double hourlyPay, int hoursWorked, string firstName, string lastName) : base(0, firstName, lastName)
    {
      HourlyPay = hourlyPay;
      HoursWorked = hoursWorked;
      MonthlyIncome = hourlyPay * hoursWorked;
    }

    /// <summary>
    /// Gets or Sets the <see cref="HourlyEmployee"/> HourlyPay.
    /// </summary>
    public double HourlyPay
    {
      get
      {
        return hourlyPay;
      }

      set
      {
        hourlyPay = value;
      }
    }

    /// <summary>
    /// Gets or Sets <see cref="HourlyEmployee"/> HoursWorked.
    /// </summary>
    public int HoursWorked
    {
      get
      {
        return hoursWorked;
      }

      set
      {
        hoursWorked = value;
      }
    }

    /// <summary>
    /// Gets or Sets the <see cref="HourlyEmployee"/> MonthlyIncome. Overrides inherited property <see cref="Employee.MonthlyIncome"/>.
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
