using session06.Model;
using session06.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session06.UI;
public partial class UsersForm : Form
{
    int currentPage = 1;
    int totalPages = 1;
    int pageSize = 3;

    public UsersForm()
    {
        InitializeComponent();
    }

    private void UsersForm_Load(object sender, EventArgs e)
    {
        groupBoxUsers.DesignForm(typeof(User));
        loadData();
    }

    private void groupBoxUsers_Enter(object sender, EventArgs e)
    {

    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        //Genrics
        //Unboxig
        var model = (User)groupBoxUsers.GetFormData(typeof(User));
        var ctx = new AppDbContext();
        ctx.Add(model);
        ctx.SaveChanges();
        loadData();
        groupBoxUsers.SetFormData(new User());
    }

    private void loadData()
    {
        var ctx = new AppDbContext();
        //Skip(10) -> 10 avalo ignore
        //Take(3) -> 3 ta ro begir
        //page 1 = skip(0 = pageSize * page - 1).take(pageSize)
        //page 2 = skip(3 = pageSize * page - 1).take(pageSize)
        //page 3 = skip(6 = pageSize * page - 1).take(pageSize)

        
        //imutable 
        var s = "test";
        s = "xyz";
        var x2 = s.Replace('y', 'N'); //s? xyz, s2:xNz
        s =  s.ToUpper();

        //mutable
        var x = 2;
        x = 4;

        //int total = 0;

        //if (comboBoxIsActive.SelectedItem == "All") {
        //    dataGridViewUsers.DataSource = ctx.Users
        //       .Skip(pageSize * (currentPage - 1))
        //       .Take(pageSize).ToList();
        //    total = ctx.Users.Count();
        //}
        //if(comboBoxIsActive.SelectedItem != "All") {
        //    var isActive = comboBoxIsActive.SelectedItem == "Active";
        //    dataGridViewUsers.DataSource = ctx.Users
        //        .Where(x => x.IsActive == isActive)
        //        .Skip(pageSize * (currentPage - 1))
        //        .Take(pageSize).ToList();

        //    total = ctx.Users.Where(x => x.IsActive == isActive).Count();
        //}

        //ctx.Blogs.Max(x => x.Id);

        //Linq imutable
        var query = ctx.Users.AsQueryable();        
        if (comboBoxIsActive.SelectedItem != "All")
        {
            var isActive = comboBoxIsActive.SelectedItem == "Active";
            query = query.Where(x => x.IsActive == isActive);
        }


        if (!string.IsNullOrWhiteSpace(textBoxName.Text))
        {
            //query = query.Where(x => x.FirstName == textBoxFirstName.Text);
            query = query.Where(x => x.FirstName.Contains(textBoxName.Text) || x.LastName.Contains(textBoxName.Text)); //like '%%'
        }
        //like 'f%'     - StartsWith
        //like '%f'     - EndsWith
        //like '%f%'    - Contains

        dataGridViewUsers.DataSource = query
                .Skip(pageSize * (currentPage - 1))
                .Take(pageSize).ToList();

        var total = query.Count();

        

        totalPages = Convert.ToInt32(Math.Ceiling(total / Convert.ToDecimal(pageSize)));

        labelPage.Text = $"{currentPage}/{totalPages}";
    }

    private void buttonFirst_Click(object sender, EventArgs e)
    {
        currentPage = 1;
        loadData();
    }

    private void buttonPrev_Click(object sender, EventArgs e)
    {
        if (currentPage > 1)
        {
            currentPage -= 1;
            loadData();
        }
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
        if (currentPage < totalPages)
        {
            currentPage += 1;
            loadData();
        }
    }

    private void buttonLast_Click(object sender, EventArgs e)
    {
        currentPage = totalPages;
        loadData();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        loadData();
    }
}
