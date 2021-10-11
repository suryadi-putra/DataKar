using DataKar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataKar.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Karyawans.Any())
            {
                return;
            }

            var karyawans = new Karyawan[]
            {
                new Karyawan{Nama="Suro",Alamat="JL. Mandala",Telepon="9834798247",TLahir=DateTime.Parse("2021-12-02")},
                new Karyawan{Nama="ayo",Alamat="JL. Cipinang",Telepon="98374938247",TLahir=DateTime.Parse("2021-12-02")},
                new Karyawan{Nama="Suro",Alamat="JL. Garus",Telepon="094385903485",TLahir=DateTime.Parse("2021-12-02")},

            };
            foreach (var s in karyawans)
            {
                context.Karyawans.Add(s);
            }
            context.SaveChanges();
        }
    }
}
