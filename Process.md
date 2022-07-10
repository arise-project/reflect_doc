Constructors: 
	.ctor
Methods: 
	Start
	Start
	ToString
	WaitForExit
	WaitForExit
	BeginOutputReadLine
	BeginErrorReadLine
	CancelOutputRead
	CancelErrorRead
	EnterDebugMode
	LeaveDebugMode
	Start
	Start
	Kill
	get_MainModule
	get_MainWindowHandle
	get_MainWindowTitle
	get_Responding
	GetProcessesByName
	get_PrivilegedProcessorTime
	get_TotalProcessorTime
	get_UserProcessorTime
	Kill
	add_OutputDataReceived
	remove_OutputDataReceived
	add_ErrorDataReceived
	remove_ErrorDataReceived
	get_SafeHandle
	get_Handle
	get_BasePriority
	get_ExitCode
	get_HasExited
	get_StartTime
	get_ExitTime
	get_Id
	get_MachineName
	get_MaxWorkingSet
	set_MaxWorkingSet
	get_MinWorkingSet
	set_MinWorkingSet
	get_Modules
	get_NonpagedSystemMemorySize64
	get_NonpagedSystemMemorySize
	get_PagedMemorySize64
	get_PagedMemorySize
	get_PagedSystemMemorySize64
	get_PagedSystemMemorySize
	get_PeakPagedMemorySize64
	get_PeakPagedMemorySize
	get_PeakWorkingSet64
	get_PeakWorkingSet
	get_PeakVirtualMemorySize64
	get_PeakVirtualMemorySize
	get_PriorityBoostEnabled
	set_PriorityBoostEnabled
	get_PriorityClass
	set_PriorityClass
	get_PrivateMemorySize64
	get_PrivateMemorySize
	get_ProcessName
	get_ProcessorAffinity
	set_ProcessorAffinity
	get_SessionId
	get_StartInfo
	set_StartInfo
	get_Threads
	get_HandleCount
	get_VirtualMemorySize64
	get_VirtualMemorySize
	get_EnableRaisingEvents
	set_EnableRaisingEvents
	get_StandardInput
	get_StandardOutput
	get_StandardError
	get_WorkingSet64
	get_WorkingSet
	add_Exited
	remove_Exited
	CloseMainWindow
	WaitForInputIdle
	WaitForInputIdle
	get_SynchronizingObject
	set_SynchronizingObject
	Close
	GetProcessById
	GetProcessById
	GetProcessesByName
	GetProcesses
	GetProcesses
	GetCurrentProcess
	Refresh
	Start
	Start
	add_Disposed
	remove_Disposed
	get_Site
	set_Site
	Dispose
	get_Container
	GetLifetimeService
	InitializeLifetimeService
	GetType
	Equals
	GetHashCode
Properties: 
	SafeHandle
	Handle
	BasePriority
	ExitCode
	HasExited
	StartTime
	ExitTime
	Id
	MachineName
	MaxWorkingSet
	MinWorkingSet
	Modules
	NonpagedSystemMemorySize64
	NonpagedSystemMemorySize
	PagedMemorySize64
	PagedMemorySize
	PagedSystemMemorySize64
	PagedSystemMemorySize
	PeakPagedMemorySize64
	PeakPagedMemorySize
	PeakWorkingSet64
	PeakWorkingSet
	PeakVirtualMemorySize64
	PeakVirtualMemorySize
	PriorityBoostEnabled
	PriorityClass
	PrivateMemorySize64
	PrivateMemorySize
	ProcessName
	ProcessorAffinity
	SessionId
	StartInfo
	Threads
	HandleCount
	VirtualMemorySize64
	VirtualMemorySize
	EnableRaisingEvents
	StandardInput
	StandardOutput
	StandardError
	WorkingSet64
	WorkingSet
	SynchronizingObject
	MainModule
	MainWindowHandle
	MainWindowTitle
	Responding
	PrivilegedProcessorTime
	TotalProcessorTime
	UserProcessorTime
	Site
	Container
