using AForge.Video;
using AForge.Video.DirectShow;
using AxZKFPEngXControl;
using SIGAE.Common.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIGAE.AsistenciaComedor
{
    public partial class FrmNuevo : Form
    {
        #region Variables de foto
        private bool DispositivoPresente = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice Camara = null;
        #endregion

        #region Variables de huella
        private readonly AxZKFPEngX Lector = new AxZKFPEngX();
        private bool Check;
        #endregion

        public FrmNuevo()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        private void FrmNuevo_Load(object sender, EventArgs e)
        {
            Controls.Add(Lector);
            InicializarLector();
        }

        #region Huellas

        private void InicializarLector()
        {
            try
            {
                Lector.OnImageReceived += Lector_OnImageReceived;
                Lector.OnFeatureInfo += Lector_OnFeatureInfo;
                //zkFprint.OnFingerTouching 
                //zkFprint.OnFingerLeaving
                Lector.OnEnroll += Lector_OnEnroll; ;

                if (Lector.InitEngine() == 0)
                {
                    Lector.FPEngineVersion = "9";
                    Lector.EnrollCount = 3;
                    lblStatus.Text += " " + Lector.SensorSN + " Count: " + Lector.SensorCount.ToString() + " Index: " + Lector.SensorIndex.ToString();
                    lblTemplate.Text = "Lector de huellas conectado";
                }

            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error de inicialización de dispositivo: " + ex.Message;
            }
        }

        private void Lector_OnEnroll(object sender, IZKFPEngXEvents_OnEnrollEvent e)
        {
                if (e.actionResult)
                {
                    string template = Lector.EncodeTemplate1(e.aTemplate);
                    lblTemplate.Text = template;
                    lblInstrucciones.Text = "Registro correcto. Puede verificar ahora";
                    btnCaptHuella.Enabled = false;
                    btnReconocer.Enabled = true;
                }
                else
                {
                    lblInstrucciones.Text = "Error, por favor, registre de nuevo.";

                }
        }

        private void Lector_OnFeatureInfo(object sender, IZKFPEngXEvents_OnFeatureInfoEvent e)
        {
            String strTemp = string.Empty;
            if (Lector.EnrollIndex != 1)
            {
                if (Lector.IsRegister)
                {
                    if (Lector.EnrollIndex - 1 > 0)
                    {
                        int eindex = Lector.EnrollIndex - 1;
                        strTemp = "Por favor, intente de nuevo ..." + eindex;
                    }
                }
            }
            lblInstrucciones.Text = strTemp;
        }

        private void Lector_OnImageReceived(object sender, IZKFPEngXEvents_OnImageReceivedEvent e)
        {
            Graphics g = pctBoxHuella.CreateGraphics();
            Bitmap bmp = new Bitmap(pctBoxHuella.Width, pctBoxHuella.Height);
            g = Graphics.FromImage(bmp);
            int dc = g.GetHdc().ToInt32();
            Lector.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height);
            g.Dispose();
            pctBoxHuella.Image = bmp;
        }

        private void Lector_OnCapture(object sender, IZKFPEngXEvents_OnCaptureEvent e)
        {
            string plantilla = Lector.EncodeTemplate1(e.aTemplate);

            //Este método contrasta lo recibido por el lector, con el string almacenado en lblTemplate
            if (Lector.VerFingerFromStr(ref plantilla, lblTemplate.Text, false, ref Check))
            {
                MessageBox.Show("Verificado");
            }
            else
                MessageBox.Show("No Verificado");
        }

        private void BtnCaptHuella_Click(object sender, EventArgs e)
        {
            Lector.CancelEnroll();
            Lector.EnrollCount = 3;
            Lector.BeginEnroll();
            lblInstrucciones.Text = "Por favor, ingrese su huella.";
        }

        private void BtnReconocer_Click(object sender, EventArgs e)
        {
            if (Lector.IsRegister)
            {
                Lector.CancelEnroll();
            }
            Lector.OnCapture += Lector_OnCapture;
            Lector.BeginCapture();
            lblStatus.Text = "Por favor, ponga su dedo en el lector.";
        }
        #endregion

        #region Toma de foto
        public void CargarDispCmbBox(FilterInfoCollection Dispositivos)
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            for (int i = 0; i < Dispositivos.Count; i++)
            {
                cmbBoxCamaras.Items.Add(Dispositivos[0].Name.ToString());
                cmbBoxCamaras.Text = cmbBoxCamaras.Items[0].ToString();
            }
        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                DispositivoPresente = false;
            }
            else
            {
                DispositivoPresente = true;
                CargarDispCmbBox(DispositivoDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(Camara == null))
            {
                if (Camara.IsRunning)
                {
                    Camara.SignalToStop();
                    Camara = null;
                }
            }
        }

        public void VideoNuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pctBoxFoto.Image = Imagen;
        }

        private void BtnCapturar_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Text == "Capturar")
            {
                if (DispositivoPresente)
                {
                    Camara = new VideoCaptureDevice(DispositivoDeVideo[cmbBoxCamaras.SelectedIndex].MonikerString);
                    Camara.NewFrame += new NewFrameEventHandler(VideoNuevoFrame);
                    Camara.Start();
                    lblStatus.Text = "Captura de fotografía";
                    btnCapturar.Text = "Detener";
                    cmbBoxCamaras.Enabled = false;
                    lblTemplate.Text = DispositivoDeVideo[cmbBoxCamaras.SelectedIndex].Name.ToString();
                }
                else
                {
                    lblStatus.Text = "Error: No se encuentra el dispositivo";
                }
            }
            else
            {
                if (Camara.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    lblStatus.Text = "Dispositivo detenido";
                    btnCapturar.Text = "Iniciar";
                    cmbBoxCamaras.Enabled = true;
                }
            }
        }

        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona
            {
                Cedula = txtBoxCedula.Text,
                Nombre = txtBoxNombre.Text,
                Apellido1 = txtBoxApe1.Text,
                Apellido2 = txtBoxApe2.Text
            };

            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
