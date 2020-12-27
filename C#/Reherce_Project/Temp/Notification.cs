using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;

        public void showNotofocation()
        {
            throw new NotImplementedException();
        }

        string INotifications.getDate()
        {
            throw new NotImplementedException();
        }
    }
}
