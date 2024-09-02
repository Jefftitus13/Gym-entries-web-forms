using Microsoft.Ajax.Utilities;
using System;
using System.Configuration;
using System.Data.SqlClient;
using WebGrease.Activities;

namespace GymApp
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string memberID = Request.QueryString["member_id"];
                if(!string.IsNullOrEmpty(memberID))
                {
                    LoadMemberDetails(memberID);
                }
            }
        }

        //Loading Members
        private void LoadMemberDetails(string memberId)
        {
            string connStr = ConfigurationManager.ConnectionStrings["GymDBConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Members WHERE member_id = @member_id", conn);
                cmd.Parameters.AddWithValue("@member_id", memberId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblMemberIdValue.Text = reader["member_id"].ToString();
                    txtFirstName.Text = reader["First_name"].ToString();
                    txtLastName.Text = reader["Last_name"].ToString();
                    txtAge.Text = reader["Age"].ToString();
                    txtHeight.Text = reader["Height"].ToString();
                    txtWeight.Text = reader["Weight"].ToString();
                    ddlSex.Text = reader["Sex"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtEmail.Text = reader["Email_id"].ToString();
                    ddlExperienceLevel.SelectedValue = reader["ExperienceLevel"].ToString();
                    ddlWorkoutPreference.SelectedValue = reader["WorkoutPreference"].ToString();
                }
                reader.Close();
            }
        }
        
        //Saving Members
        protected void btnSave_Click(object sender, EventArgs e)
        {
            int memberId;
            if (int.TryParse(hfMemberId.Value, out memberId))
            {
                UpdateMemberDetails(txtFirstName.Text, txtLastName.Text, int.Parse(txtAge.Text),
                    int.Parse(txtHeight.Text), int.Parse(txtWeight.Text), ddlSex.SelectedValue,
                    txtPhone.Text, txtEmail.Text, ddlExperienceLevel.SelectedValue, ddlWorkoutPreference.SelectedValue);
            }
            else
            {
                AddMember(memberId, txtFirstName.Text, txtLastName.Text, int.Parse(txtAge.Text), int.Parse(txtHeight.Text),
                    int.Parse(txtWeight.Text), ddlSex.SelectedValue, txtPhone.Text, txtEmail.Text,
                    ddlExperienceLevel.SelectedValue, ddlWorkoutPreference.SelectedValue);
            }

            Response.Redirect("Default.aspx");
        }

        //Adding Members
        private void AddMember(int memberId, string firstName, string lastName, int age, int height, int weight, string sex, string phone, string email, string experienceLevel, string workoutPreference)
        {
            string connStr = ConfigurationManager.ConnectionStrings["GymDBConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Members (First_name, Last_name, Age, Height, Weight, Sex, Phone, Email_id, ExperienceLevel, WorkoutPreference)" + 
                               "VALUES (@FirstName, @LastName, @Age, @Height, @Weight, @Sex, @Phone, @Email, @ExperienceLevel, @WorkoutPreference)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@member_id", memberId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Height", height);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Sex", sex);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ExperienceLevel", experienceLevel);
                    cmd.Parameters.AddWithValue("@WorkoutPreference", workoutPreference);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void UpdateMemberDetails( string firstName, string lastName, int age, decimal height, decimal weight, string sex, string phone, string email, string experienceLevel, string workoutPreference)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GymDBConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Members SET First_name = @First_name, Last_name = @Last_name, Age = @Age, Height = @Height, Weight = @Weight, " +
                               "Sex = @Sex, Phone = @Phone, Email_id = @Email_id, Experience_level = @Experience_level, Workout_preference = @Workout_preference " +
                               "WHERE member_id = @member_id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@First_name", firstName);
                cmd.Parameters.AddWithValue("@Last_name", lastName);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Height", height);
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@Sex", sex);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email_id", email);
                cmd.Parameters.AddWithValue("@Experience_level", experienceLevel);
                cmd.Parameters.AddWithValue("@Workout_preference", workoutPreference);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}
