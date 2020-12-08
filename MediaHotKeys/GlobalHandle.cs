using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MediaHotKeys
{
    /// <summary>
    /// Classe responsável por registrar a sequência de teclas desejadas no sistema operacional. 
    /// É necessário para os comandos funcionarem com o aplicativo sem foco.
    /// Quando as teclas forem pressionadas, o sistema operacional 'avisará' a aplicação.
    /// </summary>
    class GlobalHandle
    {
        public static class Constants
        {
            //Modificadores
            public const int NOMOD = 0x0000;
            public const int ALT = 0x0001;
            public const int CTRL = 0x0002;
            public const int SHIFT = 0x0004;
            public const int WIN = 0x0008;

            //Mensagem do windows para hotkeys
            public const int WM_HOTKEY_MSG_ID = 0x0312;
        }
        public enum AppCommand
        {
            APPCOMMAND_MEDIA_PAUSE = 47,
            APPCOMMAND_MEDIA_PLAY = 46,
            APPCOMMAND_MEDIA_PLAY_PAUSE = 14,
            APPCOMMAND_MEDIA_PREVIOUSTRACK = 12,
            APPCOMMAND_MEDIA_NEXTTRACK = 11,
        }
        public class Comando
        {
            int modifier;
            int key;
            IntPtr hWnd;
            bool registerSuccess;
            AppCommand comandoExecute;
            public int Modifier { get => modifier; set => modifier = value; }
            public int Key { get => key; set => key = value; }
            public IntPtr HWnd { get => hWnd; set => hWnd = value; }
            public int Id { get => modifier ^ key ^ hWnd.ToInt32(); }
            public bool RegisterSuccess { get => registerSuccess; set => registerSuccess = value; }
            internal AppCommand ComandoExecute { get => comandoExecute; set => comandoExecute = value; }
        }
        private List<Comando> comandos;
        private Form PvForm;

        internal List<Comando> Comandos { get => comandos; set => comandos = value; }

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public GlobalHandle(Form form)
        {
            comandos = new List<Comando>();
            PvForm = form;
        }

        /// <summary>
        /// Criação do objeto com o comando que será registrado posteriormente.
        /// </summary>
        /// <param name="modifier">Teclas de função: ALT, CTRL e SHIFT</param>
        /// <param name="key">Tecla que precisa ser pressionada junto com as teclas de função</param>
        /// <param name="form">Form como referências</param>
        public void AddComando(int modifier, Keys key, AppCommand comandoExecute)
        {
            Comandos.Add(new Comando { Modifier = modifier, Key = (int)key, HWnd = PvForm.Handle, ComandoExecute=comandoExecute });
        }

        /// <summary>
        /// Registrar o comando no Windows
        /// </summary>
        /// <returns></returns>
        public void Register()
        {
            foreach (var comando in Comandos)
            {
                comando.RegisterSuccess = RegisterHotKey(comando.HWnd, comando.Id, comando.Modifier, comando.Key);
            }
        }

        /// <summary>
        /// Remover o registro do comando no Windows
        /// </summary>
        /// <returns></returns>
        public void Unregiser()
        {
            foreach (var comando in Comandos)
            {
                if (comando.RegisterSuccess)
                    UnregisterHotKey(comando.HWnd, comando.Id);
            }
        }


    }
}
