using Microsoft.EntityFrameworkCore;
using session06.Model;
using session06.UI;
using System.Reflection;

namespace session06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddBlog_Click(object sender, EventArgs e)
        {
            using var ctx = new AppDbContext();

            // Master/Detail
            //blog 

            var user = new User
            {
                FirstName = "Masoumeh",
                LastName = "Seyedmorad",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Email = "N/A",
                IsActive = true,
                Password = "N/A",
                Username = "Seyedmorad"
            };
            ctx.Add(user);


            ctx.Add(new Blog
            {
                Title = "Salam Donya!",
                Content = "....",
                //UserId = user.Id
                Author = user
            });


            ctx.SaveChanges();
            MessageBox.Show("Done!");
        }

        private void buttonUserManagment_Click(object sender, EventArgs e)
        {
            var frm = new UsersForm();
            frm.ShowDialog();
        }
    }
}
