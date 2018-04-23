Imports DevExpress.Xpf.Printing

Class MainWindow

    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Dim report As New XtraReport1()
        PrintHelper.ShowPrintPreview(Me, report)
    End Sub
End Class
