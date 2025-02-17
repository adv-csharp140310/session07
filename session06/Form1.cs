using Microsoft.EntityFrameworkCore;
using session06.Generics;
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

        private void buttonStack_Click(object sender, EventArgs e)
        {
            //var stackInt = new MyStackInt();
            //stackInt.Push(1);
            //stackInt.Push(2);
            //stackInt.Push(3);
            //stackInt.Push(4);
            //MessageBox.Show(stackInt.Pop().ToString());
            //stackInt.Push(5);
            //MessageBox.Show(stackInt.Pop().ToString());


            //var stackString = new MyStackString();
            //stackString.Push("Samira");
            //stackString.Push("Akbar");
            //stackString.Push("Arshia");
            //stackString.Push("m.seyedmorad");
            //MessageBox.Show(stackString.Pop().ToString());
            //MessageBox.Show(stackString.Pop().ToString());

            var stack = new MyStackGenric<string>();
            stack.Push("Samira");
            stack.Push("Akbar");
            stack.Push("Arshia");
            stack.Push("m.seyedmorad");
            MessageBox.Show(stack.Pop().ToString());
            MessageBox.Show(stack.Pop().ToString());
        }
    }
}


