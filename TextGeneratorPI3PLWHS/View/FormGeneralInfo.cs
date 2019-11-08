using MetroFramework;
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
using TextGeneratorPI3PLWHS.Model;

namespace TextGeneratorPI3PLWHS.View
{
    public partial class FormGeneralInfo : MetroFramework.Forms.MetroForm
    {
        Form1 form1;

        public FormGeneralInfo(Form1 _form1)
        {
            form1 = _form1;
            InitializeComponent();
        }

        private void TileSaveSite_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, "Are you sure to save this Site?", "Save Site", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GeneralInfoModel.SiteName = txtSiteName.Text;
                    GeneralInfoModel.Country = txtCountry.Text;
                    GeneralInfoModel.PlantCode = txtPlantCode.Text;
                    GeneralInfoModel.SLOC = txtSLOC.Text;
                    GeneralInfoModel.CityCode = txtCityCode.Text;
                    GeneralInfoModel.PartnerNumber = txtPartnerNumber.Text;
                    GeneralInfoModel.CompleteAddress = txtCompleteAddress.Text;
                    GeneralInfoModel.GLNILN = txtGLNILN.Text;
                    GeneralInfoModel.ServerHostURL = txtServerHost.Text;
                    GeneralInfoModel.AS2ID = txtAS2ID.Text;
                    GeneralInfoModel.SSLCertificate = checkSSLCertificate.Checked;
                    GeneralInfoController.GeneralInfoInsert();
                    GeneralInfoController.GeneralInfoLoad(form1);
                    Close();
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Message");
            }
        }

        private void TileCancelSite_Click(object sender, EventArgs e)
        {
            if(TileCancelSite.Text == "Cancel")
            {
                if (MetroMessageBox.Show(this, "Are you sure to cancel adding of Site?", "Cancel Site", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void TileEditSite_Click(object sender, EventArgs e)
        {
            if(TileEditSite.Text == "Save")
            {
                if (MetroMessageBox.Show(this, "Are you sure to edit this Site?", "Edit Site", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GeneralInfoModel.SiteName = txtSiteName.Text;
                    GeneralInfoModel.Country = txtCountry.Text;
                    GeneralInfoModel.PlantCode = txtPlantCode.Text;
                    GeneralInfoModel.SLOC = txtSLOC.Text;
                    GeneralInfoModel.CityCode = txtCityCode.Text;
                    GeneralInfoModel.PartnerNumber = txtPartnerNumber.Text;
                    GeneralInfoModel.CompleteAddress = txtCompleteAddress.Text;
                    GeneralInfoModel.GLNILN = txtGLNILN.Text;
                    GeneralInfoModel.ServerHostURL = txtServerHost.Text;
                    GeneralInfoModel.AS2ID = txtAS2ID.Text;
                    GeneralInfoModel.SSLCertificate = checkSSLCertificate.Checked;
                    GeneralInfoController.GeneralInfoUpdate();
                    GeneralInfoController.GeneralInfoLoad(form1);
                    Close();
                }
            }
            else
            {
                txtCountry.ReadOnly = false;
                txtPlantCode.ReadOnly = false;
                txtSLOC.ReadOnly = false;
                txtCityCode.ReadOnly = false;
                txtPartnerNumber.ReadOnly = false;
                txtCompleteAddress.ReadOnly = false;
                txtGLNILN.ReadOnly = false;
                txtServerHost.ReadOnly = false;
                txtAS2ID.ReadOnly = false;
                checkSSLCertificate.Enabled = true;
                TileDeleteSite.Enabled = false;
                TileEditSite.Text = "Save";
                TileCancelSite.Text = "Cancel";
            }
            
        }

        private void TileDeleteSite_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure to delete this Site?", "Delete Site", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralInfoModel.SiteName = txtSiteName.Text;
                GeneralInfoController.GeneralInfoDelete();
                GeneralInfoController.GeneralInfoLoad(form1);
                Close();
            }
        }
    }
}
