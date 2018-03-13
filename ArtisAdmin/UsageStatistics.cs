using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtisAdmin
{
    public partial class UsageStatistics : Form
    {
        Graphics gr;
        DataTable topUsers;
        String[] semNames;
        DataTable resUsage;
        //Indexes in each of these arrays:
        //0 - Current Semester
        //1 - Last Semester
        //2 - Two semesters previous (AGO2SEM)
        int[] conferenceRoom = new int[3];
        int[] eastD = new int[3];
        int[] westD = new int[3];
        int[] breakoutRoom = new int[3];
        int[] stadiumPod = new int[3];

        public UsageStatistics()
        {
            InitializeComponent();
            topUsers = Program.ARTISClient.getTopUsers();
            semNames = Program.ARTISClient.getSemesterNames();
            resUsage = Program.ARTISClient.getResourceUsage();
            pbxResourceUsage.Paint += pbxResourceUsage_Paint;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsageStatistics_Load(object sender, EventArgs e)
        {
            prepareLabels();
            getTopUsers();
            getResUsage();
            populateResUsage();
        }

        private void getTopUsers()
        {
            dgvTopUsers.Columns[2].HeaderText = semNames[0];
            dgvTopUsers.Columns[3].HeaderText = semNames[1];
            dgvTopUsers.Columns[4].HeaderText = semNames[2];

            foreach (DataRow row in topUsers.Rows)
            {
                dgvTopUsers.Rows.Add(row["resrank"], row["Username"], row["cursem"], row["lastsem"], row["ago2sem"]);
            }
        }

        private void getResUsage()
        {
            foreach (DataRow row in resUsage.Rows)
            {
                switch (row["rname"].ToString().ToLower())
                {
                    case "east d-table":
                        eastD[0] = Int32.Parse(row["cursem"].ToString());
                        eastD[1] = Int32.Parse(row["lastsem"].ToString());
                        eastD[2] = Int32.Parse(row["AGO2SEM"].ToString());
                        break;
                    case "stadium pod":
                        stadiumPod[0] = Int32.Parse(row["cursem"].ToString());
                        stadiumPod[1] = Int32.Parse(row["lastsem"].ToString());
                        stadiumPod[2] = Int32.Parse(row["AGO2SEM"].ToString());
                        break;
                    case "west d-table":
                        westD[0] = Int32.Parse(row["cursem"].ToString());
                        westD[1] = Int32.Parse(row["lastsem"].ToString());
                        westD[2] = Int32.Parse(row["AGO2SEM"].ToString());
                        break;
                    case "break-out room":
                        breakoutRoom[0] = Int32.Parse(row["cursem"].ToString());
                        breakoutRoom[1] = Int32.Parse(row["lastsem"].ToString());
                        breakoutRoom[2] = Int32.Parse(row["AGO2SEM"].ToString());
                        break;
                    case "conference room":
                        conferenceRoom[0] = Int32.Parse(row["cursem"].ToString());
                        conferenceRoom[1] = Int32.Parse(row["lastsem"].ToString());
                        conferenceRoom[2] = Int32.Parse(row["AGO2SEM"].ToString());
                        break;
                }
            }
        }

        private void populateResUsage()
        {
            lblConferenceCurData.Text = conferenceRoom[0].ToString();
            lblConferenceLastData.Text = conferenceRoom[1].ToString();
            lblConfereceAgoData.Text = conferenceRoom[2].ToString();

            lblBreakOutCurData.Text = breakoutRoom[0].ToString();
            lblBreakOutLastData.Text = breakoutRoom[1].ToString();
            lblBreakOutAgoData.Text = breakoutRoom[2].ToString();

            lblWestDCurData.Text = westD[0].ToString();
            lblWestDLastData.Text = westD[1].ToString();
            lblWestDAgoData.Text = westD[2].ToString();

            lblEastDCurData.Text = eastD[0].ToString();
            lblEastDLastData.Text = eastD[1].ToString();
            lblEastDAgoData.Text = eastD[2].ToString();

            lblStadiumCurData.Text = stadiumPod[0].ToString();
            lblStadiumLastData.Text = stadiumPod[1].ToString();
            lblStadiumAgoData.Text = stadiumPod[2].ToString();
        }

        private void pbxResourceUsage_Paint(object sender, PaintEventArgs e)
        {
            gr = pbxResourceUsage.CreateGraphics();
            
            int breakoutRoomTotal = breakoutRoom.Sum();
            int eastDTotal = eastD.Sum();
            int stadiumPodTotal = stadiumPod.Sum();
            int westDTotal = westD.Sum();
            int conferenceRoomTotal = conferenceRoom.Sum();

            float total = breakoutRoomTotal + eastDTotal + stadiumPodTotal + westDTotal + conferenceRoomTotal;

            float deg1 = (breakoutRoomTotal / total) * 360;
            float deg2 = (eastDTotal / total) * 360;
            float deg3 = (stadiumPodTotal / total) * 360;
            float deg4 = (westDTotal / total) * 360;
            float deg5 = (conferenceRoomTotal / total) * 360;

            //Brush For Break Out Room
            Brush brush1 = new SolidBrush(Color.DarkSeaGreen);
            //Brush For East D Table
            Brush brush2 = new SolidBrush(Color.Coral);
            //Brush For Stadium Pod
            Brush brush3 = new SolidBrush(Color.RoyalBlue);
            //Brush For West D Table
            Brush brush4 = new SolidBrush(Color.Purple);
            //Brush For Conference Room
            Brush brush5 = new SolidBrush(Color.SaddleBrown);

            Rectangle r = new Rectangle(3, 3, 275, 290);

            gr.Clear(pbxResourceUsage.BackColor);

            e.Graphics.FillPie(brush1, r, 0, deg1);
            e.Graphics.FillPie(brush2, r, deg1, deg2);
            e.Graphics.FillPie(brush3, r, deg1 + deg2, deg3);
            e.Graphics.FillPie(brush4, r, deg1 + deg2 + deg3, deg4);
            e.Graphics.FillPie(brush5, r, deg1 + deg2 + deg3 + deg4, deg5);

            //Paint Break Out Room Key
            gr = pbxBreakOut.CreateGraphics();
            r = new Rectangle(3, 3, 240, 21);
            gr.FillRectangle(brush1, r);

            //Paint East D Table Key
            gr = pbxEastD.CreateGraphics();
            r = new Rectangle(3, 3, 240, 21);
            gr.FillRectangle(brush2, r);

            //Paint Stadium Pod Key
            gr = pbxStadium.CreateGraphics();
            r = new Rectangle(3, 3, 240, 21);
            gr.FillRectangle(brush3, r);

            //Paint West D Table Key
            gr = pbxWestD.CreateGraphics();
            r = new Rectangle(3, 3, 240, 21);
            gr.FillRectangle(brush4, r);

            //Paint Conference Room Key
            gr = pbxConference.CreateGraphics();
            r = new Rectangle(3, 3, 240, 21);
            gr.FillRectangle(brush5, r);

        }

        private void prepareLabels()
        {
            lblConferenceCur.Text = semNames[0] + ": ";
            lblBreakOutCur.Text = semNames[0] + ": ";
            lblWestDCur.Text = semNames[0] + ": ";
            lblEastDCur.Text = semNames[0] + ": ";
            lblStadiumCur.Text = semNames[0] + ": ";

            lblConferenceLast.Text = semNames[1] + ": ";
            lblBreakOutLast.Text = semNames[1] + ": ";
            lblWestDLast.Text = semNames[1] + ": ";
            lblEastDLast.Text = semNames[1] + ": ";
            lblStadiumLast.Text = semNames[1] + ": ";

            lblConferenceAgo2Sem.Text = semNames[2] + ": ";
            lblBreakOutAgo2Sem.Text = semNames[2] + ": ";
            lblWestDAgo2Sem.Text = semNames[2] + ": ";
            lblEastDAgo2Sem.Text = semNames[2] + ": ";
            lblStadiumAgo2Sem.Text = semNames[2] + ": ";
        }
    }
}
