// Type: System.Diagnostics.Process
// Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll

using System;
using System.ComponentModel;
using System.IO;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Diagnostics
{
  /// <summary>
  /// Provides access to local and remote processes and enables you to start and stop local system processes.
  /// </summary>
  /// <filterpriority>1</filterpriority>
  [DefaultEvent("Exited")]
  [Designer("System.Diagnostics.Design.ProcessDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [MonitoringDescription("ProcessDesc")]
  [DefaultProperty("StartInfo")]
  [PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
  [HostProtection(SecurityAction.LinkDemand, ExternalProcessMgmt = true, SelfAffectingProcessMgmt = true, SharedState = true, Synchronization = true)]
  [PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
  public class Process : Component
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Diagnostics.Process"/> class.
    /// </summary>
    public Process();
    /// <summary>
    /// Closes a process that has a user interface by sending a close message to its main window.
    /// </summary>
    /// 
    /// <returns>
    /// true if the close message was successfully sent; false if the associated process does not have a main window or if the main window is disabled (for example if a modal dialog is being shown).
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> property to false to access this property on Windows 98 and Windows Me.</exception><exception cref="T:System.InvalidOperationException">The process has already exited. -or-No process is associated with this <see cref="T:System.Diagnostics.Process"/> object.</exception><filterpriority>1</filterpriority>
    public bool CloseMainWindow();
    /// <summary>
    /// Release all resources used by this process.
    /// </summary>
    /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
    protected override void Dispose(bool disposing);
    /// <summary>
    /// Frees all the resources that are associated with this component.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    public void Close();
    /// <summary>
    /// Puts a <see cref="T:System.Diagnostics.Process"/> component in state to interact with operating system processes that run in a special mode by enabling the native property SeDebugPrivilege on the current thread.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    public static void EnterDebugMode();
    /// <summary>
    /// Takes a <see cref="T:System.Diagnostics.Process"/> component out of the state that lets it interact with operating system processes that run in a special mode.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    public static void LeaveDebugMode();
    /// <summary>
    /// Returns a new <see cref="T:System.Diagnostics.Process"/> component, given a process identifier and the name of a computer on the network.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.Diagnostics.Process"/> component that is associated with a remote process resource identified by the <paramref name="processId"/> parameter.
    /// </returns>
    /// <param name="processId">The system-unique identifier of a process resource. </param><param name="machineName">The name of a computer on the network. </param><exception cref="T:System.ArgumentException">The process specified by the <paramref name="processId"/> parameter is not running. The identifier might be expired.-or- The <paramref name="machineName"/> parameter syntax is invalid. The name might have length zero (0). </exception><exception cref="T:System.ArgumentNullException">The <paramref name="machineName"/> parameter is null. </exception><exception cref="T:System.InvalidOperationException">The process was not started by this object.</exception><filterpriority>1</filterpriority>
    public static Process GetProcessById(int processId, string machineName);
    /// <summary>
    /// Returns a new <see cref="T:System.Diagnostics.Process"/> component, given the identifier of a process on the local computer.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.Diagnostics.Process"/> component that is associated with the local process resource identified by the <paramref name="processId"/> parameter.
    /// </returns>
    /// <param name="processId">The system-unique identifier of a process resource. </param><exception cref="T:System.ArgumentException">The process specified by the <paramref name="processId"/> parameter is not running. The identifier might be expired. </exception><exception cref="T:System.InvalidOperationException">The process was not started by this object.</exception><filterpriority>1</filterpriority>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public static Process GetProcessById(int processId);
    /// <summary>
    /// Creates an array of new <see cref="T:System.Diagnostics.Process"/> components and associates them with all the process resources on the local computer that share the specified process name.
    /// </summary>
    /// 
    /// <returns>
    /// An array of type <see cref="T:System.Diagnostics.Process"/> that represents the process resources running the specified application or file.
    /// </returns>
    /// <param name="processName">The friendly name of the process. </param><exception cref="T:System.InvalidOperationException">There are problems accessing the performance counter API's used to get process information. This exception is specific to Windows NT, Windows 2000, and Windows XP. </exception><filterpriority>1</filterpriority>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public static Process[] GetProcessesByName(string processName);
    /// <summary>
    /// Creates an array of new <see cref="T:System.Diagnostics.Process"/> components and associates them with all the process resources on a remote computer that share the specified process name.
    /// </summary>
    /// 
    /// <returns>
    /// An array of type <see cref="T:System.Diagnostics.Process"/> that represents the process resources running the specified application or file.
    /// </returns>
    /// <param name="processName">The friendly name of the process. </param><param name="machineName">The name of a computer on the network. </param><exception cref="T:System.ArgumentException">The <paramref name="machineName"/> parameter syntax is invalid. It might have length zero (0). </exception><exception cref="T:System.ArgumentNullException">The <paramref name="machineName"/> parameter is null. </exception><exception cref="T:System.PlatformNotSupportedException">The operating system platform does not support this operation on remote computers. </exception><exception cref="T:System.InvalidOperationException">There are problems accessing the performance counter API's used to get process information. This exception is specific to Windows NT, Windows 2000, and Windows XP. </exception><exception cref="T:System.ComponentModel.Win32Exception">A problem occurred accessing an underlying system API. </exception><filterpriority>1</filterpriority>
    public static Process[] GetProcessesByName(string processName, string machineName);
    /// <summary>
    /// Creates a new <see cref="T:System.Diagnostics.Process"/> component for each process resource on the local computer.
    /// </summary>
    /// 
    /// <returns>
    /// An array of type <see cref="T:System.Diagnostics.Process"/> that represents all the process resources running on the local computer.
    /// </returns>
    /// <filterpriority>1</filterpriority>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public static Process[] GetProcesses();
    /// <summary>
    /// Creates a new <see cref="T:System.Diagnostics.Process"/> component for each process resource on the specified computer.
    /// </summary>
    /// 
    /// <returns>
    /// An array of type <see cref="T:System.Diagnostics.Process"/> that represents all the process resources running on the specified computer.
    /// </returns>
    /// <param name="machineName">The computer from which to read the list of processes. </param><exception cref="T:System.ArgumentException">The <paramref name="machineName"/> parameter syntax is invalid. It might have length zero (0). </exception><exception cref="T:System.ArgumentNullException">The <paramref name="machineName"/> parameter is null. </exception><exception cref="T:System.PlatformNotSupportedException">The operating system platform does not support this operation on remote computers. </exception><exception cref="T:System.InvalidOperationException">There are problems accessing the performance counter API's used to get process information. This exception is specific to Windows NT, Windows 2000, and Windows XP. </exception><exception cref="T:System.ComponentModel.Win32Exception">A problem occurred accessing an underlying system API. </exception><filterpriority>1</filterpriority>
    public static Process[] GetProcesses(string machineName);
    /// <summary>
    /// Gets a new <see cref="T:System.Diagnostics.Process"/> component and associates it with the currently active process.
    /// </summary>
    /// 
    /// <returns>
    /// A new <see cref="T:System.Diagnostics.Process"/> component associated with the process resource that is running the calling application.
    /// </returns>
    /// <filterpriority>1</filterpriority>
    public static Process GetCurrentProcess();
    /// <summary>
    /// Raises the <see cref="E:System.Diagnostics.Process.Exited"/> event.
    /// </summary>
    protected void OnExited();
    /// <summary>
    /// Discards any information about the associated process that has been cached inside the process component.
    /// </summary>
    /// <filterpriority>1</filterpriority>
    public void Refresh();
    /// <summary>
    /// Starts (or reuses) the process resource that is specified by the <see cref="P:System.Diagnostics.Process.StartInfo"/> property of this <see cref="T:System.Diagnostics.Process"/> component and associates it with the component.
    /// </summary>
    /// 
    /// <returns>
    /// true if a process resource is started; false if no new process resource is started (for example, if an existing process is reused).
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">No file name was specified in the <see cref="T:System.Diagnostics.Process"/> component's <see cref="P:System.Diagnostics.Process.StartInfo"/>.-or- The <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> member of the <see cref="P:System.Diagnostics.Process.StartInfo"/> property is true while <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput"/>, <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput"/>, or <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError"/> is true. </exception><exception cref="T:System.ComponentModel.Win32Exception">There was an error in opening the associated file. </exception><exception cref="T:System.ObjectDisposedException">The process object has already been disposed. </exception><filterpriority>1</filterpriority>
    public bool Start();
    /// <summary>
    /// Starts a process resource by specifying the name of an application, a user name, a password, and a domain and associates the resource with a new <see cref="T:System.Diagnostics.Process"/> component.
    /// </summary>
    /// 
    /// <returns>
    /// A new <see cref="T:System.Diagnostics.Process"/> component that is associated with the process resource, or null if no process resource is started (for example, if an existing process is reused).
    /// </returns>
    /// <param name="fileName">The name of an application file to run in the process.</param><param name="userName">The user name to use when starting the process.</param><param name="password">A <see cref="T:System.Security.SecureString"/> that contains the password to use when starting the process.</param><param name="domain">The domain to use when starting the process.</param><exception cref="T:System.InvalidOperationException">No file name was specified. </exception><exception cref="T:System.ComponentModel.Win32Exception"><paramref name="fileName"/> is not an executable (.exe) file.</exception><exception cref="T:System.ComponentModel.Win32Exception">There was an error in opening the associated file. </exception><exception cref="T:System.ObjectDisposedException">The process object has already been disposed. </exception><filterpriority>1</filterpriority>
    public static Process Start(string fileName, string userName, SecureString password, string domain);
    /// <summary>
    /// Starts a process resource by specifying the name of an application, a set of command-line arguments, a user name, a password, and a domain and associates the resource with a new <see cref="T:System.Diagnostics.Process"/> component.
    /// </summary>
    /// 
    /// <returns>
    /// A new <see cref="T:System.Diagnostics.Process"/> component that is associated with the process resource, or null if no process resource is started (for example, if an existing process is reused).
    /// </returns>
    /// <param name="fileName">The name of an application file to run in the process. </param><param name="arguments">Command-line arguments to pass when starting the process. </param><param name="userName">The user name to use when starting the process.</param><param name="password">A <see cref="T:System.Security.SecureString"/> that contains the password to use when starting the process.</param><param name="domain">The domain to use when starting the process.</param><exception cref="T:System.InvalidOperationException">No file name was specified.</exception><exception cref="T:System.ComponentModel.Win32Exception"><paramref name="fileName"/> is not an executable (.exe) file.</exception><exception cref="T:System.ComponentModel.Win32Exception">An error occurred when opening the associated file. -or-The sum of the length of the arguments and the length of the full path to the associated file exceeds 2080. The error message associated with this exception can be one of the following: "The data area passed to a system call is too small." or "Access is denied."</exception><exception cref="T:System.ObjectDisposedException">The process object has already been disposed. </exception><filterpriority>1</filterpriority>
    public static Process Start(string fileName, string arguments, string userName, SecureString password, string domain);
    /// <summary>
    /// Starts a process resource by specifying the name of a document or application file and associates the resource with a new <see cref="T:System.Diagnostics.Process"/> component.
    /// </summary>
    /// 
    /// <returns>
    /// A new <see cref="T:System.Diagnostics.Process"/> component that is associated with the process resource, or null, if no process resource is started (for example, if an existing process is reused).
    /// </returns>
    /// <param name="fileName">The name of a document or application file to run in the process. </param><exception cref="T:System.ComponentModel.Win32Exception">An error occurred when opening the associated file. </exception><exception cref="T:System.ObjectDisposedException">The process object has already been disposed. </exception><exception cref="T:System.IO.FileNotFoundException">The PATH environment variable has a string containing quotes.</exception><filterpriority>1</filterpriority>
    public static Process Start(string fileName);
    /// <summary>
    /// Starts a process resource by specifying the name of an application and a set of command-line arguments, and associates the resource with a new <see cref="T:System.Diagnostics.Process"/> component.
    /// </summary>
    /// 
    /// <returns>
    /// A new <see cref="T:System.Diagnostics.Process"/> component that is associated with the process, or null, if no process resource is started (for example, if an existing process is reused).
    /// </returns>
    /// <param name="fileName">The name of an application file to run in the process. </param><param name="arguments">Command-line arguments to pass when starting the process. </param><exception cref="T:System.InvalidOperationException">The <paramref name="fileName"/> or <paramref name="arguments"/> parameter is null. </exception><exception cref="T:System.ComponentModel.Win32Exception">An error occurred when opening the associated file. -or-The sum of the length of the arguments and the length of the full path to the process exceeds 2080. The error message associated with this exception can be one of the following: "The data area passed to a system call is too small." or "Access is denied."</exception><exception cref="T:System.ObjectDisposedException">The process object has already been disposed. </exception><exception cref="T:System.IO.FileNotFoundException">The PATH environment variable has a string containing quotes.</exception><filterpriority>1</filterpriority>
    public static Process Start(string fileName, string arguments);
    /// <summary>
    /// Starts the process resource that is specified by the parameter containing process start information (for example, the file name of the process to start) and associates the resource with a new <see cref="T:System.Diagnostics.Process"/> component.
    /// </summary>
    /// 
    /// <returns>
    /// A new <see cref="T:System.Diagnostics.Process"/> component that is associated with the process resource, or null if no process resource is started (for example, if an existing process is reused).
    /// </returns>
    /// <param name="startInfo">The <see cref="T:System.Diagnostics.ProcessStartInfo"/> that contains the information that is used to start the process, including the file name and any command-line arguments. </param><exception cref="T:System.InvalidOperationException">No file name was specified in the <paramref name="startInfo"/> parameter's <see cref="P:System.Diagnostics.ProcessStartInfo.FileName"/> property.-or- The <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> property of the <paramref name="startInfo"/> parameter is true and the <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput"/>, <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput"/>, or <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError"/> property is also true.-or-The <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> property of the <paramref name="startInfo"/> parameter is true and the <see cref="P:System.Diagnostics.ProcessStartInfo.UserName"/> property is not null or empty or the <see cref="P:System.Diagnostics.ProcessStartInfo.Password"/> property is not null.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="startInfo"/> parameter is null. </exception><exception cref="T:System.ObjectDisposedException">The process object has already been disposed. </exception><exception cref="T:System.IO.FileNotFoundException">The file specified in the <paramref name="startInfo"/> parameter's <see cref="P:System.Diagnostics.ProcessStartInfo.FileName"/> property could not be found.</exception><exception cref="T:System.ComponentModel.Win32Exception">An error occurred when opening the associated file. -or-The sum of the length of the arguments and the length of the full path to the process exceeds 2080. The error message associated with this exception can be one of the following: "The data area passed to a system call is too small." or "Access is denied."</exception><filterpriority>1</filterpriority>
    public static Process Start(ProcessStartInfo startInfo);
    /// <summary>
    /// Immediately stops the associated process.
    /// </summary>
    /// <exception cref="T:System.ComponentModel.Win32Exception">The associated process could not be terminated. -or-The process is terminating.-or- The associated process is a Win16 executable.</exception><exception cref="T:System.NotSupportedException">You are attempting to call <see cref="M:System.Diagnostics.Process.Kill"/> for a process that is running on a remote computer. The method is available only for processes running on the local computer.</exception><exception cref="T:System.InvalidOperationException">The process has already exited. -or-There is no process associated with this <see cref="T:System.Diagnostics.Process"/> object.</exception><filterpriority>1</filterpriority>
    public void Kill();
    /// <summary>
    /// Formats the process's name as a string, combined with the parent component type, if applicable.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Diagnostics.Process.ProcessName"/>, combined with the base component's <see cref="M:System.Object.ToString"/> return value.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException"><see cref="M:System.Diagnostics.Process.ToString"/> is not supported on Windows 98.</exception><filterpriority>2</filterpriority>
    public override string ToString();
    /// <summary>
    /// Instructs the <see cref="T:System.Diagnostics.Process"/> component to wait the specified number of milliseconds for the associated process to exit.
    /// </summary>
    /// 
    /// <returns>
    /// true if the associated process has exited; otherwise, false.
    /// </returns>
    /// <param name="milliseconds">The amount of time, in milliseconds, to wait for the associated process to exit. The maximum is the largest possible value of a 32-bit integer, which represents infinity to the operating system. </param><exception cref="T:System.ComponentModel.Win32Exception">The wait setting could not be accessed. </exception><exception cref="T:System.SystemException">No process <see cref="P:System.Diagnostics.Process.Id"/> has been set, and a <see cref="P:System.Diagnostics.Process.Handle"/> from which the <see cref="P:System.Diagnostics.Process.Id"/> property can be determined does not exist.-or- There is no process associated with this <see cref="T:System.Diagnostics.Process"/> object.-or- You are attempting to call <see cref="M:System.Diagnostics.Process.WaitForExit(System.Int32)"/> for a process that is running on a remote computer. This method is available only for processes that are running on the local computer. </exception><filterpriority>1</filterpriority>
    public bool WaitForExit(int milliseconds);
    /// <summary>
    /// Instructs the <see cref="T:System.Diagnostics.Process"/> component to wait indefinitely for the associated process to exit.
    /// </summary>
    /// <exception cref="T:System.ComponentModel.Win32Exception">The wait setting could not be accessed. </exception><exception cref="T:System.SystemException">No process <see cref="P:System.Diagnostics.Process.Id"/> has been set, and a <see cref="P:System.Diagnostics.Process.Handle"/> from which the <see cref="P:System.Diagnostics.Process.Id"/> property can be determined does not exist.-or- There is no process associated with this <see cref="T:System.Diagnostics.Process"/> object.-or- You are attempting to call <see cref="M:System.Diagnostics.Process.WaitForExit"/> for a process that is running on a remote computer. This method is available only for processes that are running on the local computer. </exception><filterpriority>1</filterpriority>
    public void WaitForExit();
    /// <summary>
    /// Causes the <see cref="T:System.Diagnostics.Process"/> component to wait the specified number of milliseconds for the associated process to enter an idle state. This overload applies only to processes with a user interface and, therefore, a message loop.
    /// </summary>
    /// 
    /// <returns>
    /// true if the associated process has reached an idle state; otherwise, false.
    /// </returns>
    /// <param name="milliseconds">A value of 1 to <see cref="F:System.Int32.MaxValue"/> that specifies the amount of time, in milliseconds, to wait for the associated process to become idle. A value of 0 specifies an immediate return, and a value of -1 specifies an infinite wait. </param><exception cref="T:System.InvalidOperationException">The process does not have a graphical interface.-or-An unknown error occurred. The process failed to enter an idle state.-or-The process has already exited. -or-No process is associated with this <see cref="T:System.Diagnostics.Process"/> object.</exception><filterpriority>1</filterpriority>
    public bool WaitForInputIdle(int milliseconds);
    /// <summary>
    /// Causes the <see cref="T:System.Diagnostics.Process"/> component to wait indefinitely for the associated process to enter an idle state. This overload applies only to processes with a user interface and, therefore, a message loop.
    /// </summary>
    /// 
    /// <returns>
    /// true if the associated process has reached an idle state.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">The process does not have a graphical interface.-or-An unknown error occurred. The process failed to enter an idle state.-or-The process has already exited. -or-No process is associated with this <see cref="T:System.Diagnostics.Process"/> object.</exception><filterpriority>1</filterpriority>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public bool WaitForInputIdle();
    /// <summary>
    /// Begins asynchronous read operations on the redirected <see cref="P:System.Diagnostics.Process.StandardOutput"/> stream of the application.
    /// </summary>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput"/> property is false.- or - An asynchronous read operation is already in progress on the <see cref="P:System.Diagnostics.Process.StandardOutput"/> stream.- or - The <see cref="P:System.Diagnostics.Process.StandardOutput"/> stream has been used by a synchronous read operation. </exception><filterpriority>2</filterpriority>
    [ComVisible(false)]
    public void BeginOutputReadLine();
    /// <summary>
    /// Begins asynchronous read operations on the redirected <see cref="P:System.Diagnostics.Process.StandardError"/> stream of the application.
    /// </summary>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError"/> property is false.- or - An asynchronous read operation is already in progress on the <see cref="P:System.Diagnostics.Process.StandardError"/> stream.- or - The <see cref="P:System.Diagnostics.Process.StandardError"/> stream has been used by a synchronous read operation. </exception><filterpriority>2</filterpriority>
    [ComVisible(false)]
    public void BeginErrorReadLine();
    /// <summary>
    /// Cancels the asynchronous read operation on the redirected <see cref="P:System.Diagnostics.Process.StandardOutput"/> stream of an application.
    /// </summary>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.Process.StandardOutput"/> stream is not enabled for asynchronous read operations. </exception><filterpriority>2</filterpriority>
    [ComVisible(false)]
    public void CancelOutputRead();
    /// <summary>
    /// Cancels the asynchronous read operation on the redirected <see cref="P:System.Diagnostics.Process.StandardError"/> stream of an application.
    /// </summary>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.Process.StandardError"/> stream is not enabled for asynchronous read operations. </exception><filterpriority>2</filterpriority>
    [ComVisible(false)]
    public void CancelErrorRead();
    /// <summary>
    /// Gets the base priority of the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The base priority, which is computed from the <see cref="P:System.Diagnostics.Process.PriorityClass"/> of the associated process.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> property to false to access this property on Windows 98 and Windows Me.</exception><exception cref="T:System.InvalidOperationException">The process has exited.-or- The process has not started, so there is no process ID. </exception><filterpriority>2</filterpriority>
    [MonitoringDescription("ProcessBasePriority")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int BasePriority { get; }
    /// <summary>
    /// Gets the value that the associated process specified when it terminated.
    /// </summary>
    /// 
    /// <returns>
    /// The code that the associated process specified when it terminated.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">The process has not exited.-or- The process <see cref="P:System.Diagnostics.Process.Handle"/> is not valid. </exception><exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.ExitCode"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessExitCode")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int ExitCode { get; }
    /// <summary>
    /// Gets a value indicating whether the associated process has been terminated.
    /// </summary>
    /// 
    /// <returns>
    /// true if the operating system process referenced by the <see cref="T:System.Diagnostics.Process"/> component has terminated; otherwise, false.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">There is no process associated with the object. </exception><exception cref="T:System.ComponentModel.Win32Exception">The exit code for the process could not be retrieved. </exception><exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.HasExited"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception><filterpriority>1</filterpriority>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessTerminated")]
    public bool HasExited { get; }
    /// <summary>
    /// Gets the time that the associated process exited.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.DateTime"/> that indicates when the associated process was terminated.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.ExitTime"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception><filterpriority>1</filterpriority>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessExitTime")]
    public DateTime ExitTime { get; }
    /// <summary>
    /// Gets the native handle of the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The handle that the operating system assigned to the associated process when the process was started. The system uses this handle to keep track of process attributes.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">The process has not been started or has exited. The <see cref="P:System.Diagnostics.Process.Handle"/> property cannot be read because there is no process associated with this <see cref="T:System.Diagnostics.Process"/> instance.-or- The <see cref="T:System.Diagnostics.Process"/> instance has been attached to a running process but you do not have the necessary permissions to get a handle with full access rights. </exception><exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.Handle"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception><filterpriority>1</filterpriority>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessHandle")]
    public IntPtr Handle { get; }
    /// <summary>
    /// Gets the number of handles opened by the process.
    /// </summary>
    /// 
    /// <returns>
    /// The number of operating system handles the process has opened.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> property to false to access this property on Windows 98 and Windows Me.</exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessHandleCount")]
    public int HandleCount { get; }
    /// <summary>
    /// Gets the unique identifier for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The system-generated unique identifier of the process that is referenced by this <see cref="T:System.Diagnostics.Process"/> instance.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">The process's <see cref="P:System.Diagnostics.Process.Id"/> property has not been set.-or- There is no process associated with this <see cref="T:System.Diagnostics.Process"/> object. </exception><exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> property to false to access this property on Windows 98 and Windows Me.</exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessId")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Id { get; }
    /// <summary>
    /// Gets the name of the computer the associated process is running on.
    /// </summary>
    /// 
    /// <returns>
    /// The name of the computer that the associated process is running on.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">There is no process associated with this <see cref="T:System.Diagnostics.Process"/> object. </exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessMachineName")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string MachineName { get; }
    /// <summary>
    /// Gets the window handle of the main window of the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The system-generated window handle of the main window of the associated process.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.Process.MainWindowHandle"/> is not defined because the process has exited. </exception><exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.MainWindowHandle"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception><exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> to false to access this property on Windows 98 and Windows Me.</exception><filterpriority>2</filterpriority>
    [MonitoringDescription("ProcessMainWindowHandle")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IntPtr MainWindowHandle { get; }
    /// <summary>
    /// Gets the caption of the main window of the process.
    /// </summary>
    /// 
    /// <returns>
    /// The main window title of the process.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.Process.MainWindowTitle"/> property is not defined because the process has exited. </exception><exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.MainWindowTitle"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception><exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> to false to access this property on Windows 98 and Windows Me.</exception><filterpriority>1</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessMainWindowTitle")]
    public string MainWindowTitle { get; }
    /// <summary>
    /// Gets the main module for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.Diagnostics.ProcessModule"/> that was used to start the process.
    /// </returns>
    /// <exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.MainModule"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception><exception cref="T:System.ComponentModel.Win32Exception">A 32-bit process is trying to access the modules of a 64-bit process.</exception><exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> to false to access this property on Windows 98 and Windows Me.</exception><exception cref="T:System.InvalidOperationException">The process <see cref="P:System.Diagnostics.Process.Id"/> is not available.-or- The process has exited. </exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessMainModule")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ProcessModule MainModule { get; }
    /// <summary>
    /// Gets or sets the maximum allowable working set size for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum working set size that is allowed in memory for the process, in bytes.
    /// </returns>
    /// <exception cref="T:System.ArgumentException">The maximum working set size is invalid. It must be greater than or equal to the minimum working set size.</exception><exception cref="T:System.ComponentModel.Win32Exception">Working set information cannot be retrieved from the associated process resource.-or- The process identifier or process handle is zero because the process has not been started. </exception><exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.MaxWorkingSet"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception><exception cref="T:System.InvalidOperationException">The process <see cref="P:System.Diagnostics.Process.Id"/> is not available.-or- The process has exited. </exception><exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [MonitoringDescription("ProcessMaxWorkingSet")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IntPtr MaxWorkingSet { get; set; }
    /// <summary>
    /// Gets or sets the minimum allowable working set size for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The minimum working set size that is required in memory for the process, in bytes.
    /// </returns>
    /// <exception cref="T:System.ArgumentException">The minimum working set size is invalid. It must be less than or equal to the maximum working set size.</exception><exception cref="T:System.ComponentModel.Win32Exception">Working set information cannot be retrieved from the associated process resource.-or- The process identifier or process handle is zero because the process has not been started. </exception><exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.MinWorkingSet"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer. </exception><exception cref="T:System.InvalidOperationException">The process <see cref="P:System.Diagnostics.Process.Id"/> is not available.-or- The process has exited.</exception><exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessMinWorkingSet")]
    public IntPtr MinWorkingSet { get; set; }
    /// <summary>
    /// Gets the modules that have been loaded by the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// An array of type <see cref="T:System.Diagnostics.ProcessModule"/> that represents the modules that have been loaded by the associated process.
    /// </returns>
    /// <exception cref="T:System.NotSupportedException">You are attempting to access the <see cref="P:System.Diagnostics.Process.Modules"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer. </exception><exception cref="T:System.InvalidOperationException">The process <see cref="P:System.Diagnostics.Process.Id"/> is not available.</exception><exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> to false to access this property on Windows 98 and Windows Me.</exception><exception cref="T:System.ComponentModel.Win32Exception">You are attempting to access the <see cref="P:System.Diagnostics.Process.Modules"/> property for either the system process or the idle process. These processes do not have modules.</exception><filterpriority>2</filterpriority>
    [MonitoringDescription("ProcessModules")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ProcessModuleCollection Modules { get; }
    /// <summary>
    /// Gets the nonpaged system memory size allocated to this process.
    /// </summary>
    /// 
    /// <returns>
    /// The amount of memory, in bytes, the system has allocated for the associated process that cannot be written to the virtual memory paging file.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.NonpagedSystemMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessNonpagedSystemMemorySize")]
    public int NonpagedSystemMemorySize { get; }
    /// <summary>
    /// Gets the amount of nonpaged system memory allocated for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The amount of system memory, in bytes, allocated for the associated process that cannot be written to the virtual memory paging file.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property.</exception><filterpriority>2</filterpriority>
    [ComVisible(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessNonpagedSystemMemorySize")]
    public long NonpagedSystemMemorySize64 { get; }
    /// <summary>
    /// Gets the paged memory size.
    /// </summary>
    /// 
    /// <returns>
    /// The amount of memory, in bytes, allocated by the associated process that can be written to the virtual memory paging file.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PagedMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    [MonitoringDescription("ProcessPagedMemorySize")]
    public int PagedMemorySize { get; }
    /// <summary>
    /// Gets the amount of paged memory allocated for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The amount of memory, in bytes, allocated in the virtual memory paging file for the associated process.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property.</exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [ComVisible(false)]
    [MonitoringDescription("ProcessPagedMemorySize")]
    public long PagedMemorySize64 { get; }
    /// <summary>
    /// Gets the paged system memory size.
    /// </summary>
    /// 
    /// <returns>
    /// The amount of memory, in bytes, the system has allocated for the associated process that can be written to the virtual memory paging file.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PagedSystemMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessPagedSystemMemorySize")]
    public int PagedSystemMemorySize { get; }
    /// <summary>
    /// Gets the amount of pageable system memory allocated for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The amount of system memory, in bytes, allocated for the associated process that can be written to the virtual memory paging file.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property.</exception><filterpriority>2</filterpriority>
    [ComVisible(false)]
    [MonitoringDescription("ProcessPagedSystemMemorySize")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public long PagedSystemMemorySize64 { get; }
    /// <summary>
    /// Gets the peak paged memory size.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum amount of memory, in bytes, allocated by the associated process that could be written to the virtual memory paging file.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessPeakPagedMemorySize")]
    [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakPagedMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public int PeakPagedMemorySize { get; }
    /// <summary>
    /// Gets the maximum amount of memory in the virtual memory paging file used by the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum amount of memory, in bytes, allocated in the virtual memory paging file for the associated process since it was started.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property.</exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessPeakPagedMemorySize")]
    [ComVisible(false)]
    public long PeakPagedMemorySize64 { get; }
    /// <summary>
    /// Gets the peak working set size for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum amount of physical memory that the associated process has required all at once, in bytes.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakWorkingSet64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    [MonitoringDescription("ProcessPeakWorkingSet")]
    public int PeakWorkingSet { get; }
    /// <summary>
    /// Gets the maximum amount of physical memory used by the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum amount of physical memory, in bytes, allocated for the associated process since it was started.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property.</exception><filterpriority>2</filterpriority>
    [ComVisible(false)]
    [MonitoringDescription("ProcessPeakWorkingSet")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public long PeakWorkingSet64 { get; }
    /// <summary>
    /// Gets the peak virtual memory size.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum amount of virtual memory, in bytes, that the associated process has requested.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakVirtualMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    [MonitoringDescription("ProcessPeakVirtualMemorySize")]
    public int PeakVirtualMemorySize { get; }
    /// <summary>
    /// Gets the maximum amount of virtual memory used by the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum amount of virtual memory, in bytes, allocated for the associated process since it was started.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property.</exception><filterpriority>2</filterpriority>
    [ComVisible(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessPeakVirtualMemorySize")]
    public long PeakVirtualMemorySize64 { get; }
    /// <summary>
    /// Gets or sets a value indicating whether the associated process priority should temporarily be boosted by the operating system when the main window has the focus.
    /// </summary>
    /// 
    /// <returns>
    /// true if dynamic boosting of the process priority should take place for a process when it is taken out of the wait state; otherwise, false. The default is false.
    /// </returns>
    /// <exception cref="T:System.ComponentModel.Win32Exception">Priority boost information could not be retrieved from the associated process resource. </exception><exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property.-or- The process identifier or process handle is zero. (The process has not been started.) </exception><exception cref="T:System.NotSupportedException">You are attempting to access the <see cref="P:System.Diagnostics.Process.PriorityBoostEnabled"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer. </exception><exception cref="T:System.InvalidOperationException">The process <see cref="P:System.Diagnostics.Process.Id"/> is not available.</exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessPriorityBoostEnabled")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool PriorityBoostEnabled { get; set; }
    /// <summary>
    /// Gets or sets the overall priority category for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The priority category for the associated process, from which the <see cref="P:System.Diagnostics.Process.BasePriority"/> of the process is calculated.
    /// </returns>
    /// <exception cref="T:System.ComponentModel.Win32Exception">Process priority information could not be set or retrieved from the associated process resource.-or- The process identifier or process handle is zero. (The process has not been started.) </exception><exception cref="T:System.NotSupportedException">You are attempting to access the <see cref="P:System.Diagnostics.Process.PriorityClass"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer. </exception><exception cref="T:System.InvalidOperationException">The process <see cref="P:System.Diagnostics.Process.Id"/> is not available.</exception><exception cref="T:System.PlatformNotSupportedException">You have set the <see cref="P:System.Diagnostics.Process.PriorityClass"/> to AboveNormal or BelowNormal when using Windows 98 or Windows Millennium Edition (Windows Me). These platforms do not support those values for the priority class. </exception><exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Priority class cannot be set because it does not use a valid value, as defined in the <see cref="T:System.Diagnostics.ProcessPriorityClass"/> enumeration.</exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessPriorityClass")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ProcessPriorityClass PriorityClass { get; set; }
    /// <summary>
    /// Gets the private memory size.
    /// </summary>
    /// 
    /// <returns>
    /// The number of bytes allocated by the associated process that cannot be shared with other processes.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PrivateMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessPrivateMemorySize")]
    public int PrivateMemorySize { get; }
    /// <summary>
    /// Gets the amount of private memory allocated for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The amount of memory, in bytes, allocated for the associated process that cannot be shared with other processes.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property.</exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessPrivateMemorySize")]
    [ComVisible(false)]
    public long PrivateMemorySize64 { get; }
    /// <summary>
    /// Gets the privileged processor time for this process.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.TimeSpan"/> that indicates the amount of time that the process has spent running code inside the operating system core.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><exception cref="T:System.NotSupportedException">You are attempting to access the <see cref="P:System.Diagnostics.Process.PrivilegedProcessorTime"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer. </exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessPrivilegedProcessorTime")]
    public TimeSpan PrivilegedProcessorTime { get; }
    /// <summary>
    /// Gets the name of the process.
    /// </summary>
    /// 
    /// <returns>
    /// The name that the system uses to identify the process to the user.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">The process does not have an identifier, or no process is associated with the <see cref="T:System.Diagnostics.Process"/>.-or- The associated process has exited. </exception><exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> to false to access this property on Windows 98 and Windows Me.</exception><exception cref="T:System.NotSupportedException">The process is not on this computer.</exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessProcessName")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ProcessName { get; }
    /// <summary>
    /// Gets or sets the processors on which the threads in this process can be scheduled to run.
    /// </summary>
    /// 
    /// <returns>
    /// A bitmask representing the processors that the threads in the associated process can run on. The default depends on the number of processors on the computer. The default value is 2 n -1, where n is the number of processors.
    /// </returns>
    /// <exception cref="T:System.ComponentModel.Win32Exception"><see cref="P:System.Diagnostics.Process.ProcessorAffinity"/> information could not be set or retrieved from the associated process resource.-or- The process identifier or process handle is zero. (The process has not been started.) </exception><exception cref="T:System.NotSupportedException">You are attempting to access the <see cref="P:System.Diagnostics.Process.ProcessorAffinity"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer. </exception><exception cref="T:System.InvalidOperationException">The process <see cref="P:System.Diagnostics.Process.Id"/> was not available.-or- The process has exited. </exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessProcessorAffinity")]
    public IntPtr ProcessorAffinity { get; set; }
    /// <summary>
    /// Gets a value indicating whether the user interface of the process is responding.
    /// </summary>
    /// 
    /// <returns>
    /// true if the user interface of the associated process is responding to the system; otherwise, false.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> to false to access this property on Windows 98 and Windows Me.</exception><exception cref="T:System.InvalidOperationException">There is no process associated with this <see cref="T:System.Diagnostics.Process"/> object. </exception><exception cref="T:System.NotSupportedException">You are attempting to access the <see cref="P:System.Diagnostics.Process.Responding"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer. </exception><filterpriority>1</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessResponding")]
    public bool Responding { get; }
    /// <summary>
    /// Gets the Terminal Services session identifier for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The Terminal Services session identifier for the associated process.
    /// </returns>
    /// <exception cref="T:System.NullReferenceException">There is no session associated with this process.</exception><exception cref="T:System.InvalidOperationException">There is no process associated with this session identifier.-or-The associated process is not on this machine. </exception><exception cref="T:System.PlatformNotSupportedException">The <see cref="P:System.Diagnostics.Process.SessionId"/> property is not supported on Windows 98.</exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessSessionId")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SessionId { get; }
    /// <summary>
    /// Gets or sets the properties to pass to the <see cref="M:System.Diagnostics.Process.Start"/> method of the <see cref="T:System.Diagnostics.Process"/>.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.Diagnostics.ProcessStartInfo"/> that represents the data with which to start the process. These arguments include the name of the executable file or document used to start the process.
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">The value that specifies the <see cref="P:System.Diagnostics.Process.StartInfo"/> is null. </exception><filterpriority>1</filterpriority>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [MonitoringDescription("ProcessStartInfo")]
    public ProcessStartInfo StartInfo { get; set; }
    /// <summary>
    /// Gets the time that the associated process was started.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.DateTime"/> that indicates when the process started. This only has meaning for started processes.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><exception cref="T:System.NotSupportedException">You are attempting to access the <see cref="P:System.Diagnostics.Process.StartTime"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer. </exception><exception cref="T:System.InvalidOperationException">The process has exited.</exception><exception cref="T:System.ComponentModel.Win32Exception">An error occurred in the call to the Windows function.</exception><filterpriority>1</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessStartTime")]
    public DateTime StartTime { get; }
    /// <summary>
    /// Gets or sets the object used to marshal the event handler calls that are issued as a result of a process exit event.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ComponentModel.ISynchronizeInvoke"/> used to marshal event handler calls that are issued as a result of an <see cref="E:System.Diagnostics.Process.Exited"/> event on the process.
    /// </returns>
    /// <filterpriority>2</filterpriority>
    [MonitoringDescription("ProcessSynchronizingObject")]
    [Browsable(false)]
    [DefaultValue(null)]
    public ISynchronizeInvoke SynchronizingObject { get; [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set; }
    /// <summary>
    /// Gets the set of threads that are running in the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// An array of type <see cref="T:System.Diagnostics.ProcessThread"/> representing the operating system threads currently running in the associated process.
    /// </returns>
    /// <exception cref="T:System.SystemException">The process does not have an <see cref="P:System.Diagnostics.Process.Id"/>, or no process is associated with the <see cref="T:System.Diagnostics.Process"/> instance.-or- The associated process has exited. </exception><exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> to false to access this property on Windows 98 and Windows Me.</exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessThreads")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ProcessThreadCollection Threads { get; }
    /// <summary>
    /// Gets the total processor time for this process.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.TimeSpan"/> that indicates the amount of time that the associated process has spent utilizing the CPU. This value is the sum of the <see cref="P:System.Diagnostics.Process.UserProcessorTime"/> and the <see cref="P:System.Diagnostics.Process.PrivilegedProcessorTime"/>.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><exception cref="T:System.NotSupportedException">You are attempting to access the <see cref="P:System.Diagnostics.Process.TotalProcessorTime"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer. </exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessTotalProcessorTime")]
    public TimeSpan TotalProcessorTime { get; }
    /// <summary>
    /// Gets the user processor time for this process.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.TimeSpan"/> that indicates the amount of time that the associated process has spent running code inside the application portion of the process (not inside the operating system core).
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><exception cref="T:System.NotSupportedException">You are attempting to access the <see cref="P:System.Diagnostics.Process.UserProcessorTime"/> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer. </exception><filterpriority>2</filterpriority>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessUserProcessorTime")]
    public TimeSpan UserProcessorTime { get; }
    /// <summary>
    /// Gets the size of the process's virtual memory.
    /// </summary>
    /// 
    /// <returns>
    /// The amount of virtual memory, in bytes, that the associated process has requested.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [MonitoringDescription("ProcessVirtualMemorySize")]
    [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.VirtualMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int VirtualMemorySize { get; }
    /// <summary>
    /// Gets the amount of the virtual memory allocated for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The amount of virtual memory, in bytes, allocated for the associated process.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property.</exception><filterpriority>2</filterpriority>
    [ComVisible(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [MonitoringDescription("ProcessVirtualMemorySize")]
    public long VirtualMemorySize64 { get; }
    /// <summary>
    /// Gets or sets whether the <see cref="E:System.Diagnostics.Process.Exited"/> event should be raised when the process terminates.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="E:System.Diagnostics.Process.Exited"/> event should be raised when the associated process is terminated (through either an exit or a call to <see cref="M:System.Diagnostics.Process.Kill"/>); otherwise, false. The default is false.
    /// </returns>
    /// <filterpriority>2</filterpriority>
    [DefaultValue(false)]
    [Browsable(false)]
    [MonitoringDescription("ProcessEnableRaisingEvents")]
    public bool EnableRaisingEvents { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; set; }
    /// <summary>
    /// Gets a stream used to write the input of the application.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.IO.StreamWriter"/> that can be used to write the standard input stream of the application.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.Process.StandardInput"/> stream has not been defined because <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput"/> is set to false. </exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessStandardInput")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public StreamWriter StandardInput { get; }
    /// <summary>
    /// Gets a stream used to read the output of the application.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.IO.StreamReader"/> that can be used to read the standard output stream of the application.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.Process.StandardOutput"/> stream has not been defined for redirection; ensure <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput"/> is set to true and <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> is set to false.- or - The <see cref="P:System.Diagnostics.Process.StandardOutput"/> stream has been opened for asynchronous read operations with <see cref="M:System.Diagnostics.Process.BeginOutputReadLine"/>. </exception><filterpriority>1</filterpriority>
    [MonitoringDescription("ProcessStandardOutput")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public StreamReader StandardOutput { get; }
    /// <summary>
    /// Gets a stream used to read the error output of the application.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.IO.StreamReader"/> that can be used to read the standard error stream of the application.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.Process.StandardError"/> stream has not been defined for redirection; ensure <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError"/> is set to true and <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"/> is set to false.- or - The <see cref="P:System.Diagnostics.Process.StandardError"/> stream has been opened for asynchronous read operations with <see cref="M:System.Diagnostics.Process.BeginErrorReadLine"/>. </exception><filterpriority>1</filterpriority>
    [Browsable(false)]
    [MonitoringDescription("ProcessStandardError")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public StreamReader StandardError { get; }
    /// <summary>
    /// Gets the associated process's physical memory usage.
    /// </summary>
    /// 
    /// <returns>
    /// The total amount of physical memory the associated process is using, in bytes.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property. </exception><filterpriority>2</filterpriority>
    [MonitoringDescription("ProcessWorkingSet")]
    [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.WorkingSet64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int WorkingSet { get; }
    /// <summary>
    /// Gets the amount of physical memory allocated for the associated process.
    /// </summary>
    /// 
    /// <returns>
    /// The amount of physical memory, in bytes, allocated for the associated process.
    /// </returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me), which does not support this property.</exception><filterpriority>2</filterpriority>
    [MonitoringDescription("ProcessWorkingSet")]
    [ComVisible(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public long WorkingSet64 { get; }
    /// <summary>
    /// Occurs when an application writes to its redirected <see cref="P:System.Diagnostics.Process.StandardOutput"/> stream.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    [Browsable(true)]
    [MonitoringDescription("ProcessAssociated")]
    public event DataReceivedEventHandler OutputDataReceived;
    /// <summary>
    /// Occurs when an application writes to its redirected <see cref="P:System.Diagnostics.Process.StandardError"/> stream.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    [Browsable(true)]
    [MonitoringDescription("ProcessAssociated")]
    public event DataReceivedEventHandler ErrorDataReceived;
    /// <summary>
    /// Occurs when a process exits.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    [MonitoringDescription("ProcessExited")]
    [Category("Behavior")]
    public event EventHandler Exited;
  }
}
