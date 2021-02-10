using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MediaHotKeys.GlobalHandle;

namespace MediaHotKeys
{
    public partial class Form1 : Form
    {
        private MediaHotKeys.GlobalHandle PvGlobalMediaHotkeys;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
            PvGlobalMediaHotkeys = new MediaHotKeys.GlobalHandle(this);
            PvGlobalMediaHotkeys.AddComando(GlobalHandle.Constants.ALT + GlobalHandle.Constants.SHIFT, Keys.Right, AppCommand.APPCOMMAND_MEDIA_NEXTTRACK);
            PvGlobalMediaHotkeys.AddComando(GlobalHandle.Constants.ALT + GlobalHandle.Constants.SHIFT, Keys.Left, AppCommand.APPCOMMAND_MEDIA_PREVIOUSTRACK);
            PvGlobalMediaHotkeys.AddComando(GlobalHandle.Constants.ALT + GlobalHandle.Constants.SHIFT, Keys.Down, AppCommand.APPCOMMAND_MEDIA_PLAY_PAUSE);
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
            {
                foreach (var LcComando in PvGlobalMediaHotkeys.Comandos)
                {
                    if (m.WParam.ToInt32() == LcComando.Id)
                    {
                        HandleHotkey(LcComando.ComandoExecute);
                    }
                }

                
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Função que será executada a partir do atalho de teclas pressionado
        /// </summary>
        private void HandleHotkey(AppCommand appCommand)
        {
            try
            {
                Invoke(new MethodInvoker(() => SendMessage(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)((int)appCommand << 16))));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private const int WM_APPCOMMAND = 0x319;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PvGlobalMediaHotkeys.Unregiser();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PvGlobalMediaHotkeys.Register();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/rcolzani");
        }
    }
}
