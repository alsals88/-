using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace UIForm
{
    public partial class Form2 : MetroForm
    {
        //private static string dbCommand = "";
        //private static BindingSource bindingsrc;

        //private static string dbPath = Application.StartupPath + "\\a.sqlite.db";
        private static string strCon = "Data Source=c:\\Users\\alswl\\databases\\a.sqlite.db;Version=3;New=False;Compress=True";

        private static SQLiteConnection conn = new SQLiteConnection(strCon); //아니면 strcon
        private static SQLiteCommand cmd = new SQLiteCommand("", conn);
        private static SQLiteDataReader reader;

        private static string sql;

        /*DialogResult dr = MetroMessageBox.Show(this, "\n\nContinue Logging Out?", "EMPLOYEE MODULE | LOG OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
             YourEventsHere;
        }
        else
        {
             YourElseEvents;
        }*/

public Form2()
        {
            InitializeComponent();         
        }


        // 데이터 연동 메서드 - 공과대학
        public void getData1()
        {
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from 공과대학 order by 이름 asc", conn);
            DataSet dSet = new DataSet();
            adapter.Fill(dSet, "info");
            dataGridView1.DataSource = dSet.Tables[0];
            conn.Close();
        }
        // 데이터 연동 메서드 - 정보통신대학
        public void getData2()
        {
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from 정보통신대학 order by 이름 asc", conn);
            DataSet dSet = new DataSet();
            adapter.Fill(dSet, "info");
            dataGridView2.DataSource = dSet.Tables[0];
            conn.Close();
        }
        // 데이터 연동 - 에너지바이오대학
        public void getData3()
        {
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from 에너지바이오대학 order by 이름 asc", conn);
            DataSet dSet = new DataSet();
            adapter.Fill(dSet, "info");
            dataGridView3.DataSource = dSet.Tables[0];
            conn.Close();
        }
        // 데이터 연동 메서드 - 조형대학
        public void getData4()
        {
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from 조형대학 order by 이름 asc", conn);
            DataSet dSet = new DataSet();
            adapter.Fill(dSet, "info");
            dataGridView4.DataSource = dSet.Tables[0];
            conn.Close();
        }
        // 데이터 연동 메서드 - 인문사회대학
        public void getData5()
        {
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from 인문사회대학 order by 이름 asc", conn);
            DataSet dSet = new DataSet();
            adapter.Fill(dSet, "info");
            dataGridView5.DataSource = dSet.Tables[0];
            conn.Close();
        }
        // 데이터 연동 메서드 - 기술경영융합대학
        public void getData6()
        {
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from 기술경영융합대학 order by 이름 asc", conn);
            DataSet dSet = new DataSet();
            adapter.Fill(dSet, "info");
            dataGridView6.DataSource = dSet.Tables[0];
            conn.Close();
        }
        // 데이터 연동 메서드 - 창의융합대학
        public void getData7()
        {
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from 창의융합대학 order by 이름 asc", conn);
            DataSet dSet = new DataSet();
            adapter.Fill(dSet, "info");
            dataGridView7.DataSource = dSet.Tables[0];
            conn.Close();
        }
        // 데이터 연동 메서드 - 미래융합대학
        public void getData8()
        {
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from 미래융합대학 order by 이름 asc", conn);
            DataSet dSet = new DataSet();
            adapter.Fill(dSet, "info");
            dataGridView8.DataSource = dSet.Tables[0];
            conn.Close();
        }



        // 세부 설정 메서드 - 공과대학
        public void detail1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns["전공"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 대학 콤보상자 설정
            comboBox1.Items.Add(tabPage1.Text); // 공과대학
            comboBox1.SelectedIndex = 0;

            // 학과 콤보상자 설정
            comboBox2.Items.Add("기계시스템디자인공학과"); // 공과대학
            comboBox2.Items.Add("기계.자동차공학과");
            comboBox2.Items.Add("안전공학과");
            comboBox2.Items.Add("신소재학과");
            comboBox2.Items.Add("건설시스템공학과");
            comboBox2.Items.Add("건축학부(건축공학전공)");
            comboBox2.Items.Add("건축학부(건축학전공)");
            comboBox2.Items.Add("[계약학과]건축기계설비공학과");
        }
        // 세부 설정 메서드 - 정보통신대학
        public void detail2()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView2.Columns["전공"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 대학 콤보상자 설정
            comboBox4.Items.Add(tabPage2.Text); // 정보통신대학
            comboBox4.SelectedIndex = 0;

            // 학과 콤보상자 설정
            comboBox3.Items.Add("전기정보공학과"); // 정보통신대학
            comboBox3.Items.Add("전자IT미디어공학과");
            comboBox3.Items.Add("컴퓨터공학과");
        }
        // 세부 설정 메서드 - 에너지바이오대학
        public void detail3()
        {
            dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView3.Columns["전공"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 대학 콤보상자 설정
            comboBox6.Items.Add(tabPage3.Text); // 에너지바이오대학
            comboBox6.SelectedIndex = 0;

            // 학과 콤보상자 설정
            comboBox5.Items.Add("화공생명공학과"); // 에너지바이오대학
            comboBox5.Items.Add("환경공학과");
            comboBox5.Items.Add("식품공학과");
            comboBox5.Items.Add("정밀화학과");
            comboBox5.Items.Add("안경광학과");
        }
        // 세부 설정 메서드 - 조형대학
        public void detail4()
        {
            dataGridView4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView4.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView4.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView4.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView4.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView4.Columns["전공"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 대학 콤보상자 설정
            comboBox8.Items.Add(tabPage4.Text); // 조형대학
            comboBox8.SelectedIndex = 0;

            // 학과 콤보상자 설정
            comboBox7.Items.Add("디자인학과(산업디자인전공)"); // 조형대학
            comboBox7.Items.Add("디자인학과(시각디자인전공)");
            comboBox7.Items.Add("도예학과");
            comboBox7.Items.Add("금속공예디자인학과");
            comboBox7.Items.Add("조형예술학과");
        }
        // 세부 설정 메서드 - 인문사회대학
        public void detail5()
        {
            dataGridView5.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView5.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView5.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView5.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView5.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView5.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView5.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView5.Columns["전공"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 대학 콤보상자 설정
            comboBox10.Items.Add(tabPage5.Text); // 인문사회대학
            comboBox10.SelectedIndex = 0;

            // 학과 콤보상자 설정
            comboBox9.Items.Add("행정학과"); // 인문사회대학
            comboBox9.Items.Add("영어영문학과");
            comboBox9.Items.Add("문예창작학과");
            comboBox9.Items.Add("기초교육학부");
        }
        // 세부 설정 메서드 - 기술경영융합대학
        public void detail6()
        {
            dataGridView6.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView6.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView6.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView6.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView6.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView6.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView6.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView6.Columns["전공"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 대학 콤보상자 설정
            comboBox12.Items.Add(tabPage6.Text); // 기술경영융합대학
            comboBox12.SelectedIndex = 0;

            // 학과 콤보상자 설정
            comboBox11.Items.Add("산업공학과(산업정보시스템전공)"); // 기술경영융합대학
            comboBox11.Items.Add("산업공학과(ITM전공)");
            comboBox11.Items.Add("MSDE학과");
            comboBox11.Items.Add("경영학과(경영학전공)");
            comboBox11.Items.Add("경영학과(클로벌테크노경영전공)");
        }
        // 세부 설정 메서드 - 창의융합대학
        public void detail7()
        {
            dataGridView7.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView7.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView7.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView7.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView7.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView7.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView7.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView7.Columns["전공"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 대학 콤보상자 설정
            comboBox14.Items.Add(tabPage7.Text); // 창의융합대학
            comboBox14.SelectedIndex = 0;

            // 학과 콤보상자 설정
            comboBox13.Items.Add("인공지능응용학과"); // 창의융합대학
            comboBox13.Items.Add("지능형반도체공학과");
            comboBox13.Items.Add("미래에너지융합학과");
        }
        // 세부 설정 메서드 - 미래융합대학
        public void detail8()
        {
            dataGridView8.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView8.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView8.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView8.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView8.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView8.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView8.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView8.Columns["전공"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 대학 콤보상자 설정
            comboBox16.Items.Add(tabPage8.Text); // 미래융합대학
            comboBox16.SelectedIndex = 0;

            // 학과 콤보상자 설정
            comboBox15.Items.Add("융합공학부(융합기계공학전공)"); // 미래융합대학
            comboBox15.Items.Add("융합공학부(건설환경융합전공)");
            comboBox15.Items.Add("융합공학부(헬스피트니스전공)");
            comboBox15.Items.Add("융합공학부(문화예술전공)");
            comboBox15.Items.Add("융합공학부(영어전공)");
            comboBox15.Items.Add("융합공학부(벤처경영전공)");
        }



        // textbox 초기화 메서드 - 공과대학
        public void madeEmpty1()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            comboBox2.Text = string.Empty;
        }
        // textbox 초기화 메서드 - 정보통신대학
        public void madeEmpty2()
        {
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            comboBox3.Text = string.Empty;
        }
        // textbox 초기화 메서드 - 에너지바이오대학
        public void madeEmpty3()
        {
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            textBox14.Text = string.Empty;
            textBox15.Text = string.Empty;
            comboBox5.Text = string.Empty;
        }
        // textbox 초기화 메서드 - 조형대학
        public void madeEmpty4()
        {
            textBox16.Text = string.Empty;
            textBox17.Text = string.Empty;
            textBox18.Text = string.Empty;
            textBox19.Text = string.Empty;
            textBox20.Text = string.Empty;
            comboBox7.Text = string.Empty;
        }
        // textbox 초기화 메서드 - 인문사회대학
        public void madeEmpty5()
        {
            textBox21.Text = string.Empty;
            textBox22.Text = string.Empty;
            textBox23.Text = string.Empty;
            textBox24.Text = string.Empty;
            textBox25.Text = string.Empty;
            comboBox9.Text = string.Empty;
        }
        // textbox 초기화 메서드 - 기술경영융합대학
        public void madeEmpty6()
        {
            textBox26.Text = string.Empty;
            textBox27.Text = string.Empty;
            textBox28.Text = string.Empty;
            textBox29.Text = string.Empty;
            textBox30.Text = string.Empty;
            comboBox11.Text = string.Empty;
        }
        // textbox 초기화 메서드 - 창의융합대학
        public void madeEmpty7()
        {
            textBox31.Text = string.Empty;
            textBox32.Text = string.Empty;
            textBox33.Text = string.Empty;
            textBox34.Text = string.Empty;
            textBox35.Text = string.Empty;
            comboBox13.Text = string.Empty;
        }
        // textbox 초기화 메서드 - 미래융합대학
        public void madeEmpty8()
        {
            textBox36.Text = string.Empty;
            textBox37.Text = string.Empty;
            textBox38.Text = string.Empty;
            textBox39.Text = string.Empty;
            textBox40.Text = string.Empty;
            comboBox15.Text = string.Empty;
        }



        // 폼 로드(데어터 불러오고, 크기 조정)
        private void Form2_Load(object sender, EventArgs e)
        {
            // 데이터 가져오기 - 공과대학
            getData1();
            detail1();
            // 데이터 가져오기 - 공과대학
            getData2();
            detail2();
            // 데이터 가져오기 - 공과대학
            getData3();
            detail3();
            // 데이터 가져오기 - 공과대학
            getData4();
            detail4();
            // 데이터 가져오기 - 공과대학
            getData5();
            detail5();
            // 데이터 가져오기 - 공과대학
            getData6();
            detail6();
            // 데이터 가져오기 - 공과대학
            getData7();
            detail7();
            // 데이터 가져오기 - 공과대학
            getData8();
            detail8();
        }



        // 셀 선택 시 텍스트 박스에 정보 표시 - 공과대학
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        // 셀 선택 시 텍스트 박스에 정보 표시 - 정보통신대학
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox10.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            comboBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }
        // 셀 선택 시 텍스트 박스에 정보 표시 - 에너지바이오대학
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox15.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            comboBox5.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textBox14.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBox13.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            textBox12.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            textBox11.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
        }
        // 셀 선택 시 텍스트 박스에 정보 표시 - 조형대학
        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox20.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            comboBox7.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            textBox19.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            textBox18.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            textBox17.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
            textBox16.Text = dataGridView4.CurrentRow.Cells[6].Value.ToString();
        }
        // 셀 선택 시 텍스트 박스에 정보 표시 - 인문사회대학
        private void dataGridView5_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox25.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            comboBox9.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
            textBox24.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();
            textBox23.Text = dataGridView5.CurrentRow.Cells[4].Value.ToString();
            textBox22.Text = dataGridView5.CurrentRow.Cells[5].Value.ToString();
            textBox21.Text = dataGridView5.CurrentRow.Cells[6].Value.ToString();
        }
        // 셀 선택 시 텍스트 박스에 정보 표시 - 기술경영융합대학
        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox30.Text = dataGridView6.CurrentRow.Cells[0].Value.ToString();
            comboBox11.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
            textBox29.Text = dataGridView6.CurrentRow.Cells[3].Value.ToString();
            textBox28.Text = dataGridView6.CurrentRow.Cells[4].Value.ToString();
            textBox27.Text = dataGridView6.CurrentRow.Cells[5].Value.ToString();
            textBox26.Text = dataGridView6.CurrentRow.Cells[6].Value.ToString();
        }
        // 셀 선택 시 텍스트 박스에 정보 표시 - 창의융합대학
        private void dataGridView7_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox35.Text = dataGridView7.CurrentRow.Cells[0].Value.ToString();
            comboBox13.Text = dataGridView7.CurrentRow.Cells[2].Value.ToString();
            textBox34.Text = dataGridView7.CurrentRow.Cells[3].Value.ToString();
            textBox33.Text = dataGridView7.CurrentRow.Cells[4].Value.ToString();
            textBox32.Text = dataGridView7.CurrentRow.Cells[5].Value.ToString();
            textBox31.Text = dataGridView7.CurrentRow.Cells[6].Value.ToString();
        }
        // 셀 선택 시 텍스트 박스에 정보 표시 - 미래융합대학
        private void dataGridView8_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox40.Text = dataGridView8.CurrentRow.Cells[0].Value.ToString();
            comboBox15.Text = dataGridView8.CurrentRow.Cells[2].Value.ToString();
            textBox39.Text = dataGridView8.CurrentRow.Cells[3].Value.ToString();
            textBox38.Text = dataGridView8.CurrentRow.Cells[4].Value.ToString();
            textBox37.Text = dataGridView8.CurrentRow.Cells[5].Value.ToString();
            textBox36.Text = dataGridView8.CurrentRow.Cells[6].Value.ToString();
        }



        // 추가 버튼 - 공과대학
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" & comboBox2.Text == "" & textBox2.Text == "" & textBox3.Text == "" & textBox4.Text == "" & textBox5.Text == "")
            {
                MessageBox.Show("하나 이상의 데이터가 입력되어야 합니다.", "실패");
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("이름은 반드시 입력하십시오.");
                return;
            }

            conn.Open();

            sql = "insert into 공과대학(이름, 대학, 학과, 전공, 전화번호, 이메일, 연구실) Values ('" 
                   + textBox1.Text + "', '" + comboBox1.SelectedItem + "', '" + comboBox2.SelectedItem + "', '"
                   + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("추가하시겠습니까? [이름]은 수정하실 수 없습니다.");

            madeEmpty1();

            getData1();
        }
        // 추가 버튼 - 정보통신대학
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" & comboBox3.Text == "" & textBox7.Text == "" & textBox8.Text == "" & textBox9.Text == "" & textBox10.Text == "")
            {
                MessageBox.Show("하나 이상의 데이터가 입력되어야 합니다.", "실패");
                return;
            }

            if (textBox10.Text == "")
            {
                MessageBox.Show("이름은 반드시 입력하십시오.");
                return;
            }

            conn.Open();

            sql = "insert into 정보통신대학(이름, 대학, 학과, 전공, 전화번호, 이메일, 연구실) Values ('"
                   + textBox10.Text + "', '" + comboBox4.SelectedItem + "', '" + comboBox3.SelectedItem + "', '"
                   + textBox9.Text + "', '" + textBox8.Text + "', '" + textBox7.Text + "', '" + textBox6.Text + "')";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("추가하시겠습니까? [이름]은 수정하실 수 없습니다.");

            madeEmpty2();

            getData2();
        }
        // 추가 버튼 - 에너지바이오대학
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "" & comboBox5.Text == "" & textBox12.Text == "" & textBox13.Text == "" & textBox14.Text == "" & textBox15.Text == "")
            {
                MessageBox.Show("하나 이상의 데이터가 입력되어야 합니다.", "실패");
                return;
            }

            if (textBox15.Text == "")
            {
                MessageBox.Show("이름은 반드시 입력하십시오.");
                return;
            }

            conn.Open();

            sql = "insert into 에너지바이오대학(이름, 대학, 학과, 전공, 전화번호, 이메일, 연구실) Values ('"
                   + textBox15.Text + "', '" + comboBox6.SelectedItem + "', '" + comboBox5.SelectedItem + "', '"
                   + textBox14.Text + "', '" + textBox13.Text + "', '" + textBox12.Text + "', '" + textBox11.Text + "')";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("추가하시겠습니까? [이름]은 수정하실 수 없습니다.");

            madeEmpty3();

            getData3();
        }
        // 추가 버튼 - 조형대학
        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox16.Text == "" & comboBox7.Text == "" & textBox17.Text == "" & textBox18.Text == "" & textBox19.Text == "" & textBox20.Text == "")
            {
                MessageBox.Show("하나 이상의 데이터가 입력되어야 합니다.", "실패");
                return;
            }

            if (textBox20.Text == "")
            {
                MessageBox.Show("이름은 반드시 입력하십시오.");
                return;
            }

            conn.Open();

            sql = "insert into 조형대학(이름, 대학, 학과, 전공, 전화번호, 이메일, 연구실) Values ('"
                   + textBox20.Text + "', '" + comboBox8.SelectedItem + "', '" + comboBox7.SelectedItem + "', '"
                   + textBox19.Text + "', '" + textBox18.Text + "', '" + textBox17.Text + "', '" + textBox16.Text + "')";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("추가하시겠습니까? [이름]은 수정하실 수 없습니다.");

            madeEmpty4();

            getData4();
        }
        // 추가 버튼 - 인문사회대학
        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox21.Text == "" & comboBox9.Text == "" & textBox22.Text == "" & textBox23.Text == "" & textBox24.Text == "" & textBox25.Text == "")
            {
                MessageBox.Show("하나 이상의 데이터가 입력되어야 합니다.", "실패");
                return;
            }

            if (textBox25.Text == "")
            {
                MessageBox.Show("이름은 반드시 입력하십시오.");
                return;
            }

            conn.Open();

            sql = "insert into 인문사회대학(이름, 대학, 학과, 전공, 전화번호, 이메일, 연구실) Values ('"
                   + textBox25.Text + "', '" + comboBox10.SelectedItem + "', '" + comboBox9.SelectedItem + "', '"
                   + textBox24.Text + "', '" + textBox23.Text + "', '" + textBox22.Text + "', '" + textBox21.Text + "')";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("추가하시겠습니까? [이름]은 수정하실 수 없습니다.");

            madeEmpty5();

            getData5();
        }
        // 추가 버튼 - 기술경영융합대학
        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox26.Text == "" & comboBox11.Text == "" & textBox27.Text == "" & textBox28.Text == "" & textBox29.Text == "" & textBox30.Text == "")
            {
                MessageBox.Show("하나 이상의 데이터가 입력되어야 합니다.", "실패");
                return;
            }

            if (textBox30.Text == "")
            {
                MessageBox.Show("이름은 반드시 입력하십시오.");
                return;
            }

            conn.Open();

            sql = "insert into 기술경영융합대학(이름, 대학, 학과, 전공, 전화번호, 이메일, 연구실) Values ('"
                   + textBox30.Text + "', '" + comboBox12.SelectedItem + "', '" + comboBox11.SelectedItem + "', '"
                   + textBox29.Text + "', '" + textBox28.Text + "', '" + textBox27.Text + "', '" + textBox26.Text + "')";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("추가하시겠습니까? [이름]은 수정하실 수 없습니다.");

            madeEmpty6();

            getData6();
        }
        // 추가 버튼 - 창의융합대학
        private void button35_Click(object sender, EventArgs e)
        {
            if (textBox35.Text == "" & comboBox13.Text == "" & textBox34.Text == "" & textBox33.Text == "" & textBox32.Text == "" & textBox31.Text == "")
            {
                MessageBox.Show("하나 이상의 데이터가 입력되어야 합니다.", "실패");
                return;
            }

            if (textBox35.Text == "")
            {
                MessageBox.Show("이름은 반드시 입력하십시오.");
                return;
            }

            conn.Open();

            sql = "insert into 창의융합대학(이름, 대학, 학과, 전공, 전화번호, 이메일, 연구실) Values ('"
                   + textBox35.Text + "', '" + comboBox14.SelectedItem + "', '" + comboBox13.SelectedItem + "', '"
                   + textBox34.Text + "', '" + textBox33.Text + "', '" + textBox32.Text + "', '" + textBox31.Text + "')";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("추가하시겠습니까? [이름]은 수정하실 수 없습니다.");

            madeEmpty7();

            getData7();
        }
        // 추가 버튼 - 미래융합대학
        private void button40_Click(object sender, EventArgs e)
        {
            if (textBox40.Text == "" & comboBox15.Text == "" & textBox39.Text == "" & textBox38.Text == "" & textBox37.Text == "" & textBox36.Text == "")
            {
                MessageBox.Show("하나 이상의 데이터가 입력되어야 합니다.", "실패");
                return;
            }

            if (textBox40.Text == "")
            {
                MessageBox.Show("이름은 반드시 입력하십시오.");
                return;
            }

            conn.Open();

            sql = "insert into 미래융합대학(이름, 대학, 학과, 전공, 전화번호, 이메일, 연구실) Values ('"
                   + textBox40.Text + "', '" + comboBox16.SelectedItem + "', '" + comboBox15.SelectedItem + "', '"
                   + textBox39.Text + "', '" + textBox38.Text + "', '" + textBox37.Text + "', '" + textBox36.Text + "')";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("추가하시겠습니까? [이름]은 수정하실 수 없습니다.");

            madeEmpty8();

            getData8();
        }



        // 삭제 버튼 - 공과대학
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "delete from 공과대학 where 이름 = '" + textBox1.Text + "'";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("삭제하시겠습니까?");

            madeEmpty1();

            getData1();
        }
        // 삭제 버튼 - 정보통신대학
        private void button9_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "delete from 정보통신대학 where 이름 = '" + textBox10.Text + "'";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("삭제하시겠습니까?");

            madeEmpty2();

            getData2();
        }
        // 삭제 버튼 - 에너지바이오대학
        private void button14_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "delete from 에너지바이오대학 where 이름 = '" + textBox15.Text + "'";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("삭제하시겠습니까?");

            madeEmpty3();

            getData3();
        }
        // 삭제 버튼 - 조형대학
        private void button19_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "delete from 조형대학 where 이름 = '" + textBox20.Text + "'";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("삭제하시겠습니까?");

            madeEmpty4();

            getData4();
        }
        // 삭제 버튼 - 인문사회대학
        private void button24_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "delete from 인문사회대학 where 이름 = '" + textBox25.Text + "'";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("삭제하시겠습니까?");

            madeEmpty5();

            getData5();
        }
        // 삭제 버튼 - 기술경영융합대학
        private void button29_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "delete from 기술경영융합대학 where 이름 = '" + textBox30.Text + "'";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("삭제하시겠습니까?");

            madeEmpty6();

            getData6();
        }
        // 삭제 버튼 - 창의융합대학
        private void button34_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "delete from 창의융합대학 where 이름 = '" + textBox35.Text + "'";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("삭제하시겠습니까?");

            madeEmpty7();

            getData7();
        }
        // 삭제 버튼 - 미래융합대학
        private void button39_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "delete from 미래융합대학 where 이름 = '" + textBox40.Text + "'";
            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("삭제하시겠습니까?");

            madeEmpty8();

            getData8();
        }



        // 수정 버튼 - 공과대학
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "update 공과대학 set 학과 = '" + comboBox2.Text + "', 전공 = '" + textBox2.Text +
                  "', 전화번호 = '" + textBox3.Text + "', 이메일 = '" + textBox4.Text + "', 연구실 = '" 
                  + textBox5.Text + "' where 이름 = '" + textBox1.Text + "'";

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();
            
            conn.Close();

            MessageBox.Show("[이름]은 수정하실 수 없습니다. 수정하시겠습니까?");

            madeEmpty1();

            getData1();
        }
        // 수정 버튼 - 정보통신대학
        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "update 정보통신대학 set 학과 = '" + comboBox3.Text + "', 전공 = '" + textBox9.Text +
                  "', 전화번호 = '" + textBox8.Text + "', 이메일 = '" + textBox7.Text + "', 연구실 = '"
                  + textBox6.Text + "' where 이름 = '" + textBox10.Text + "'";

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("[이름]은 수정하실 수 없습니다. 수정하시겠습니까?");

            madeEmpty2();

            getData2();
        }
        // 수정 버튼 - 에너지바이오대학
        private void button13_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "update 에너지바이오대학 set 학과 = '" + comboBox5.Text + "', 전공 = '" + textBox14.Text +
                  "', 전화번호 = '" + textBox13.Text + "', 이메일 = '" + textBox12.Text + "', 연구실 = '"
                  + textBox11.Text + "' where 이름 = '" + textBox15.Text + "'";

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("[이름]은 수정하실 수 없습니다. 수정하시겠습니까?");

            madeEmpty3();

            getData3();
        }
        // 수정 버튼 - 조형대학
        private void button18_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "update 조형대학 set 학과 = '" + comboBox7.Text + "', 전공 = '" + textBox19.Text +
                  "', 전화번호 = '" + textBox18.Text + "', 이메일 = '" + textBox17.Text + "', 연구실 = '"
                  + textBox16.Text + "' where 이름 = '" + textBox20.Text + "'";

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("[이름]은 수정하실 수 없습니다. 수정하시겠습니까?");

            madeEmpty4();

            getData4();
        }
        // 수정 버튼 - 인문사회대학
        private void button23_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "update 인문사회대학 set 학과 = '" + comboBox9.Text + "', 전공 = '" + textBox24.Text +
                  "', 전화번호 = '" + textBox23.Text + "', 이메일 = '" + textBox22.Text + "', 연구실 = '"
                  + textBox21.Text + "' where 이름 = '" + textBox25.Text + "'";

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("[이름]은 수정하실 수 없습니다. 수정하시겠습니까?");

            madeEmpty5();

            getData5();
        }
        // 수정 버튼 - 기술경영융합대학
        private void button28_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "update 기술경영융합대학 set 학과 = '" + comboBox11.Text + "', 전공 = '" + textBox29.Text +
                  "', 전화번호 = '" + textBox28.Text + "', 이메일 = '" + textBox27.Text + "', 연구실 = '"
                  + textBox26.Text + "' where 이름 = '" + textBox30.Text + "'";

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("[이름]은 수정하실 수 없습니다. 수정하시겠습니까?");

            madeEmpty6();

            getData6();
        }
        // 수정 버튼 - 창의융합대학
        private void button33_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "update 창의융합대학 set 학과 = '" + comboBox13.Text + "', 전공 = '" + textBox34.Text +
                  "', 전화번호 = '" + textBox33.Text + "', 이메일 = '" + textBox32.Text + "', 연구실 = '"
                  + textBox31.Text + "' where 이름 = '" + textBox35.Text + "'";

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("[이름]은 수정하실 수 없습니다. 수정하시겠습니까?");

            madeEmpty7();

            getData7();
        }
        // 수정 버튼 - 미래융합대학
        private void button38_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "update 미래융합대학 set 학과 = '" + comboBox15.Text + "', 전공 = '" + textBox39.Text +
                  "', 전화번호 = '" + textBox38.Text + "', 이메일 = '" + textBox37.Text + "', 연구실 = '"
                  + textBox36.Text + "' where 이름 = '" + textBox40.Text + "'";

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("[이름]은 수정하실 수 없습니다. 수정하시겠습니까?");

            madeEmpty8();

            getData8();
        }



        // 검색 버튼 - 공과대학
        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (textBox1.Text != "")
            {
                sql = "select * from 공과대학 where 이름 = '" + textBox1.Text + "'";
            }
            else if (comboBox2.Text != "")
            {
                sql = "select * from 공과대학 where 학과 = '" + comboBox2.Text + "'";
            }
            else if (textBox2.Text != "")
            {
                sql = "select * from 공과대학 where 전공 = '" + textBox2.Text + "'";
            }
            else if (textBox3.Text != "")
            {
                sql = "select * from 공과대학 where 전화번호 = '" + textBox3.Text + "'";
            }
            else if (textBox4.Text != "")
            {
                sql = "select * from 공과대학 where 이메일 = '" + textBox4.Text + "'";
            }
            else if (textBox5.Text != "")
            {
                sql = "select * from 공과대학 where 연구실 = '" + textBox5.Text + "'";
            }

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();
            SQLiteDataReader sdr = inscmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sdr.Close();
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        // 검색 버튼 - 정보통신대학
        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (textBox11.Text != "")
            {
                sql = "select * from 정보통신대학 where 이름 = '" + textBox11.Text + "'";
            }
            else if (comboBox5.Text != "")
            {
                sql = "select * from 정보통신대학 where 학과 = '" + comboBox5.Text + "'";
            }
            else if (textBox12.Text != "")
            {
                sql = "select * from 정보통신대학 where 전공 = '" + textBox12.Text + "'";
            }
            else if (textBox13.Text != "")
            {
                sql = "select * from 정보통신대학 where 전화번호 = '" + textBox13.Text + "'";
            }
            else if (textBox14.Text != "")
            {
                sql = "select * from 정보통신대학 where 이메일 = '" + textBox14.Text + "'";
            }
            else if (textBox15.Text != "")
            {
                sql = "select * from 정보통신대학 where 연구실 = '" + textBox15.Text + "'";
            }

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();
            SQLiteDataReader sdr = inscmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sdr.Close();
            dataGridView2.DataSource = dt;
            conn.Close();
        }
        // 검색 버튼 - 에너지바이오대학
        private void button12_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (textBox16.Text != "")
            {
                sql = "select * from 에너지바이오대학 where 이름 = '" + textBox16.Text + "'";
            }
            else if (comboBox7.Text != "")
            {
                sql = "select * from 에너지바이오대학 where 학과 = '" + comboBox7.Text + "'";
            }
            else if (textBox17.Text != "")
            {
                sql = "select * from 에너지바이오대학 where 전공 = '" + textBox17.Text + "'";
            }
            else if (textBox18.Text != "")
            {
                sql = "select * from 에너지바이오대학 where 전화번호 = '" + textBox18.Text + "'";
            }
            else if (textBox19.Text != "")
            {
                sql = "select * from 에너지바이오대학 where 이메일 = '" + textBox19.Text + "'";
            }
            else if (textBox20.Text != "")
            {
                sql = "select * from 에너지바이오대학 where 연구실 = '" + textBox10.Text + "'";
            }

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();
            SQLiteDataReader sdr = inscmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sdr.Close();
            dataGridView3.DataSource = dt;
            conn.Close();
        }
        // 검색 버튼 - 조형대학
        private void button17_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (textBox21.Text != "")
            {
                sql = "select * from 조형대학 where 이름 = '" + textBox21.Text + "'";
            }
            else if (comboBox9.Text != "")
            {
                sql = "select * from 조형대학 where 학과 = '" + comboBox9.Text + "'";
            }
            else if (textBox22.Text != "")
            {
                sql = "select * from 조형대학 where 전공 = '" + textBox22.Text + "'";
            }
            else if (textBox23.Text != "")
            {
                sql = "select * from 조형대학 where 전화번호 = '" + textBox23.Text + "'";
            }
            else if (textBox24.Text != "")
            {
                sql = "select * from 조형대학 where 이메일 = '" + textBox24.Text + "'";
            }
            else if (textBox25.Text != "")
            {
                sql = "select * from 조형대학 where 연구실 = '" + textBox25.Text + "'";
            }

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();
            SQLiteDataReader sdr = inscmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sdr.Close();
            dataGridView4.DataSource = dt;
            conn.Close();
        }
        // 검색 버튼 - 인문사회대학
        private void button22_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (textBox26.Text != "")
            {
                sql = "select * from 인문사회대학 where 이름 = '" + textBox26.Text + "'";
            }
            else if (comboBox11.Text != "")
            {
                sql = "select * from 인문사회대학 where 학과 = '" + comboBox11.Text + "'";
            }
            else if (textBox27.Text != "")
            {
                sql = "select * from 인문사회대학 where 전공 = '" + textBox27.Text + "'";
            }
            else if (textBox28.Text != "")
            {
                sql = "select * from 인문사회대학 where 전화번호 = '" + textBox28.Text + "'";
            }
            else if (textBox29.Text != "")
            {
                sql = "select * from 인문사회대학 where 이메일 = '" + textBox29.Text + "'";
            }
            else if (textBox30.Text != "")
            {
                sql = "select * from 인문사회대학 where 연구실 = '" + textBox30.Text + "'";
            }

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();
            SQLiteDataReader sdr = inscmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sdr.Close();
            dataGridView5.DataSource = dt;
            conn.Close();
        }
        // 검색 버튼 - 기술경영융합대학
        private void button27_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (textBox31.Text != "")
            {
                sql = "select * from 기술경영융합대학 where 이름 = '" + textBox31.Text + "'";
            }
            else if (comboBox13.Text != "")
            {
                sql = "select * from 기술경영융합대학 where 학과 = '" + comboBox13.Text + "'";
            }
            else if (textBox32.Text != "")
            {
                sql = "select * from 기술경영융합대학 where 전공 = '" + textBox32.Text + "'";
            }
            else if (textBox33.Text != "")
            {
                sql = "select * from 기술경영융합대학 where 전화번호 = '" + textBox33.Text + "'";
            }
            else if (textBox34.Text != "")
            {
                sql = "select * from 기술경영융합대학 where 이메일 = '" + textBox34.Text + "'";
            }
            else if (textBox35.Text != "")
            {
                sql = "select * from 기술경영융합대학 where 연구실 = '" + textBox35.Text + "'";
            }

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();
            SQLiteDataReader sdr = inscmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sdr.Close();
            dataGridView6.DataSource = dt;
            conn.Close();
        }
        // 검색 버튼 - 창의융합대학
        private void button32_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (textBox36.Text != "")
            {
                sql = "select * from 창의융합대학 where 이름 = '" + textBox36.Text + "'";
            }
            else if (comboBox15.Text != "")
            {
                sql = "select * from 창의융합대학 where 학과 = '" + comboBox15.Text + "'";
            }
            else if (textBox37.Text != "")
            {
                sql = "select * from 창의융합대학 where 전공 = '" + textBox37.Text + "'";
            }
            else if (textBox38.Text != "")
            {
                sql = "select * from 창의융합대학 where 전화번호 = '" + textBox38.Text + "'";
            }
            else if (textBox39.Text != "")
            {
                sql = "select * from 창의융합대학 where 이메일 = '" + textBox39.Text + "'";
            }
            else if (textBox40.Text != "")
            {
                sql = "select * from 창의융합대학 where 연구실 = '" + textBox40.Text + "'";
            }

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();
            SQLiteDataReader sdr = inscmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sdr.Close();
            dataGridView7.DataSource = dt;
            conn.Close();
        }
        // 검색 버튼 - 미래융합대학
        private void button37_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (textBox1.Text != "")
            {
                sql = "select * from 미래융합대학 where 이름 = '" + textBox1.Text + "'";
            }
            else if (comboBox2.Text != "")
            {
                sql = "select * from 미래융합대학 where 학과 = '" + comboBox2.Text + "'";
            }
            else if (textBox2.Text != "")
            {
                sql = "select * from 미래융합대학 where 전공 = '" + textBox2.Text + "'";
            }
            else if (textBox3.Text != "")
            {
                sql = "select * from 미래융합대학 where 전화번호 = '" + textBox3.Text + "'";
            }
            else if (textBox4.Text != "")
            {
                sql = "select * from 미래융합대학 where 이메일 = '" + textBox4.Text + "'";
            }
            else if (textBox5.Text != "")
            {
                sql = "select * from 미래융합대학 where 연구실 = '" + textBox5.Text + "'";
            }

            SQLiteCommand inscmd = new SQLiteCommand(sql, conn);
            inscmd.ExecuteNonQuery();
            SQLiteDataReader sdr = inscmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sdr.Close();
            dataGridView8.DataSource = dt;
            conn.Close();
        }



        //전체 - 공과대학
        private void button5_Click(object sender, EventArgs e)
        {
            madeEmpty1();

            getData1();
        }
        //전체 - 정보통신대학
        private void button6_Click(object sender, EventArgs e)
        {
            madeEmpty2();

            getData2();
        }
        //전체 - 에너지바이오대학
        private void button11_Click(object sender, EventArgs e)
        {
            madeEmpty3();

            getData3();
        }
        //전체 - 조형대학
        private void button16_Click(object sender, EventArgs e)
        {
            madeEmpty4();

            getData4();
        }
        //전체 - 인문사회대학
        private void button21_Click(object sender, EventArgs e)
        {
            madeEmpty5();

            getData5();
        }
        //전체 - 기술경영융합대학
        private void button26_Click(object sender, EventArgs e)
        {
            madeEmpty6();

            getData6();
        }
        //전체 - 창의융합대학
        private void button31_Click(object sender, EventArgs e)
        {
            madeEmpty7();

            getData7();
        }
        //전체 - 미래융합대학
        private void button36_Click(object sender, EventArgs e)
        {
            madeEmpty8();

            getData8();
        }
    }
}
