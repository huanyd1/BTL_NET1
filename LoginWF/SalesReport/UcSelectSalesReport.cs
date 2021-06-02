using DevExpress.XtraEditors;
using LiveCharts;
using LiveCharts.Wpf;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWF.SalesReport
{
    public partial class UcSelectSalesReport : DevExpress.XtraEditors.XtraUserControl
    {
        public UcSelectSalesReport()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadDoanhThu();
            LoadChart();
        }

        private void LoadDoanhThu()
        {
            DoanhThuDAO dao = new DoanhThuDAO();
            gDoanhThu.DataSource = dao.GetAll();
        }

        void LoadChart()
        {
            DoanhThuDAO dao = new DoanhThuDAO();

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Tháng 1",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(1)},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 2",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(2)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 3",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(3)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 4",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(4)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 5",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(5)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 6",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(6)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 7",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(7)},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 8",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(8)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 9",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(9)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 10",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(10)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 11",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(11)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Tháng 12",
                    Values = new ChartValues<double> {dao.GetSoTienByIDThang(12)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void gDoanhThu_Click(object sender, EventArgs e)
        {
            string path = string.Format("Doanhthu.xlsx");

            gDoanhThu.ExportToXlsx(path);
            Process.Start(path);
        }
    }
}
