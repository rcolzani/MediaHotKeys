using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaHotKeys
{
    public partial class Form1 : Form
    {
        private MediaHotKeys.GlobalHandle PvGlobalMediaHotkeys;

        public Form1()
        {
            InitializeComponent();
            PvGlobalMediaHotkeys = new MediaHotKeys.GlobalHandle(GlobalHandle.Constants.ALT + GlobalHandle.Constants.SHIFT, Keys.Right,  this);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
            }
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        /// <summary>
        /// Método que recebe as mensagens que o Windows dispara. 
        /// Como este método não recebe apenas os comandos que nossa aplicação registrou, é necessário validar se o comando recebido é o mesmo que foi registrado.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == MediaHotKeys.GlobalHandle.Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        /// <summary>
        /// Função que será executada a partir do atalho de teclas pressionado
        /// </summary>
        private void HandleHotkey()
        {
             Invoke(new MethodInvoker(() => SendMessage(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)((int)14 << 16))));
        }

        private const int WM_APPCOMMAND = 0x319;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PvGlobalMediaHotkeys.Unregiser())
                MessageBox.Show("Não foi possível registrar o atalho!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (PvGlobalMediaHotkeys.Register())
                Console.WriteLine("Atalho registrado.");
            else
                Console.WriteLine("Atalho falhou ao registrar.");

        }
    }
}
