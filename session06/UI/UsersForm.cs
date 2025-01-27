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
    public UsersForm()
    {
        InitializeComponent();
    }

    private void UsersForm_Load(object sender, EventArgs e)
    {
        groupBoxUsers.DesignForm(typeof(User));
    }

    private void groupBoxUsers_Enter(object sender, EventArgs e)
    {

    }
}
