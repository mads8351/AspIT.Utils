using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.Utils.CommonBusinessTypes
{
  /// <summary>
  /// Represents a users user credentials, with username and password.
  /// </summary>
  public struct UserCredentials: IEquatable<UserCredentials>
  {
    private string username;
    private string password;

    /// <summary>
    /// Initializes a new instances of UserCredentials.
    /// </summary>
    public UserCredentials(string username, string password)
    {
      this.username = username;
      this.password = password;
    }

    /// <summary>
    /// Gets or Sets the users username
    /// </summary>
    public string Username
    {
      get
      {
        return username;
      }

      set
      {
        username = value;
      }
    }

    /// <summary>
    /// Gets or Sets the users password
    /// </summary>
    public string Password
    {
      get
      {
        return password;
      }

      set
      {
        password = value;
      }
    }

    /// <summary>
    /// Gets a string of the user informating.
    /// </summary>
    /// <returns>Returns a string with the user informatin</returns>
    public override string ToString()
    {
      return $"Username: {username} Password: {password}";
    }

    /// <summary>
    /// Determines weather the specified <see cref="UserCredentials"/> is equal to this <see cref="UserCredentials"/>.
    /// </summary>
    /// <param name="other">The specified <see cref="UserCredentials"/> to compare with.</param>
    /// <returns>Returns a <see cref="bool"/> indicating weather the two <see cref="UserCredentials"/> is equal</returns>
    public bool Equals(UserCredentials other)
    {
      return username == other.username && password == other.password;
    }
  }
}
