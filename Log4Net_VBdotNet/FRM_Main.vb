Public Class FRM_Main
    Private Sub FRM_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'start the logger
        Logger.Configure()

        'log system startup text
        Logger.Info("System Startup")

    End Sub

    Private Sub BTN_Logger_Click(sender As Object, e As EventArgs) Handles BTN_Logger.Click
        Logger.Info("HELLO WORLD")
    End Sub

    Private Sub BTN_LogFromTXTBox_Click(sender As Object, e As EventArgs) Handles BTN_LogFromTXTBox.Click
        Logger.Info(TXT_Logger.Text)
    End Sub

    Private Sub BTN_LogINFO_Click(sender As Object, e As EventArgs) Handles BTN_LogINFO.Click
        Logger.Info("THIS IS A INFORMATION LOG")
    End Sub

    Private Sub BTN_LogWARNING_Click(sender As Object, e As EventArgs) Handles BTN_LogWARNING.Click
        Logger.Warn("THIS IS A WARNING LOG")
    End Sub

    Private Sub BTN_LogERR_Click(sender As Object, e As EventArgs) Handles BTN_LogERR.Click
        Logger.Error("THIS IS A ERROR LOG")
    End Sub

    Private Sub BTN_LogDEBUG_Click(sender As Object, e As EventArgs) Handles BTN_LogDEBUG.Click
        Logger.Debug("THIS IS A DEBUG LOG")
    End Sub

    Private Sub TXT_Logger_TextChanged(sender As Object, e As EventArgs) Handles TXT_Logger.TextChanged

        If TXT_Logger.Text.Trim() = "" Then 'IF TEXTBOX IS EMPTY, Disable BTN_LogFromTXTBox
            BTN_LogFromTXTBox.Enabled = False
        Else 'ELSE ENABLE BTN_LogFromTXTBox
            BTN_LogFromTXTBox.Enabled = True
        End If

    End Sub

End Class
