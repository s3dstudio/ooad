using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooad.Client
{
    class User
    {
        private static volatile User instance;

        static object key = new object();

        public static User Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new User();
                    }
                }
                return instance;
            }
        }
        private User()
        {
        }

        public string userName { get; set; }
        public string passWord { get; set; }
        public int idrole { get; set; }
        public int iduser { get; set; }
        public string hoten { get; set; }
        public string ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string hktt { get; set; }
        public int idkhoa { get; set; }


        
    }
}
