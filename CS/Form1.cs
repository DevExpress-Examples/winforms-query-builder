using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.UI.Sql;
using DevExpress.XtraEditors;
using System;

namespace StandaloneQueryBuilderSample {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            sqlDataSource1.Queries.Clear();

        }

        void runQBButton_Click(object sender, EventArgs e) {
            if(sqlDataSource1.Queries.Count == 0) {
                sqlDataSource1.AddQueryWithQueryBuilder(new QueryBuilderEditQueryContext(), CreateQueryBuilderRunner);
            }
            else
                sqlDataSource1.Queries[0].EditQueryWithQueryBuilder(new QueryBuilderEditQueryContext(), CreateQueryBuilderRunner);
        }

        QueryBuilderRunner CreateQueryBuilderRunner(DBSchema dbSchema, SqlDataConnection sqlDataConnection, QueryBuilderEditQueryContext context) {
            return cbHidePreview.Checked ? new NoPreviewQueryBuilderRunner(dbSchema, sqlDataConnection, context) : new QueryBuilderRunner(dbSchema, sqlDataConnection, context);
        }

        void fillButton_Click(object sender, EventArgs e) {
            gridControl1.DataSource = null;
            gridControl1.DataMember = null;
            gridView1.Columns.Clear();

            sqlDataSource1.Fill();
            
            gridControl1.DataSource = sqlDataSource1;
            gridControl1.DataMember = sqlDataSource1.Queries[0].Name;
        }
    }
}
