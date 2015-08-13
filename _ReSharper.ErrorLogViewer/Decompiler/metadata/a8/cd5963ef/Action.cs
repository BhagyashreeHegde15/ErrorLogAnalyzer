// Type: System.Action`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

namespace System
{
  /// <summary>
  /// Encapsulates a method that has a single parameter and does not return a value.
  /// </summary>
  /// <param name="obj">The parameter of the method that this delegate encapsulates.</param><typeparam name="T">The type of the parameter of the method that this delegate encapsulates.This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam><filterpriority>1</filterpriority>
  [__DynamicallyInvokable]
  public delegate void Action<in T>(T obj);
}
