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

        // KHDT
        public void AddKHDTRecord(KHDT k)
        {
            _context.khdt.Add(k);
            _context.SaveChanges();
        }

        public void UpdateKHDTRecord(KHDT k)
        {
            _context.khdt.Update(k);
            _context.SaveChanges();
        }

        public void DeleteKHDTRecord(string id)
        {
            Console.WriteLine(id);
            var entity = _context.khdt.FirstOrDefault(t => Convert.ToString(t.idkhdt) == id);
            _context.khdt.Remove(entity);
            _context.SaveChanges();
            Console.WriteLine(id);
        }

        public KHDT GetKHDTSingleRecord(string id)
        {
            return _context.khdt.FirstOrDefault(t => Convert.ToString(t.idkhdt) == id);
        }

        public List<KHDT> GetKHDTRecords()
        {
            return _context.khdt.ToList();
        }

        // KHOA
        public List<KHOA> GetKHOARecords()
        {
            return _context.khoa.ToList();
        }

        public void AddKHOARecord(KHOA khoa)
        {
            _context.khoa.Add(khoa);
            _context.SaveChanges();
        }

        public void UpdateKHOARecord(KHOA khoa)
        {
            _context.khoa.Update(khoa);
            _context.SaveChanges();
        }

        public void DeleteKHOARecord(string id)
        {
            Console.WriteLine(id);
            var entity = _context.khoa.FirstOrDefault(t => Convert.ToString(t.idkhoa) == id);
            _context.khoa.Remove(entity);
            _context.SaveChanges();
            Console.WriteLine(id);
        }

        public KHOA GetKHOASingleRecord(string id)
        {
            return _context.khoa.FirstOrDefault(t => Convert.ToString(t.idkhoa) == id);
        }

        // CHUYEN NGANH
        public void AddCHUYENNGANHRecord(CHUYENNGANH cn)
        {
            _context.chuyennganh.Add(cn);
            _context.SaveChanges();
        }
        public void UpdateCHUYENNGANHRecord(CHUYENNGANH cn)
        {
            _context.chuyennganh.Update(cn);
            _context.SaveChanges();
        }
        public void DeleteCHUYENNGANHRecord(string id)
        {
            var entity = _context.chuyennganh.FirstOrDefault(t => Convert.ToString(t.idchuyennganh) == id);
            _context.chuyennganh.Remove(entity);
            _context.SaveChanges();
        }
        public CHUYENNGANH GetCHUYENNGANHSingleRecord(string id)
        {
            return _context.chuyennganh.FirstOrDefault(t => Convert.ToString(t.idchuyennganh) == id);
        }
        public List<CHUYENNGANH> GetCHUYENNGANHRecords()
        {
            return _context.chuyennganh.ToList();
        }

        // GIANG VIEN
        public void AddGIANGVIENRecord(GIANGVIEN GV)
        {
            _context.giangvien.Add(GV);
            _context.SaveChanges();
        }
        public void UpdateGIANGVIENRecord(GIANGVIEN GV)
        {
            _context.giangvien.Update(GV);
            _context.SaveChanges();
        }
        public void DeleteGIANGVIENRecord(string id)
        {
            var entity = _context.giangvien.FirstOrDefault(t => Convert.ToString(t.idgiangvien) == id);
            _context.giangvien.Remove(entity);
            _context.SaveChanges();
        }
        public GIANGVIEN GetGIANGVIENSingleRecord(string id)
        {
            return _context.giangvien.FirstOrDefault(t => Convert.ToString(t.idgiangvien) == id);
        }
        public List<GIANGVIEN> GetGIANGVIENRecords()
        {
            return _context.giangvien.ToList();
        }

        // CHUC NANG
        public void AddCHUCNANGRecord(CHUCNANG cn)
        {
            _context.chucnang.Add(cn);
            _context.SaveChanges();
        }

        public void UpdateCHUCNANGRecord(CHUCNANG cn)
        {
            _context.chucnang.Update(cn);
            _context.SaveChanges();
        }

        public void DeleteCHUCNANGRecord(string id)
        {
            var entity = _context.chucnang.FirstOrDefault(t => Convert.ToString(t.idchucnang) == id);
            _context.chucnang.Remove(entity);
            _context.SaveChanges();
        }

        public CHUCNANG GetCHUCNANGSingleRecord(string id)
        {
            return _context.chucnang.FirstOrDefault(t => Convert.ToString(t.idchucnang) == id);
        }

        public List<CHUCNANG> GetCHUCNANGRecords()
        {
            return _context.chucnang.ToList();
        }

        //HE DAO TAO
        public void AddHEDAOTAORecord(HEDAOTAO hdt)
        {
            _context.hedaotao.Add(hdt);
            _context.SaveChanges();
        }

        public void UpdateHEDAOTAORecord(HEDAOTAO hdt)
        {
            _context.hedaotao.Update(hdt);
            _context.SaveChanges();
        }

        public void DeleteHEDAOTAORecord(string id)
        {
            var entity = _context.hedaotao.FirstOrDefault(t => Convert.ToString(t.idhedaotao) == id);
            _context.hedaotao.Remove(entity);
            _context.SaveChanges();
        }

        public HEDAOTAO GetHEDAOTAOSingleRecord(string id)
        {
            return _context.hedaotao.FirstOrDefault(t => Convert.ToString(t.idhedaotao) == id);
        }

        public List<HEDAOTAO> GetHEDAOTAORecords()
        {
            return _context.hedaotao.ToList();
        }

        // HOC PHAN
        public void AddHOCPHANRecord(HOCPHAN hp)
        {
            _context.hocphan.Add(hp);
            _context.SaveChanges();
        }

        public void UpdateHOCPHANRecord(HOCPHAN hp)
        {
            _context.hocphan.Update(hp);
            _context.SaveChanges();
        }

        public void DeleteHOCPHANRecord(string id)
        {
            var entity = _context.hocphan.FirstOrDefault(t => Convert.ToString(t.idhocphan) == id);
            _context.hocphan.Remove(entity);
            _context.SaveChanges();
        }

        public HOCPHAN GetHOCPHANSingleRecord(string id)
        {
            return _context.hocphan.FirstOrDefault(t => Convert.ToString(t.idhocphan) == id);
        }

        public List<HOCPHAN> GetHOCPHANRecords()
        {
            return _context.hocphan.ToList();
        }
        
        // HOP DONG
        public void AddHOPDONGRecord(HOPDONG hd)
        {
            _context.hopdong.Add(hd);
            _context.SaveChanges();
        }

        public void UpdateHOPDONGRecord(HOPDONG hd)
        {
            _context.hopdong.Update(hd);
            _context.SaveChanges();
        }

        public void DeleteHOPDONGRecord(string id)
        {
            var entity = _context.hopdong.FirstOrDefault(t => Convert.ToString(t.idhopdong) == id);
            _context.hopdong.Remove(entity);
            _context.SaveChanges();
        }

        public HOPDONG GetHOPDONGSingleRecord(string id)
        {
            return _context.hopdong.FirstOrDefault(t => Convert.ToString(t.idhopdong) == id);
        }

        public List<HOPDONG> GetHOPDONGRecords()
        {
            return _context.hopdong.ToList();
        }

        // LOAI HINH DAO TAO
        public void AddLOAIHINHDTRecord(LOAIHINHDT lhdt)
        {
            _context.loaihinhdt.Add(lhdt);
            _context.SaveChanges();
        }

        public void UpdateLOAIHINHDTRecord(LOAIHINHDT lhdt)
        {
            _context.loaihinhdt.Update(lhdt);
            _context.SaveChanges();
        }

        public void DeleteLOAIHINHDTRecord(string id)
        {
            var entity = _context.loaihinhdt.FirstOrDefault(t => Convert.ToString(t.idlhdt) == id);
            _context.loaihinhdt.Remove(entity);
            _context.SaveChanges();
        }

        public LOAIHINHDT GetLOAIHINHDTSingleRecord(string id)
        {
            return _context.loaihinhdt.FirstOrDefault(t => Convert.ToString(t.idlhdt) == id);
        }

        public List<LOAIHINHDT> GetLOAIHINHDTRecords()
        {
            return _context.loaihinhdt.ToList();
        }

        public void AddNHOMLOPRecord(NHOMLOP nl)
        {
            _context.nhomlop.Add(nl);
            _context.SaveChanges();
        }

        public void UpdateNHOMLOPRecord(NHOMLOP nl)
        {
            _context.nhomlop.Update(nl);
            _context.SaveChanges();
        }

        public void DeleteNHOMLOPRecord(string id)
        {
            var entity = _context.nhomlop.FirstOrDefault(t => Convert.ToString(t.idnhomlop) == id);
            _context.nhomlop.Remove(entity);
            _context.SaveChanges();
        }

        public NHOMLOP GetNHOMLOPSingleRecord(string id)
        {
            return _context.nhomlop.FirstOrDefault(t => Convert.ToString(t.idnhomlop) == id);
        }

        public List<NHOMLOP> GetNHOMLOPRecords()
        {
            return _context.nhomlop.ToList();
        }
    }
}
