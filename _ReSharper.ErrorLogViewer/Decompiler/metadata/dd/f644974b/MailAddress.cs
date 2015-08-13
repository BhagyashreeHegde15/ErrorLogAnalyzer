// Type: System.Net.Mail.MailAddress
// Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll

using System.Runtime;
using System.Text;

namespace System.Net.Mail
{
  /// <summary>
  /// Represents the address of an electronic mail sender or recipient.
  /// </summary>
  public class MailAddress
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Net.Mail.MailAddress"/> class using the specified address.
    /// </summary>
    /// <param name="address">A <see cref="T:System.String"/> that contains an e-mail address.</param><exception cref="T:System.ArgumentNullException"><paramref name="address"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="address"/> is <see cref="F:System.String.Empty"/> ("").</exception><exception cref="T:System.FormatException"><paramref name="address"/> is not in a recognized format.</exception>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public MailAddress(string address);
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Net.Mail.MailAddress"/> class using the specified address and display name.
    /// </summary>
    /// <param name="address">A <see cref="T:System.String"/> that contains an e-mail address.</param><param name="displayName">A <see cref="T:System.String"/> that contains the display name associated with <paramref name="address"/>. This parameter can be null.</param><exception cref="T:System.ArgumentNullException"><paramref name="address"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="address"/> is <see cref="F:System.String.Empty"/> ("").</exception><exception cref="T:System.FormatException"><paramref name="address"/> is not in a recognized format.-or-<paramref name="address"/> contains non-ASCII characters.</exception>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public MailAddress(string address, string displayName);
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Net.Mail.MailAddress"/> class using the specified address, display name, and encoding.
    /// </summary>
    /// <param name="address">A <see cref="T:System.String"/> that contains an e-mail address.</param><param name="displayName">A <see cref="T:System.String"/> that contains the display name associated with <paramref name="address"/>.</param><param name="displayNameEncoding">The <see cref="T:System.Text.Encoding"/> that defines the character set used for <paramref name="displayName"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="address"/> is null.-or-<paramref name="displayName"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="address"/> is <see cref="F:System.String.Empty"/> ("").-or-<paramref name="displayName"/> is <see cref="F:System.String.Empty"/> ("").</exception><exception cref="T:System.FormatException"><paramref name="address"/> is not in a recognized format.-or-<paramref name="address"/> contains non-ASCII characters.</exception>
    public MailAddress(string address, string displayName, Encoding displayNameEncoding);
    /// <summary>
    /// Returns a string representation of this instance.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.String"/> that contains the contents of this <see cref="T:System.Net.Mail.MailAddress"/>.
    /// </returns>
    public override string ToString();
    /// <summary>
    /// Compares two mail addresses.
    /// </summary>
    /// 
    /// <returns>
    /// true if the two mail addresses are equal; otherwise, false.
    /// </returns>
    /// <param name="value">A <see cref="T:System.Net.Mail.MailAddress"/> instance to compare to the current instance.</param>
    public override bool Equals(object value);
    /// <summary>
    /// Returns a hash value for a mail address.
    /// </summary>
    /// 
    /// <returns>
    /// An integer hash value.
    /// </returns>
    public override int GetHashCode();
    /// <summary>
    /// Gets the display name composed from the display name and address information specified when this instance was created.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.String"/> that contains the display name; otherwise, <see cref="F:System.String.Empty"/> ("") if no display name information was specified when this instance was created.
    /// </returns>
    public string DisplayName { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; }
    /// <summary>
    /// Gets the user information from the address specified when this instance was created.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.String"/> that contains the user name portion of the <see cref="P:System.Net.Mail.MailAddress.Address"/>.
    /// </returns>
    public string User { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; }
    /// <summary>
    /// Gets the host portion of the address specified when this instance was created.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.String"/> that contains the name of the host computer that accepts e-mail for the <see cref="P:System.Net.Mail.MailAddress.User"/> property.
    /// </returns>
    public string Host { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; }
    /// <summary>
    /// Gets the e-mail address specified when this instance was created.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.String"/> that contains the e-mail address.
    /// </returns>
    public string Address { get; }
  }
}
