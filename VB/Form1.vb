Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.UI.Sql
Imports DevExpress.XtraEditors
Imports System

Namespace StandaloneQueryBuilderSample

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            sqlDataSource1.Queries.Clear()
        End Sub

        Private Sub runQBButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If sqlDataSource1.Queries.Count = 0 Then
                sqlDataSource1.AddQueryWithQueryBuilder(New QueryBuilderEditQueryContext(), New QueryBuilderRunnerDelegate(AddressOf CreateQueryBuilderRunner))
            Else
                sqlDataSource1.Queries(0).EditQueryWithQueryBuilder(New QueryBuilderEditQueryContext(), New QueryBuilderRunnerDelegate(AddressOf CreateQueryBuilderRunner))
            End If
        End Sub

        Private Function CreateQueryBuilderRunner(ByVal dbSchema As DBSchema, ByVal sqlDataConnection As SqlDataConnection, ByVal context As QueryBuilderEditQueryContext) As QueryBuilderRunner
            Return If(cbHidePreview.Checked, New NoPreviewQueryBuilderRunner(dbSchema, sqlDataConnection, context), New QueryBuilderRunner(dbSchema, sqlDataConnection, context))
        End Function

        Private Sub fillButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.DataSource = Nothing
            gridControl1.DataMember = Nothing
            gridView1.Columns.Clear()
            sqlDataSource1.Fill()
            gridControl1.DataSource = sqlDataSource1
            gridControl1.DataMember = sqlDataSource1.Queries(0).Name
        End Sub
    End Class
End Namespace
