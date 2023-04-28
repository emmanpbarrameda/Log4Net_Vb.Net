Imports log4net
Imports log4net.Config

Public Class Logger

    Private Shared ReadOnly log As ILog = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
    Shared logConfigFile As String = System.IO.Path.Combine(Application.StartupPath, "log4net.config")

    Public Shared Sub Configure()

        ' Specify the path to the log4net configuration file
        XmlConfigurator.Configure(New System.IO.FileInfo(logConfigFile))

        ' Log a test message
        log.Info("Log4Net configured with file: " & logConfigFile)

    End Sub

    Public Shared Sub Debug(ByVal message As String)
        log.Debug(message)
    End Sub

    Public Shared Sub Info(ByVal message As String)
        log.Info(message)
    End Sub

    Public Shared Sub Warn(ByVal message As String)
        log.Warn(message)
    End Sub

    Public Shared Sub [Error](ByVal message As String)
        log.[Error](message)
    End Sub

    Public Shared Sub [Error](ByVal ex As Exception)
        log.[Error](ex)
    End Sub

    Public Shared Sub Fatal(ByVal message As String)
        log.Fatal(message)
    End Sub

    Public Shared Sub Fatal(ByVal ex As Exception)
        log.Fatal(ex)
    End Sub

End Class
