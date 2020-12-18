using System;
using System.Collections.Generic;
using System.Text;

namespace Temp
{
    class Members
    {
        private string memberName = "moso";
        private string jobTitle;
        private int salary = 20000;
        public string MemberName
        {
            get
            {
                return memberName;
            }
            set
            {
                memberName = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }


        private void SharePrivateInfo()
        {
            Console.WriteLine($"my salary is {salary}");
        }

        public void Introduce(bool isFriend)
        {
            if (isFriend)
                SharePrivateInfo();
            else
                Console.WriteLine($"Hi {MemberName}");
        }
    }
}
