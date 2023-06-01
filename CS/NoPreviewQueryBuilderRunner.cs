using DevExpress.Data;
using DevExpress.DataAccess.Native.Sql.QueryBuilder;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.UI.Native.Sql.QueryBuilder;
using DevExpress.DataAccess.UI.Sql;
using DevExpress.DataAccess.UI.Wizard.Services;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.LookAndFeel;
using System;
using System.Windows.Forms;

namespace StandaloneQueryBuilderSample {
    public class NoPreviewQueryBuilderRunner : QueryBuilderRunner {
        class NoPreviewQueryBuilderView : QueryBuilderView {
            public NoPreviewQueryBuilderView(IQueryBuilderViewModel viewModel, IWin32Window owner, 
                UserLookAndFeel lookAndFeel, IParameterService parameterService, IServiceProvider propertyGridServices, 
                bool noCustomSql, bool light, IDisplayNameProvider displayNameProvider, bool noDiagram, bool legacyExpressionEditor, 
                IExceptionHandler loaderExceptionHandler, IRepositoryItemsProvider repositoryItemsProvider)
                : base(viewModel, owner, lookAndFeel, parameterService, propertyGridServices, noCustomSql, light, displayNameProvider, 
                noDiagram, legacyExpressionEditor, loaderExceptionHandler, repositoryItemsProvider) {
                this.layoutItemFilterButton.OptionsTableLayoutItem.ColumnIndex = 0;
                this.layoutItemParametersButton.OptionsTableLayoutItem.ColumnIndex = 1;
                this.layoutItemPreviewButton.OptionsTableLayoutItem.ColumnIndex = 2;
                this.layoutControl1.HideItem(this.layoutItemPreviewButton);
            }
        }

        public NoPreviewQueryBuilderRunner(DBSchema dbSchema, SqlDataConnection connection, QueryBuilderEditQueryContext context)
            : base(dbSchema, connection, context) {
        }
    }
}
