using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPart2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        DialogResult d;

        public Form1()
        {
            InitializeComponent();
            // Conneciton to the database 
            connect();
        }

        private void connect()
        {
            string connectionString;
            connectionString = "Data Source=uranium.cs.umanitoba.ca;Initial Catalog=cs3380;User=patelhs;Password=7935131;";
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception es)
            {
                Console.WriteLine("Database didn't connect properly");
            }
        }

        private void run()
        {
            string retiveSchoolBoard = "SELECT s.boardNo, s.phoneNo, s.boardName, s.email, a.address_PostalCode, a.address_Country, a.address_StreetNo, a.address_StreetName, a.address_City, a.address_Province FROM schoolBoard s JOIN address a ON s.addressId = a.address_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(retiveSchoolBoard,conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            run();
        }

        private void GetAllInfo_Click(object sender, EventArgs e)
        {
            string retiveSchoolBoard = "Select  m.First_Name, m.Middle_Name, m.Last_Name, s.student_ID, s.email,s.grade, s.DOB, s.age, s.gender, s.admissionDate, s.admissionGrade FROM students s JOIN members m ON s.member_Id = m.Member_ID ORDER BY m.First_Name";

            SqlDataAdapter adapter = new SqlDataAdapter(retiveSchoolBoard, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Query1Info_Click(object sender, EventArgs e)
        {  
            d = MessageBox.Show("This SQL query employs the JOIN keyword to combine data from two tables, namely \"schoolBoard\" and \"address\". The SELECT clause is used to extract specific columns from each table, such as \"boardNo\", \"phoneNo\", \"boardName\", and \"email\" from the \"schoolBoard\" table, and \"address_PostalCode\", \"address_Country\", \"address_StreetNo\", \"address_StreetName\", \"address_City\", and \"address_Province\" from the \"address\" table. The JOIN condition is specified using the \"addressId\" in the \"schoolBoard\" table and the \"address_ID\" in the \"address\" table. This ensures that only matching rows from each table are combined into a single row in the resulting table. Overall, this SQL query effectively leverages the JOIN functionality to integrate relevant data from multiple tables into a coherent and useful result set.", "Query 1", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }

        private void Query2Info_Click(object sender, EventArgs e)
        {
            d = MessageBox.Show("This SQL query performs a join operation between two tables, \"students\" and \"members\", based on their shared member ID. The result set is tailored by selecting specific columns, namely, the first name, middle name, and last name of the member, and the student ID, email, grade, date of birth, age, gender, admission date, and admission grade of the student. The final output is ordered by the first name of the member in an ascending manner. This query effectively consolidates pertinent information from multiple tables and presents it in a logical and structured manner.", "Query 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Query3Info_Click(object sender, EventArgs e)
        {
            d = MessageBox.Show("This SQL query performs a JOIN operation on two tables, \"students\" and \"members\", to extract specific columns based on a common column. The query applies a filter condition on the results to retrieve records of students with age greater than 12. Furthermore, the query uses the GROUP BY clause to group the retrieved data based on certain columns. The query then orders the resulting data by two columns, namely age and admissionGrade. The selected columns include member's first, middle, and last name, student's ID, email, grade, date of birth, age, gender, admission date, and admission grade. In essence, this query provides comprehensive information about students aged above 12 years and sorts them based on their age and admission grade.", "Query 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Query4Info_Click(object sender, EventArgs e)
        {
            d = MessageBox.Show("This SQL query employs a series of join operations to retrieve data from multiple tables based on specified conditions. Specifically, it begins by joining the dependent and members tables, followed by a join operation with the Non-Academic table to extract the name, date of birth, gender, and salary of all dependents whose associated Non-Academic member's salary is less than or equal to 35,000. The query then employs the UNION operator to append another set of results, which are obtained by retrieving the name, date of birth, gender, and pay scale of dependents whose associated teacher member's pay scale is less than or equal to 55,000. The query is designed to provide a clear and concise summary of relevant information extracted from multiple tables.", "Query 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Query5Info_Click(object sender, EventArgs e)
        {
            d = MessageBox.Show("This SQL query selects the first name, middle name, and last name of members who are also teachers, along with their school email and the faculty they belong to. It does this by joining three tables: teacher, members, and department. The teacher table has a foreign key reference to the members table and department table, which allows us to connect the information from these tables using a join operation. Specifically, the query matches the member ID from the teacher table with the Member ID from the members table and the department ID from the teacher table with the department number from the department table. This query is relevant to computer science because it demonstrates how SQL can be used to extract information from multiple tables using join operations.", "Query 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Query6Info_Click(object sender, EventArgs e)
        {
            d = MessageBox.Show("Query 6 Info", "Query 6 Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "Select m.First_Name AS 'First Name', m.Middle_Name AS 'Middle Name', m.Last_Name AS 'Last Name', s.student_ID, s.email,s.grade, s.DOB, s.age, s.gender, s.admissionDate, s.admissionGrade FROM students s JOIN members m ON s.member_Id = m.Member_ID WHERE age > 12 GROUP BY m.First_Name, m.Middle_Name, m.Last_Name, s.student_ID, s.email,s.grade, s.DOB, s.age, s.gender, s.admissionDate, s.admissionGrade ORDER BY s.age, s.admissionGrade";

            SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "SELECT d.name AS 'name',d.DOB AS 'Date of Birth',d.gender AS 'Sex', N.Salary FROM dependent d JOIN members m ON m.Member_ID = d.memberId JOIN[Non-Academic] N ON N.Member_ID = m.Member_ID WHERE N.Salary <= 35000 Union SELECT d.name AS 'name',d.DOB AS 'Date of Birth',d.gender AS 'Sex', t.Pay_Scale FROM dependent d JOIN members m ON m.Member_ID = d.memberId JOIN teacher t ON t.Member_ID = m.Member_ID WHERE t.Pay_Scale <= 55000";

            SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void QueryInfo_Click(object sender, EventArgs e)
        {
            d = MessageBox.Show("Query 1: \n\nSELECT s.boardNo, s.phoneNo, s.boardName, s.email, a.address_PostalCode, a.address_Country, a.address_StreetNo, a.address_StreetName, a.address_City, a.address_Province \nFROM schoolBoard s \nJOIN address a ON s.addressId = a.address_ID\n\nQuery 2: \n\nSelect  m.First_Name, m.Middle_Name, m.Last_Name, s.student_ID, s.email,s.grade, s.DOB, s.age, s.gender, s.admissionDate, s.admissionGrade \nFROM students s \nJOIN members m ON s.member_Id = m.Member_ID \nORDER BY m.First_Name\n\nQuery 3: \n\nSelect m.First_Name AS 'First Name', m.Middle_Name AS 'Middle Name', m.Last_Name AS 'Last Name', s.student_ID, s.email,s.grade, s.DOB, s.age, s.gender, s.admissionDate, s.admissionGrade \nFROM students s \nJOIN members m ON s.member_Id = m.Member_ID \nWHERE age > 12 \nGROUP BY m.First_Name, m.Middle_Name, m.Last_Name, s.student_ID, s.email,s.grade, s.DOB, s.age, s.gender, s.admissionDate, s.admissionGrade ORDER BY s.age, s.admissionGrade\n\nQuery 4: \n\nSELECT d.name AS 'name',d.DOB AS 'Date of Birth',d.gender AS 'Sex', N.Salary \nFROM dependent d \nJOIN members m ON m.Member_ID = d.memberId \nJOIN[Non-Academic] N ON N.Member_ID = m.Member_ID \nWHERE N.Salary <= 35000 \n\nUnion \n\nSELECT d.name AS 'name',d.DOB AS 'Date of Birth',d.gender AS 'Sex', t.Pay_Scale \nFROM dependent d \nJOIN members m ON m.Member_ID = d.memberId \nJOIN teacher t ON t.Member_ID = m.Member_ID \nWHERE t.Pay_Scale <= 55000\n\nQuery 5: \n\nSELECT m.First_Name, m.Middle_Name, m.Last_Name, t.school_email, d.Faculty\nFROM teacher t\nJOIN members m ON t.member_Id = m.Member_ID\nJOIN department d ON t.department_Id = d.department_Num");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string str = "SELECT m.First_Name, m.Middle_Name, m.Last_Name, t.school_email, d.Faculty FROM teacher t JOIN members m ON t.member_Id = m.Member_ID JOIN department d ON t.department_Id = d.department_Num";

            SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
