using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGeneratorPI3PLWHS.Model;

namespace TextGeneratorPI3PLWHS.Controller
{
    class GeneralInfoController
    {
        public static void GeneralInfoLoad(Form1 _form1)
        {
            LINQTextGeneratorDataContext linqTextGen = new LINQTextGeneratorDataContext();
            _form1.GridGeneralInfo.DataSource = linqTextGen.GeneralInfos;
        }
        
        public static void GeneralInfoInsert()
        {
            LINQTextGeneratorDataContext linqTextGen = new LINQTextGeneratorDataContext();
            linqTextGen.GeneralInfo_Insert(
                GeneralInfoModel.SiteName,
                GeneralInfoModel.Country,
                GeneralInfoModel.PlantCode,
                GeneralInfoModel.SLOC,
                GeneralInfoModel.CityCode,
                GeneralInfoModel.PartnerNumber,
                GeneralInfoModel.CompleteAddress,
                GeneralInfoModel.GLNILN,
                GeneralInfoModel.ServerHostURL,
                GeneralInfoModel.AS2ID,
                GeneralInfoModel.SSLCertificate
                );
            linqTextGen.SubmitChanges();
        }

        public static void GeneralInfoUpdate()
        {
            LINQTextGeneratorDataContext linqTextGen = new LINQTextGeneratorDataContext();
            linqTextGen.GeneralInfo_Update(
                GeneralInfoModel.SiteName,
                GeneralInfoModel.Country,
                GeneralInfoModel.PlantCode,
                GeneralInfoModel.SLOC,
                GeneralInfoModel.CityCode,
                GeneralInfoModel.PartnerNumber,
                GeneralInfoModel.CompleteAddress,
                GeneralInfoModel.GLNILN,
                GeneralInfoModel.ServerHostURL,
                GeneralInfoModel.AS2ID,
                GeneralInfoModel.SSLCertificate
                );
            linqTextGen.SubmitChanges();
        }

        public static void GeneralInfoDelete()
        {
            LINQTextGeneratorDataContext linqTextGen = new LINQTextGeneratorDataContext();
            GeneralInfo generalInfo = linqTextGen.GeneralInfos.SingleOrDefault(S => S.SiteName == GeneralInfoModel.SiteName);
            linqTextGen.GeneralInfos.DeleteOnSubmit(generalInfo);
            linqTextGen.SubmitChanges();
        }
    }
}