Members type: 

	Start, name: Method
	System.Diagnostics.Process Start(System.String, System.String)

	Start, name: Method
	System.Diagnostics.Process Start(System.Diagnostics.ProcessStartInfo)

	ToString, name: Method
	System.String ToString()

	WaitForExit, name: Method
	Void WaitForExit()

	WaitForExit, name: Method
	Boolean WaitForExit(Int32)

	BeginOutputReadLine, name: Method
	Void BeginOutputReadLine()

	BeginErrorReadLine, name: Method
	Void BeginErrorReadLine()

	CancelOutputRead, name: Method
	Void CancelOutputRead()

	CancelErrorRead, name: Method
	Void CancelErrorRead()

	EnterDebugMode, name: Method
	Void EnterDebugMode()

	LeaveDebugMode, name: Method
	Void LeaveDebugMode()

	Start, name: Method
	System.Diagnostics.Process Start(System.String, System.String, System.Security.SecureString, System.String)

	Start, name: Method
	System.Diagnostics.Process Start(System.String, System.String, System.String, System.Security.SecureString, System.String)

	Kill, name: Method
	Void Kill()

	get_MainModule, name: Method
	System.Diagnostics.ProcessModule get_MainModule()

	get_MainWindowHandle, name: Method
	IntPtr get_MainWindowHandle()

	get_MainWindowTitle, name: Method
	System.String get_MainWindowTitle()

	get_Responding, name: Method
	Boolean get_Responding()

	GetProcessesByName, name: Method
	System.Diagnostics.Process[] GetProcessesByName(System.String, System.String)

	get_PrivilegedProcessorTime, name: Method
	System.TimeSpan get_PrivilegedProcessorTime()

	get_TotalProcessorTime, name: Method
	System.TimeSpan get_TotalProcessorTime()

	get_UserProcessorTime, name: Method
	System.TimeSpan get_UserProcessorTime()

	Kill, name: Method
	Void Kill(Boolean)

	add_OutputDataReceived, name: Method
	Void add_OutputDataReceived(System.Diagnostics.DataReceivedEventHandler)

	remove_OutputDataReceived, name: Method
	Void remove_OutputDataReceived(System.Diagnostics.DataReceivedEventHandler)

	add_ErrorDataReceived, name: Method
	Void add_ErrorDataReceived(System.Diagnostics.DataReceivedEventHandler)

	remove_ErrorDataReceived, name: Method
	Void remove_ErrorDataReceived(System.Diagnostics.DataReceivedEventHandler)

	get_SafeHandle, name: Method
	Microsoft.Win32.SafeHandles.SafeProcessHandle get_SafeHandle()

	get_Handle, name: Method
	IntPtr get_Handle()

	get_BasePriority, name: Method
	Int32 get_BasePriority()

	get_ExitCode, name: Method
	Int32 get_ExitCode()

	get_HasExited, name: Method
	Boolean get_HasExited()

	get_StartTime, name: Method
	System.DateTime get_StartTime()

	get_ExitTime, name: Method
	System.DateTime get_ExitTime()

	get_Id, name: Method
	Int32 get_Id()

	get_MachineName, name: Method
	System.String get_MachineName()

	get_MaxWorkingSet, name: Method
	IntPtr get_MaxWorkingSet()

	set_MaxWorkingSet, name: Method
	Void set_MaxWorkingSet(IntPtr)

	get_MinWorkingSet, name: Method
	IntPtr get_MinWorkingSet()

	set_MinWorkingSet, name: Method
	Void set_MinWorkingSet(IntPtr)

	get_Modules, name: Method
	System.Diagnostics.ProcessModuleCollection get_Modules()

	get_NonpagedSystemMemorySize64, name: Method
	Int64 get_NonpagedSystemMemorySize64()

	get_NonpagedSystemMemorySize, name: Method
	Int32 get_NonpagedSystemMemorySize()

	get_PagedMemorySize64, name: Method
	Int64 get_PagedMemorySize64()

	get_PagedMemorySize, name: Method
	Int32 get_PagedMemorySize()

	get_PagedSystemMemorySize64, name: Method
	Int64 get_PagedSystemMemorySize64()

	get_PagedSystemMemorySize, name: Method
	Int32 get_PagedSystemMemorySize()

	get_PeakPagedMemorySize64, name: Method
	Int64 get_PeakPagedMemorySize64()

	get_PeakPagedMemorySize, name: Method
	Int32 get_PeakPagedMemorySize()

	get_PeakWorkingSet64, name: Method
	Int64 get_PeakWorkingSet64()

	get_PeakWorkingSet, name: Method
	Int32 get_PeakWorkingSet()

	get_PeakVirtualMemorySize64, name: Method
	Int64 get_PeakVirtualMemorySize64()

	get_PeakVirtualMemorySize, name: Method
	Int32 get_PeakVirtualMemorySize()

	get_PriorityBoostEnabled, name: Method
	Boolean get_PriorityBoostEnabled()

	set_PriorityBoostEnabled, name: Method
	Void set_PriorityBoostEnabled(Boolean)

	get_PriorityClass, name: Method
	System.Diagnostics.ProcessPriorityClass get_PriorityClass()

	set_PriorityClass, name: Method
	Void set_PriorityClass(System.Diagnostics.ProcessPriorityClass)

	get_PrivateMemorySize64, name: Method
	Int64 get_PrivateMemorySize64()

	get_PrivateMemorySize, name: Method
	Int32 get_PrivateMemorySize()

	get_ProcessName, name: Method
	System.String get_ProcessName()

	get_ProcessorAffinity, name: Method
	IntPtr get_ProcessorAffinity()

	set_ProcessorAffinity, name: Method
	Void set_ProcessorAffinity(IntPtr)

	get_SessionId, name: Method
	Int32 get_SessionId()

	get_StartInfo, name: Method
	System.Diagnostics.ProcessStartInfo get_StartInfo()

	set_StartInfo, name: Method
	Void set_StartInfo(System.Diagnostics.ProcessStartInfo)

	get_Threads, name: Method
	System.Diagnostics.ProcessThreadCollection get_Threads()

	get_HandleCount, name: Method
	Int32 get_HandleCount()

	get_VirtualMemorySize64, name: Method
	Int64 get_VirtualMemorySize64()

	get_VirtualMemorySize, name: Method
	Int32 get_VirtualMemorySize()

	get_EnableRaisingEvents, name: Method
	Boolean get_EnableRaisingEvents()

	set_EnableRaisingEvents, name: Method
	Void set_EnableRaisingEvents(Boolean)

	get_StandardInput, name: Method
	System.IO.StreamWriter get_StandardInput()

	get_StandardOutput, name: Method
	System.IO.StreamReader get_StandardOutput()

	get_StandardError, name: Method
	System.IO.StreamReader get_StandardError()

	get_WorkingSet64, name: Method
	Int64 get_WorkingSet64()

	get_WorkingSet, name: Method
	Int32 get_WorkingSet()

	add_Exited, name: Method
	Void add_Exited(System.EventHandler)

	remove_Exited, name: Method
	Void remove_Exited(System.EventHandler)

	CloseMainWindow, name: Method
	Boolean CloseMainWindow()

	WaitForInputIdle, name: Method
	Boolean WaitForInputIdle()

	WaitForInputIdle, name: Method
	Boolean WaitForInputIdle(Int32)

	get_SynchronizingObject, name: Method
	System.ComponentModel.ISynchronizeInvoke get_SynchronizingObject()

	set_SynchronizingObject, name: Method
	Void set_SynchronizingObject(System.ComponentModel.ISynchronizeInvoke)

	Close, name: Method
	Void Close()

	GetProcessById, name: Method
	System.Diagnostics.Process GetProcessById(Int32, System.String)

	GetProcessById, name: Method
	System.Diagnostics.Process GetProcessById(Int32)

	GetProcessesByName, name: Method
	System.Diagnostics.Process[] GetProcessesByName(System.String)

	GetProcesses, name: Method
	System.Diagnostics.Process[] GetProcesses()

	GetProcesses, name: Method
	System.Diagnostics.Process[] GetProcesses(System.String)

	GetCurrentProcess, name: Method
	System.Diagnostics.Process GetCurrentProcess()

	Refresh, name: Method
	Void Refresh()

	Start, name: Method
	Boolean Start()

	Start, name: Method
	System.Diagnostics.Process Start(System.String)

	add_Disposed, name: Method
	Void add_Disposed(System.EventHandler)

	remove_Disposed, name: Method
	Void remove_Disposed(System.EventHandler)

	get_Site, name: Method
	System.ComponentModel.ISite get_Site()

	set_Site, name: Method
	Void set_Site(System.ComponentModel.ISite)

	Dispose, name: Method
	Void Dispose()

	get_Container, name: Method
	System.ComponentModel.IContainer get_Container()

	GetLifetimeService, name: Method
	System.Object GetLifetimeService()

	InitializeLifetimeService, name: Method
	System.Object InitializeLifetimeService()

	GetType, name: Method
	System.Type GetType()

	Equals, name: Method
	Boolean Equals(System.Object)

	GetHashCode, name: Method
	Int32 GetHashCode()

	.ctor, name: Constructor
	Void .ctor()

	SafeHandle, name: Property
	Microsoft.Win32.SafeHandles.SafeProcessHandle SafeHandle

	Handle, name: Property
	IntPtr Handle

	BasePriority, name: Property
	Int32 BasePriority

	ExitCode, name: Property
	Int32 ExitCode

	HasExited, name: Property
	Boolean HasExited

	StartTime, name: Property
	System.DateTime StartTime

	ExitTime, name: Property
	System.DateTime ExitTime

	Id, name: Property
	Int32 Id

	MachineName, name: Property
	System.String MachineName

	MaxWorkingSet, name: Property
	IntPtr MaxWorkingSet

	MinWorkingSet, name: Property
	IntPtr MinWorkingSet

	Modules, name: Property
	System.Diagnostics.ProcessModuleCollection Modules

	NonpagedSystemMemorySize64, name: Property
	Int64 NonpagedSystemMemorySize64

	NonpagedSystemMemorySize, name: Property
	Int32 NonpagedSystemMemorySize

	PagedMemorySize64, name: Property
	Int64 PagedMemorySize64

	PagedMemorySize, name: Property
	Int32 PagedMemorySize

	PagedSystemMemorySize64, name: Property
	Int64 PagedSystemMemorySize64

	PagedSystemMemorySize, name: Property
	Int32 PagedSystemMemorySize

	PeakPagedMemorySize64, name: Property
	Int64 PeakPagedMemorySize64

	PeakPagedMemorySize, name: Property
	Int32 PeakPagedMemorySize

	PeakWorkingSet64, name: Property
	Int64 PeakWorkingSet64

	PeakWorkingSet, name: Property
	Int32 PeakWorkingSet

	PeakVirtualMemorySize64, name: Property
	Int64 PeakVirtualMemorySize64

	PeakVirtualMemorySize, name: Property
	Int32 PeakVirtualMemorySize

	PriorityBoostEnabled, name: Property
	Boolean PriorityBoostEnabled

	PriorityClass, name: Property
	System.Diagnostics.ProcessPriorityClass PriorityClass

	PrivateMemorySize64, name: Property
	Int64 PrivateMemorySize64

	PrivateMemorySize, name: Property
	Int32 PrivateMemorySize

	ProcessName, name: Property
	System.String ProcessName

	ProcessorAffinity, name: Property
	IntPtr ProcessorAffinity

	SessionId, name: Property
	Int32 SessionId

	StartInfo, name: Property
	System.Diagnostics.ProcessStartInfo StartInfo

	Threads, name: Property
	System.Diagnostics.ProcessThreadCollection Threads

	HandleCount, name: Property
	Int32 HandleCount

	VirtualMemorySize64, name: Property
	Int64 VirtualMemorySize64

	VirtualMemorySize, name: Property
	Int32 VirtualMemorySize

	EnableRaisingEvents, name: Property
	Boolean EnableRaisingEvents

	StandardInput, name: Property
	System.IO.StreamWriter StandardInput

	StandardOutput, name: Property
	System.IO.StreamReader StandardOutput

	StandardError, name: Property
	System.IO.StreamReader StandardError

	WorkingSet64, name: Property
	Int64 WorkingSet64

	WorkingSet, name: Property
	Int32 WorkingSet

	SynchronizingObject, name: Property
	System.ComponentModel.ISynchronizeInvoke SynchronizingObject

	MainModule, name: Property
	System.Diagnostics.ProcessModule MainModule

	MainWindowHandle, name: Property
	IntPtr MainWindowHandle

	MainWindowTitle, name: Property
	System.String MainWindowTitle

	Responding, name: Property
	Boolean Responding

	PrivilegedProcessorTime, name: Property
	System.TimeSpan PrivilegedProcessorTime

	TotalProcessorTime, name: Property
	System.TimeSpan TotalProcessorTime

	UserProcessorTime, name: Property
	System.TimeSpan UserProcessorTime

	Site, name: Property
	System.ComponentModel.ISite Site

	Container, name: Property
	System.ComponentModel.IContainer Container

	OutputDataReceived, name: Event
	System.Diagnostics.DataReceivedEventHandler OutputDataReceived

	ErrorDataReceived, name: Event
	System.Diagnostics.DataReceivedEventHandler ErrorDataReceived

	Exited, name: Event
	System.EventHandler Exited

	Disposed, name: Event
	System.EventHandler Disposed
