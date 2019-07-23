using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AxZKFPEngXControl;

namespace SIGAE.AsistenciaComedor
{
    public partial class FrmAsistencia : Form
    {
        #region Variables de foto
        private bool DispositivoPresente = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice Camara = null;
        #endregion

        #region Variables de huella
        private AxZKFPEngX Lector = new AxZKFPEngX();
        private bool Check;
        #endregion


        public FrmAsistencia()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Controls.Add(Lector);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var nuevo = new FrmNuevo();
            nuevo.Show();
        }
    }
}
