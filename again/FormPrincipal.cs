using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace again
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            rjDropdownMenu1.IsMainMenu = true;
            rjDropdownMenu1.PrimaryColor = Color.PowderBlue;
            rjDropdownMenu1.MenuItemTextColor = Color.PowderBlue;
            rjDropdownMenu2.IsMainMenu = true;
            rjDropdownMenu2.PrimaryColor = Color.PowderBlue;
            rjDropdownMenu2.MenuItemTextColor = Color.PowderBlue;
            rjDropdownMenu3.IsMainMenu = true;
            rjDropdownMenu3.PrimaryColor = Color.PowderBlue;
            rjDropdownMenu3.MenuItemTextColor = Color.PowderBlue;
        }
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 在最大化之前的位置和大小
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location=Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Introduction>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(button2, button2.Width, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rjDropdownMenu2.Show(button3, button3.Width, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<KMP>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Tree>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rjDropdownMenu3.Show(button6, button6.Width, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<About>();
        }

        private void 顺序表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Sequence>();
        }

        private void 单链表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Link>();
        }

        private void 栈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Stack>();
        }

        private void 队列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Queue>();
        }

        private void 直接插入排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Insert>();
        }

        private void 折半插入排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Half>();
        }

        private void 希尔排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Hill>();
        }

        private void 冒泡排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Bubble>();
        }

        private void 快速排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Quick>();
        }

        private void 直接选择排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Select>();
        }

        private void 堆排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Heap>();
        }

        private void 归并排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Merge>();
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
