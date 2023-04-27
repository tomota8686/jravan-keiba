Public Class FrmMain
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Private Sub menuConfJV_Click(sender As Object, e As EventArgs) Handles menuConfJV.Click
        Try
            'リターンコード
            Dim lReturnCode As Long
            '設定画面表示
            lReturnCode = AxJVLink1.JVSetUIProperties
            If lReturnCode <> 0 Then
                MsgBox("JVSetUIPropertiesエラー コード：" & lReturnCode & "：", MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
