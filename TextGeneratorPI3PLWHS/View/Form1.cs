using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextGeneratorPI3PLWHS.Controller;
using TextGeneratorPI3PLWHS.View;

namespace TextGeneratorPI3PLWHS
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        FormGeneralInfo formGeneralInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GeneralInfoController.GeneralInfoLoad(this);
        }

        private void TileAddSite_Click(object sender, EventArgs e)
        {
            formGeneralInfo = new FormGeneralInfo(this);
            formGeneralInfo.Show();
        }

        private void TileViewSite_Click(object sender, EventArgs e)
        {
            
            formGeneralInfo = new FormGeneralInfo(this);

            //display data to components
            formGeneralInfo.txtSiteName.Text = GridGeneralInfo.SelectedRows[0].Cells[0].Value.ToString();
            formGeneralInfo.txtCountry.Text = GridGeneralInfo.SelectedRows[0].Cells[1].Value.ToString();
            formGeneralInfo.txtPlantCode.Text = GridGeneralInfo.SelectedRows[0].Cells[2].Value.ToString();
            formGeneralInfo.txtSLOC.Text = GridGeneralInfo.SelectedRows[0].Cells[3].Value.ToString();
            formGeneralInfo.txtCityCode.Text = GridGeneralInfo.SelectedRows[0].Cells[4].Value.ToString();
            formGeneralInfo.txtPartnerNumber.Text = GridGeneralInfo.SelectedRows[0].Cells[5].Value.ToString();
            formGeneralInfo.txtCompleteAddress.Text = GridGeneralInfo.SelectedRows[0].Cells[6].Value.ToString();
            formGeneralInfo.txtGLNILN.Text = GridGeneralInfo.SelectedRows[0].Cells[7].Value.ToString();
            formGeneralInfo.txtServerHost.Text = GridGeneralInfo.SelectedRows[0].Cells[8].Value.ToString();
            formGeneralInfo.txtAS2ID.Text = GridGeneralInfo.SelectedRows[0].Cells[9].Value.ToString();
            formGeneralInfo.checkSSLCertificate.Checked = Convert.ToBoolean(GridGeneralInfo.SelectedRows[0].Cells[10].Value);

            //modify components
            formGeneralInfo.txtSiteName.ReadOnly = true;
            formGeneralInfo.txtCountry.ReadOnly = true;
            formGeneralInfo.txtPlantCode.ReadOnly = true;
            formGeneralInfo.txtSLOC.ReadOnly = true;
            formGeneralInfo.txtCityCode.ReadOnly = true;
            formGeneralInfo.txtPartnerNumber.ReadOnly = true;
            formGeneralInfo.txtCompleteAddress.ReadOnly = true;
            formGeneralInfo.txtGLNILN.ReadOnly = true;
            formGeneralInfo.txtServerHost.ReadOnly = true;
            formGeneralInfo.txtAS2ID.ReadOnly = true;
            formGeneralInfo.checkSSLCertificate.Enabled = false;
            formGeneralInfo.TileSaveSite.Visible = false;
            formGeneralInfo.TileEditSite.Visible = true;
            formGeneralInfo.TileDeleteSite.Visible = true;
            formGeneralInfo.TileCancelSite.Text = "Close";

            formGeneralInfo.Show();
        }
        
    }
}
