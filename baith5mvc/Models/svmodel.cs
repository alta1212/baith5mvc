using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace baith5mvc.Models
{
    public class svmodel
    {
        datacn cn = new datacn();
        public List<sv> getsv()
        {
            DataTable dt = cn.laydulieu("select * from sv");
            List<sv> li = new List<sv>();
            foreach (DataRow dr in dt.Rows)
            {
                sv sinhvien = new sv();
                sinhvien.msv = dr[0].ToString();
                sinhvien.hoten = dr[1].ToString();
                sinhvien.ngaysinh = DateTime.Parse(dr[2].ToString());
                sinhvien.quequan = dr[3].ToString();
                sinhvien.toan =float.Parse(dr[4].ToString()) ;
                sinhvien.ly = float.Parse(dr[5].ToString());
                sinhvien.hoa = float.Parse(dr[6].ToString());       
                li.Add(sinhvien);
            }
            return li;
        }    
    }
}