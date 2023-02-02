using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Drawing;
using Pen = System.Drawing.Pen;
using Color = System.Drawing.Color;
using System.Security.RightsManagement;

namespace dental_form.UI.Forms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        // variable change border color
        bool focusU = false;
        bool focusP= false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void picClose_EditValueChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_UserName_Click(object sender, EventArgs e)
        {
            focusU = true;
            this.Refresh();
            if (txt_UserName.Text=="Username...")
            {
                txt_UserName.Text = "";
            }
        }

        private void txt_UserName_Leave(object sender, EventArgs e)
        {
            focusU = false;
            this.Refresh();
            if (txt_UserName.Text=="")
            {
                txt_UserName.Text = "Username...";
            }
          
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            focusP = true;
            this.Refresh();
            if (txt_Password.Text=="Password...")
            {
                txt_Password.Text = "";
                txt_Password.Properties.PasswordChar = '●';
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            focusP = false;
            this.Refresh();
            if (txt_Password.Text=="")
            {
                txt_Password.Text = "Password...";
                txt_Password.Properties.PasswordChar = '\0' ;
            }
        }

        // ---- start change border color when focus -----
        private void txt_UserName_Paint(object sender, PaintEventArgs e)
        {
            if (focusU)
            {
                RectangleF rec = e.Graphics.ClipBounds;
                rec.Inflate(-1, -1);
                e.Graphics.DrawRectangle(Pens.Red,
                    rec.Left,
                    rec.Top,
                    rec.Width,
                    rec.Height);
            }
            else
            {
                RectangleF rec = e.Graphics.ClipBounds;
                rec.Inflate(-1, -1);
                e.Graphics.DrawRectangle(Pens.DimGray,
                    rec.Left,
                    rec.Top,
                    rec.Width,
                    rec.Height);
            }
        }

        private void txt_Password_Paint(object sender, PaintEventArgs e)
        {
            if (focusP)
            {
                RectangleF rec = e.Graphics.ClipBounds;
                rec.Inflate(-1, -1);
                e.Graphics.DrawRectangle(Pens.Red,
                    rec.Left,
                    rec.Top,
                    rec.Width,
                    rec.Height);
            }
            else
            {

                RectangleF rec = e.Graphics.ClipBounds;
                rec.Inflate(-1, -1);
                e.Graphics.DrawRectangle(Pens.DimGray,
                    rec.Left,
                    rec.Top,
                    rec.Width,
                    rec.Height);
            }
        }

        private void btn_Login_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Login.BackColor= Color.FromArgb(1, 129, 201);
        }
        // ---- end change border color when focus -----
    }
}