using DevExpress.Utils;
using DevExpress.XtraBars;
using System;
using System.Linq;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        Random r = new Random();

        public Form1() {
            InitializeComponent();
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e) {
            var editItem = sender as BarEditItem;
            var value = Convert.ToInt32(editItem.EditValue);
            PointFloat[] points = new PointFloat[value];

            for (int i = 0; i < value; i++) {
                points[i] = new PointFloat() { X = Convert.ToSingle(r.NextDouble()), Y = r.Next(0, 2) == 0 ? 0 : 1 };
            }

            diagramShape1.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(points);
        }
    }
}
