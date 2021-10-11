using DataKar.Data;
using DataKar.Interface;
using DataKar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataKar.Service
{
    public class KaryawanService : IKaryawanService
    {
        private AppDbContext _db;

        public KaryawanService(AppDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Karyawan> GetAll()
        {
            return _db.Karyawans.OrderBy(s => s.Nama);
        }
    }
}
