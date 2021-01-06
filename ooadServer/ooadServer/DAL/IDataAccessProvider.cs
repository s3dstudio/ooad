using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ooadServer.DTO;

namespace ooadServer.DAL
{
    public interface IDataAccessProvider
    {
        void AddKHDTRecord(KHDT khdt);
        void UpdateKHDTRecord(KHDT khdt);
        void DeleteKHDTRecord(string id);
        KHDT GetKHDTSingleRecord(string id);
        List<KHDT> GetKHDTRecords();

        void AddKHOARecord(KHOA khoa);
        void UpdateKHOARecord(KHOA khoa);
        void DeleteKHOARecord(string id);
        KHOA GetKHOASingleRecord(string id);
        List<KHOA> GetKHOARecords();

        void AddCHUYENNGANHRecord(CHUYENNGANH cn);
        void UpdateCHUYENNGANHRecord(CHUYENNGANH cn);
        void DeleteCHUYENNGANHRecord(string id);
        CHUYENNGANH GetCHUYENNGANHSingleRecord(string id);
        List<CHUYENNGANH> GetCHUYENNGANHRecords();

        void AddGIANGVIENRecord(GIANGVIEN GV);
        void UpdateGIANGVIENRecord(GIANGVIEN GV);
        void DeleteGIANGVIENRecord(string id);
        GIANGVIEN GetGIANGVIENSingleRecord(string id);
        List<GIANGVIEN> GetGIANGVIENRecords();

        void AddCHUCNANGRecord(CHUCNANG cn);
        void UpdateCHUCNANGRecord(CHUCNANG cn);
        void DeleteCHUCNANGRecord(string id);
        CHUCNANG GetCHUCNANGSingleRecord(string id);
        List<CHUCNANG> GetCHUCNANGRecords();

        void AddHEDAOTAORecord(HEDAOTAO hdt);
        void UpdateHEDAOTAORecord(HEDAOTAO hdt);
        void DeleteHEDAOTAORecord(string id);
        HEDAOTAO GetHEDAOTAOSingleRecord(string id);
        List<HEDAOTAO> GetHEDAOTAORecords();

        void AddHOCPHANRecord(HOCPHAN hp);
        void UpdateHOCPHANRecord(HOCPHAN hp);
        void DeleteHOCPHANRecord(string id);
        HOCPHAN GetHOCPHANSingleRecord(string id);
        List<HOCPHAN> GetHOCPHANRecords();

        void AddHOPDONGRecord(HOPDONG hd);
        void UpdateHOPDONGRecord(HOPDONG hd);
        void DeleteHOPDONGRecord(string id);
        HOPDONG GetHOPDONGSingleRecord(string id);
        List<HOPDONG> GetHOPDONGRecords();

        void AddLOAIHINHDTRecord(LOAIHINHDT lhdt);
        void UpdateLOAIHINHDTRecord(LOAIHINHDT lhdt);
        void DeleteLOAIHINHDTRecord(string id);
        LOAIHINHDT GetLOAIHINHDTSingleRecord(string id);
        List<LOAIHINHDT> GetLOAIHINHDTRecords();

        void AddNHOMLOPRecord(NHOMLOP nl);
        void UpdateNHOMLOPRecord(NHOMLOP nl);
        void DeleteNHOMLOPRecord(string id);
        NHOMLOP GetNHOMLOPSingleRecord(string id);
        List<NHOMLOP> GetNHOMLOPRecords();


    }
}
