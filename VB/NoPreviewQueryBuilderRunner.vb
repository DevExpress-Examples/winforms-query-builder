Imports DevExpress.Data
Imports DevExpress.DataAccess.Native.Sql.QueryBuilder
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.UI.Native.Sql.QueryBuilder
Imports DevExpress.DataAccess.UI.Sql
Imports DevExpress.DataAccess.UI.Wizard.Services
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.LookAndFeel
Imports System
Imports System.Windows.Forms

Namespace StandaloneQueryBuilderSample
    Public Class NoPreviewQueryBuilderRunner
        Inherits QueryBuilderRunner

        Private Class NoPreviewQueryBuilderView
            Inherits QueryBuilderView

            Public Sub New(ByVal viewModel As IQueryBuilderViewModel, ByVal owner As IWin32Window, ByVal lookAndFeel As UserLookAndFeel, ByVal parameterService As IParameterService, ByVal propertyGridServices As IServiceProvider, ByVal noCustomSql As Boolean, ByVal light As Boolean, ByVal displayNameProvider As IDisplayNameProvider, ByVal noDiagram As Boolean, ByVal legacyExpressionEditor As Boolean, ByVal loaderExceptionHandler As IExceptionHandler, ByVal repositoryItemsProvider As IRepositoryItemsProvider)
                MyBase.New(viewModel, owner, lookAndFeel, parameterService, propertyGridServices, noCustomSql, light, displayNameProvider, noDiagram, legacyExpressionEditor, loaderExceptionHandler, repositoryItemsProvider)
                Me.layoutItemFilterButton.OptionsTableLayoutItem.ColumnIndex = 0
                Me.layoutItemParametersButton.OptionsTableLayoutItem.ColumnIndex = 1
                Me.layoutItemPreviewButton.OptionsTableLayoutItem.ColumnIndex = 2
                Me.layoutControl1.HideItem(Me.layoutItemPreviewButton)
            End Sub
        End Class

        Public Sub New(ByVal dbSchema As DBSchema, ByVal connection As SqlDataConnection, ByVal context As QueryBuilderEditQueryContext)
            MyBase.New(dbSchema, connection, context)
        End Sub

        Protected Overrides Function CreateView(ByVal queryBuilderViewModel As QueryBuilderViewModel) As IQueryBuilderView
            Return New NoPreviewQueryBuilderView(queryBuilderViewModel, Owner, LookAndFeel, ParameterService, PropertyGridServices, NoCustomSql, Light, DisplayNameProvider, NoDiagramControl, LegacyExpressionEditor, LoaderExceptionHandler, RepositoryItemsProvider)
        End Function
    End Class
End Namespace
