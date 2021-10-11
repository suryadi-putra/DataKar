using DataKar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataKar.Interface
{
    public interface IKaryawanService
    {
        IEnumerable<Karyawan> GetAll();
    }
}
