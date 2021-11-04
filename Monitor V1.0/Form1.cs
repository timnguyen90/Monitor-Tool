using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Monitor_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Filepad;
        private void Form1_Load(object sender, EventArgs e)
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


        }
        /// <summary>
        /// Kenh 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               
                FileStream fs = new FileStream();
                fs.FileName = Filepad;
                //Xu li bieu do
                //Tim max cho truc Y
                DataTable ChartData = fs.ReturnAllData();
                //chart1.DataSource = ChartData;
                int max = int.Parse(ChartData.Rows[0][1].ToString());
                for (int i = 0; i < ChartData.Rows.Count; i++)
                {
                    if (max < int.Parse(ChartData.Rows[i][1].ToString()))
                    {
                        max = int.Parse(ChartData.Rows[i][1].ToString());
                    }
                }
                if (chart1.ChartAreas[0].AxisY.Maximum < max)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = max;
                }
                chart1.Series.Clear();
                Series s = new Series();
                for (int i = 0; i < ChartData.Rows.Count; i++)
                {
                    DataPoint p = new DataPoint();
                    p.XValue = i;
                    p.SetValueY(int.Parse(ChartData.Rows[i][1].ToString()));
                    //Add gia tri ngay thang vao cot X cua bieu do
                    p.AxisLabel = ChartData.Rows[i][0].ToString();
                    s.Points.Add(p);
                }
                chart1.Series.Add(s);
                chart1.Legends["Legend1"].Title = "Kênh 1";
                chart1.Series["Series1"].IsValueShownAsLabel = true;
                chart1.Series["Series1"]["LabelStyle"] = "Top";
                chart1.Series["Series1"].ChartType = SeriesChartType.Line;
                chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
                //Dinh dang hien thi cot OX cho bieu do
                chart1.ChartAreas["ChartArea1"].AxisX.IsLabelAutoFit = true;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle |=
                     LabelAutoFitStyles.LabelsAngleStep30;
                ///Dinh dang zoom cho bieu do
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi !");
            }
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
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Focus();
        }

        /// <summary>
        /// Kenh 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream();
                fs.FileName = Filepad;
                //Xu li bieu do
                //Tim max cho truc Y
                DataTable ChartData = fs.ReturnAllData();
                //chart1.DataSource = ChartData;
                int max = int.Parse(ChartData.Rows[0][2].ToString());
                for (int i = 0; i < ChartData.Rows.Count; i++)
                {
                    if (max < int.Parse(ChartData.Rows[i][2].ToString()))
                    {
                        max = int.Parse(ChartData.Rows[i][2].ToString());
                    }
                }
                if (chart1.ChartAreas[0].AxisY.Maximum < max)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = max;
                }
                chart1.Series.Clear();
                Series s = new Series();
                for (int i = 0; i < ChartData.Rows.Count; i++)
                {
                    DataPoint p = new DataPoint();
                    p.XValue = i;
                    p.SetValueY(int.Parse(ChartData.Rows[i][2].ToString()));
                    //Add gia tri ngay thang vao cot X cua bieu do
                    p.AxisLabel = ChartData.Rows[i][0].ToString();
                    s.Points.Add(p);
                }

                chart1.Series.Add(s);
                chart1.Legends["Legend1"].Title = "Kênh 2";
                chart1.Series["Series1"].IsValueShownAsLabel = true;
                chart1.Series["Series1"]["LabelStyle"] = "Top";
                chart1.Series["Series1"].ChartType = SeriesChartType.Line;
                chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
                //Dinh dang hien thi cot OX cho bieu do
                chart1.ChartAreas["ChartArea1"].AxisX.IsLabelAutoFit = true;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle |=
                     LabelAutoFitStyles.LabelsAngleStep30;
                ///Dinh dang zoom cho bieu do
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi !");
            }
        }

        /// <summary>
        /// Kenh 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channel3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream();
                fs.FileName = Filepad;
                //Xu li bieu do
                //Tim max cho truc Y
                DataTable ChartData = fs.ReturnAllData();
                //chart1.DataSource = ChartData;
                int max = int.Parse(ChartData.Rows[0][2].ToString());
                for (int i = 0; i < ChartData.Rows.Count; i++)
                {
                    if (max < int.Parse(ChartData.Rows[i][3].ToString()))
                    {
                        max = int.Parse(ChartData.Rows[i][3].ToString());
                    }
                }
                if (chart1.ChartAreas[0].AxisY.Maximum < max)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = max;
                }
                chart1.Series.Clear();
                Series s = new Series();
                for (int i = 0; i < ChartData.Rows.Count; i++)
                {
                    DataPoint p = new DataPoint();
                    //p.XValue = ChartData.Rows[i][0];
                    p.XValue = i;
                    p.SetValueY(int.Parse(ChartData.Rows[i][3].ToString()));
                    //Add gia tri ngay thang vao cot X cua bieu do
                    p.AxisLabel = ChartData.Rows[i][0].ToString();
                    s.Points.Add(p);
                }
                chart1.Series.Add(s);
                chart1.Legends["Legend1"].Title = "Kênh 3";
                chart1.Series["Series1"].IsValueShownAsLabel = true;
                chart1.Series["Series1"]["LabelStyle"] = "Top";
                chart1.Series["Series1"].ChartType = SeriesChartType.Line;
                chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
                //Dinh dang hien thi cot OX cho bieu do
                chart1.ChartAreas["ChartArea1"].AxisX.IsLabelAutoFit = true;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle |=
                     LabelAutoFitStyles.LabelsAngleStep30;
                ///Dinh dang zoom cho bieu do
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi !");
            }
        }
        /// <summary>
        /// Kenh 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channel4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream();
                fs.FileName = Filepad;
                //Xu li bieu do
                //Tim max cho truc Y
                DataTable ChartData = fs.ReturnAllData();
                //chart1.DataSource = ChartData;
                int max = int.Parse(ChartData.Rows[0][4].ToString());
                for (int i = 0; i < ChartData.Rows.Count; i++)
                {
                    if (max < int.Parse(ChartData.Rows[i][4].ToString()))
                    {
                        max = int.Parse(ChartData.Rows[i][4].ToString());
                    }
                }
                if (chart1.ChartAreas[0].AxisY.Maximum < max)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = max;
                }
                chart1.Series.Clear();
                Series s = new Series();
                for (int i = 0; i < ChartData.Rows.Count; i++)
                {
                    DataPoint p = new DataPoint();
                    //p.XValue = ChartData.Rows[i][0];
                    p.XValue = i;
                    p.SetValueY(int.Parse(ChartData.Rows[i][4].ToString()));
                    //Add gia tri ngay thang vao cot X cua bieu do
                    p.AxisLabel = ChartData.Rows[i][0].ToString();
                    s.Points.Add(p);
                }
                chart1.Series.Add(s);
                    chart1.Legends["Legend1"].Title = "Kênh 4";
                chart1.Series["Series1"].IsValueShownAsLabel = true;
                chart1.Series["Series1"]["LabelStyle"] = "Top";
                chart1.Series["Series1"].ChartType = SeriesChartType.Line;
                chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
                //Dinh dang hien thi cot OX cho bieu do
                chart1.ChartAreas["ChartArea1"].AxisX.IsLabelAutoFit = true;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle |=
                     LabelAutoFitStyles.LabelsAngleStep30;
                ///Dinh dang zoom cho bieu do
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi !");
            }
        }
        /// <summary>
        /// about
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trogiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp frmhelp = new FormHelp();
            frmhelp.Show();
        }
    }
        
}
