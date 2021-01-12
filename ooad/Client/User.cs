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

        private DTO.USER userInfo;
    }
}
