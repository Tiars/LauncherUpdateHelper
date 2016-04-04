Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Collections
Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Threading
Imports Microsoft.VisualBasic.FileIO

Public Class UpdateNotification
    Private Sub UpdateNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateNotification_Running(sender As Object, e As EventArgs) Handles MyBase.Shown

        ' LaunchPad.exe
        Me.Refresh()

        Try
            If File.Exists("LaunchPadOld.exe") Then
                My.Computer.FileSystem.DeleteFile("LaunchPadOld.exe",
                    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                    Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
            End If

        Catch ex As Exception
            ' Do Nothing
        End Try

        Try
            If File.Exists("LaunchPadNew.exe") Then
                Try
                    My.Computer.FileSystem.MoveFile("LaunchPad.exe", "LaunchPadOld.exe")
                Catch ex As Exception
                    MsgBox("Could not Backup LaunchPad.exe")
                End Try

                Try
                    My.Computer.FileSystem.MoveFile("LaunchPadNew.exe", "LaunchPad.exe")
                Catch ex As Exception
                    If File.Exists("LaunchPadOld.exe") Then
                        My.Computer.FileSystem.MoveFile("LaunchPadOld.exe", "LaunchPad.exe")
                    End If
                    MsgBox("Could not Update LaunchPad.exe")
                End Try

            End If

        Catch ex As Exception
            ' Do Nothing
        End Try

        Try
            If File.Exists("LaunchPadOld.exe") Then
                My.Computer.FileSystem.DeleteFile("LaunchPadOld.exe",
                    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                    Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
            End If

        Catch ex As Exception
            MsgBox("Could not delete the backup of LaunchPad.exe")
        End Try

        Thread.Sleep(2000)

        ' New ProcessStartInfo created
        Dim calc As New ProcessStartInfo
        calc.FileName = "LaunchPad.exe"

        ' Use a hidden window
        calc.WindowStyle = ProcessWindowStyle.Hidden
        Try
            Process.Start(calc)
        Catch ex As Exception
            ' Launch was not successful so report the error and suggest a solution
        End Try

        ' Thread.Sleep(2000)
        Application.Exit()

    End Sub
End Class
