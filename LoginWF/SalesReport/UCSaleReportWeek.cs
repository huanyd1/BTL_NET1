using DevExpress.XtraEditors;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWF.SalesReport
{
    public partial class UCSaleReportWeek : DevExpress.XtraEditors.XtraUserControl
    {
        public UCSaleReportWeek()
        {
            InitializeComponent();

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Tuần đầu",
                    Values = new ChartValues<double> {400, 600, 500, 200}
                },
                new LineSeries
                {
                    Title = "Tuần 2",
                    Values = new ChartValues<double> {600, 700, 300, 400},
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Tuần 3",
                    Values = new ChartValues<double> {500, 200, 800, 300},
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Title = "Tuần 4",
                    Values = new ChartValues<double> {300, 200, 600, 300},
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Doanh thu",
                Labels = new[] { "Lượt đặt phòng", "Số khách", "Thuê xe", "Ăn uống" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Số tiền",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;
        }
    }
}
