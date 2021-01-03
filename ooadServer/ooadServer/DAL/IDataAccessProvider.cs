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
    }
}
