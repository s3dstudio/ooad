using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ooadServer.DTO;

namespace ooadServer.DAL
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddKHDTRecord(KHDT k)
        {
            _context.kHDT.Add(k);
            _context.SaveChanges();
        }

        public void UpdateKHDTRecord(KHDT k)
        {
            _context.kHDT.Update(k);
            _context.SaveChanges();
        }

        public void DeleteKHDTRecord(string id)
        {
            Console.WriteLine(id);
            var entity = _context.kHDT.FirstOrDefault(t => Convert.ToString(t.idkhdt) == id);
            _context.kHDT.Remove(entity);
            _context.SaveChanges();
            Console.WriteLine(id);
        }

        public KHDT GetKHDTSingleRecord(string id)
        {
            return _context.kHDT.FirstOrDefault(t => Convert.ToString(t.idkhdt) == id);
        }

        public List<KHDT> GetKHDTRecords()
        {
            return _context.kHDT.ToList();
        }

        public void AddkhdtRecord(KHDT k)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatekhdtRecord(KHDT k)
        {
            throw new System.NotImplementedException();
        }

        public void DeletekhdtRecord(string id)
        {
            throw new System.NotImplementedException();
        }

        public KHDT GetkhdtSingleRecord(string id)
        {
            throw new System.NotImplementedException();
        }

        public List<KHDT> GetkhdtRecords()
        {
            throw new System.NotImplementedException();
        }
    }
}
