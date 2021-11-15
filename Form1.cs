using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace XmlStudentCirclesParser
{
    public partial class MainForm : Form
    {
        public const string circlesFilePathXML = @"C:\Users\novik\source\repos\XmlStudentsParser\Circles.xml";
        public const string circlesFilePathHTML = @"C:\Users\novik\source\repos\XmlStudentsParser\Circles.html";
        public const string circlesFilePathXSL = @"C:\Users\novik\source\repos\XmlStudentsParser\Circles.xsl";
        public const string CircleName = "Name";
        public const string Faculty = "Faculty";
        public const string Schedule = "Schedule";
        public const string Monitor = "Monitor";
        public const string Subject = "Subject";
        public const string Circle = "Circle";

        public MainForm()
        {
            InitializeComponent();
            SetAllBoxes();
        }

        private void Parse()
        {
            Circle circleToSearch = GetCircleToSearch();
            ISearch algo = new LinqToXmlAlgorithm();

            if (DOMButton.Checked)
                algo = new DOMAlgorithm();
            else if (SAXButton.Checked)
                algo = new SAXAlgorithm();

            List<Circle> circles = algo.Search(circleToSearch);
            SetText(circles);
        }
        private void SetAllBoxes()
        {
            var doc = XDocument.Load(circlesFilePathXML);

            foreach (var item in doc.Descendants(Circle))
            {
                string name = item.Attribute(CircleName).Value;
                if (!NameComboBox.Items.Contains(name))
                    NameComboBox.Items.Add(name);

                string faculty = item.Attribute(Faculty).Value;
                if (!FacultyComboBox.Items.Contains(faculty))
                    FacultyComboBox.Items.Add(faculty);

                string schedule = item.Attribute(Schedule).Value;
                if (!ScheduleComboBox.Items.Contains(schedule))
                    ScheduleComboBox.Items.Add(schedule);

                string monitor = item.Attribute(Monitor).Value;
                if (!MonitorComboBox.Items.Contains(monitor))
                    MonitorComboBox.Items.Add(monitor);

                string subject = item.Attribute(Subject).Value;
                if (!SubjectComboBox.Items.Contains(subject))
                    SubjectComboBox.Items.Add(subject);
            }
        }
        
        private Circle GetCircleToSearch()
        {
            Circle res = new Circle();

            if (NameCheckBox.Checked && NameComboBox.Text.ToString() != "")
                res.Name = NameComboBox.Text.ToString();
            if (FacultyCheckBox.Checked && FacultyComboBox.Text.ToString() != "")
                res.Faculty = FacultyComboBox.Text.ToString();
            if (ScheduleCheckBox.Checked && ScheduleComboBox.Text.ToString() != "")
                res.Schedule = ScheduleComboBox.Text.ToString();
            if (MonitorCheckBox.Checked && MonitorComboBox.Text.ToString() != "")
                res.Monitor = MonitorComboBox.Text.ToString();
            if (SubjectCheckBox.Checked && SubjectComboBox.Text.ToString() != "")
                res.Subject = SubjectComboBox.Text.ToString();

            return res;
        }

        private void SetText(List<Circle> data)
        {
            richTextBox1.Clear();

            foreach(Circle circle in data)
            {
                richTextBox1.AppendText(CircleName + " : " + circle.Name + '\n');
                richTextBox1.AppendText(Faculty + " : " + circle.Faculty + '\n');
                richTextBox1.AppendText(Schedule + " : "  + circle.Schedule + '\n');
                richTextBox1.AppendText(Monitor +  " : " + circle.Monitor + '\n');
                richTextBox1.AppendText(Subject + " : " + circle.Subject + '\n');
                richTextBox1.AppendText("_________" + '\n');
            }

        }

        private void Clear()
        {
            richTextBox1.Clear();
            SearchButton.Enabled = false;
            NameCheckBox.Checked = false;
            FacultyCheckBox.Checked = false;
            ScheduleCheckBox.Checked = false;
            MonitorCheckBox.Checked = false;
            SubjectCheckBox.Checked = false;
            NameComboBox.Text = null;
            FacultyComboBox.Text = null;
            ScheduleComboBox.Text = null;
            MonitorComboBox.Text = null;
            SubjectComboBox.Text = null;
            DOMButton.Checked = false;
            LINQToXMLButton.Checked = false;
            SAXButton.Checked = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Parse();
        }

        private void Transform()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(circlesFilePathXSL);
            xct.Transform(circlesFilePathXML, circlesFilePathHTML);
        }

        private void NameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NameCheckBox.Checked)
                NameComboBox.Enabled = true;
            else
                NameComboBox.Enabled = false;
        }

        private void DOMButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DOMButton.Checked)
                SearchButton.Enabled = true;
        }

        private void SAXButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SAXButton.Checked)
                SearchButton.Enabled = true;
        }

        private void LINQToXMLButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LINQToXMLButton.Checked)
                SearchButton.Enabled = true;
        }

        private void FacultyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FacultyCheckBox.Checked)
                FacultyComboBox.Enabled = true;
            else
                FacultyComboBox.Enabled = false;
        }

        private void ScheduleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ScheduleCheckBox.Checked)
                ScheduleComboBox.Enabled = true;
            else
                ScheduleComboBox.Enabled = false;
        }

        private void MonitorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MonitorCheckBox.Checked)
                MonitorComboBox.Enabled = true;
            else
                MonitorComboBox.Enabled = false;
        }

        private void SubjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubjectCheckBox.Checked)
                SubjectComboBox.Enabled = true;
            else
                SubjectComboBox.Enabled = false;
        }

        private void TransformButton_Click(object sender, EventArgs e)
        {
            Transform();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to quit?", "Warning",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }

    }
}
