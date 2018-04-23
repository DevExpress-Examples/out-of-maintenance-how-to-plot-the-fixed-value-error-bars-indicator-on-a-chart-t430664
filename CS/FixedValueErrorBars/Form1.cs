using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;
namespace ErrorBarsWin {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void FormOnLoad(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            #region #FixedValueErrorBars
            PointSeriesView view = (PointSeriesView)chartControl.Series[0].View;
            view.Indicators.Add(new FixedValueErrorBars {
                NegativeError = 7,
                PositiveError = 10,
                Direction = ErrorBarDirection.Both,
                ShowInLegend = true,
                Name = "Unit Price Range"
            });
            #endregion #FixedValueErrorBars
        }
    }
}
