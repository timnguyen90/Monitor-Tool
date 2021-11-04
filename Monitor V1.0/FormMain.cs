using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Monitor_V1._0
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public string Filepad;
        private int Count = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //open file
                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = "Chọn file cần mở !";
                theDialog.Filter = "TXT files|*.txt";
                theDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    Filepad = theDialog.FileName.ToString();
                }
                UpdateChart(1);
                chart1.Series["Series1"].IsValueShownAsLabel = false;
            }
            catch (Exception ex)
            {
               DialogResult dr = MessageBox.Show(ex.Message.ToString(), "Lỗi Mở File");
            }
            
        }
        /// <summary>
        /// Update chart
        /// </summary>
        private void UpdateChart(int colValue1)
        {
            try
            {
                #region Xu ly du lieu cho bieu do
                FileStream fs = new FileStream();
                fs.FileName = Filepad;
                //Xu li bieu do
                //Tim max cho truc Y
                DataTable ChartData = fs.ReturnAllData();
                //chart1.DataSource = ChartData;
                //ChartData.Rows[0][colValue1] gia tri dong 0 cot colValue1
                double max = double.Parse(ChartData.Rows[0][colValue1].ToString());
                for (int i = 0; i < ChartData.Rows.Count; i++)
                {
                    if (max < double.Parse(ChartData.Rows[i][colValue1].ToString()))
                    {
                        max = double.Parse(ChartData.Rows[i][colValue1].ToString());
                    }
                }
                chart1.ChartAreas[0].AxisY.Maximum = max;
                chart1.Series.Clear();
                Series s = new Series();
                for (int i = 0; i < ChartData.Rows.Count; i++)
                {
                    DataPoint p = new DataPoint();
                    p.XValue = i;
                    p.SetValueY(double.Parse(ChartData.Rows[i][colValue1].ToString()));
                    //Add gia tri ngay thang vao cot X cua bieu do
                    p.AxisLabel = ChartData.Rows[i][0].ToString();
                    s.Points.Add(p);
                }
                chart1.Series.Add(s);
                #endregion
                #region Dinh dang hien thi cho bieu do
                //Dinh dang lable gia tri nam phi tren top
                chart1.Series["Series1"].IsValueShownAsLabel = false;
                chart1.Series["Series1"]["LabelStyle"] = "Top";
                //Kieu cua bieu do
                chart1.Series["Series1"].ChartType = SeriesChartType.Line;
                //Kieu diem gia tri cua bieu do
                chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
                //Dinh dang hien thi cot OX cho bieu do
                chart1.ChartAreas["ChartArea1"].AxisX.IsLabelAutoFit = true;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8.0F, System.Drawing.FontStyle.Bold);
                
                chart1.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle |=
                     LabelAutoFitStyles.LabelsAngleStep30;
                ///Dinh dang zoom cho bieu do
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
               
                //Dinh vi tri cho Series
                chart1.Series["Series1"].LegendText = "Kênh "+colValue1.ToString();

                //Dinh vi tri cho Legends
                chart1.Legends["Legend1"].Docking = Docking.Top;
                //chart1.Legends["Legend1"].Title = "Kênh 1";

                //Dinh dang cho cac Grid cua do thi.
                chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                //cho cot ox
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Thời Gian -------->";
                chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
                chart1.ChartAreas["ChartArea1"].AxisX.TitleForeColor = Color.Red;
                //cho cot oy
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Giá Trị -------->";
                chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
                chart1.ChartAreas["ChartArea1"].AxisY.TitleForeColor = Color.Red;
                
                #endregion
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show(ex.Message.ToString(), "Lỗi !");
                //Re-open file
                //if (dr == DialogResult.OK)
                //{
                //    OpenFileDialog theDialog = new OpenFileDialog();
                //    theDialog.Title = "Chọn file cần mở !";
                //    theDialog.Filter = "TXT files|*.txt";
                //    theDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //    if (theDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        Filepad = theDialog.FileName.ToString();
                //    }
                //    UpdateChart(1);
                //    chart1.Series["Series1"].IsValueShownAsLabel = false;
                //}
            }
        }
        /// <summary>
        /// Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(Count);
            chart1.ChartAreas["ChartArea1"].AxisY.ScaleView.ZoomReset(Count);
            chart1.Invalidate();
            UpdateChart(1);
        }
        /// <summary>
        /// save to image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Name = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + DateTime.Now.ToString("ss") + "_" + DateTime.Now.ToString("dd") + "." + DateTime.Now.ToString("MM") + "." + DateTime.Now.ToString("yyyy") + ".png";
            chart1.SaveImage(Name, ChartImageFormat.Png);
            MessageBox.Show("Đã Lưu thành công !", "Thông Báo", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Open file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Chọn file cần mở !";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                Filepad = theDialog.FileName.ToString();
            }
            UpdateChart(1);
        }
        /// <summary>
        /// About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trogiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp frmhelp = new FormHelp();
            frmhelp.Show();
        }
        /// <summary>
        /// Focus khi click vao chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Focus();
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            Count++;
        }
        /// <summary>
        /// Channel1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channel1F1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(Count);
            chart1.ChartAreas["ChartArea1"].AxisY.ScaleView.ZoomReset(Count);
            chart1.Invalidate();
            UpdateChart(1);
        }
        /// <summary>
        /// Channel 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channel2F2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(Count);
            chart1.ChartAreas["ChartArea1"].AxisY.ScaleView.ZoomReset(Count);
            chart1.Invalidate();
            UpdateChart(2);
        }
        /// <summary>
        /// Channel 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channel3F2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(Count);
            chart1.ChartAreas["ChartArea1"].AxisY.ScaleView.ZoomReset(Count);
            chart1.Invalidate();
            UpdateChart(3);
        }
        /// <summary>
        /// Channel 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channel4F3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(Count);
            chart1.ChartAreas["ChartArea1"].AxisY.ScaleView.ZoomReset(Count);
            chart1.Invalidate();
            UpdateChart(4);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
        

       
    }
        
}
