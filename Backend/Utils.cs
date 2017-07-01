using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Backend
{
    public static class Utils
    {
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }


        public static DataGridViewRow getSelectedRow(DataGridView dataGrid)
        {
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
                return row;

            return null;
        }

        public static String getIsoConfigDateTime()
        {
            DateTime nuevaFecha = getConfigDateTime();
            return nuevaFecha.ToString("yyyy-MM-ddT23:59:59Z");
        }

        public static DateTime getConfigDateTime()
        {
            String fecha_hoy = ConfigurationManager.AppSettings["fecha_hoy"];
            return DateTime.ParseExact(fecha_hoy, "yyyy-MM-dd", null);
         
        }


        
    }
}
