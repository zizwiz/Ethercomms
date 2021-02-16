using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ethercomms
{
    public partial class Form1
    {

        public void Decypher(string data)
        {
            // We need to invoke this as it is coming in from another thread in an ext class
            // If not then the controls will not update till the other thread has closed.


            if (!chkbx_hex.Checked) data = convert_all.convert.ConvertHexToString(data);

            Invoke(new Action(() =>
            {
                rchtxtbx_data.AppendText("\rReceived:\r");
                rchtxtbx_data.AppendText(data + "\r");
                rchtxtbx_data.ScrollToCaret();

            }));


            //this is where you decypher the incoming text and display it in your rich text box.
            //Usually I use a case statement to send to functions then make one file per function
            //that way the file will contain all the info it needs.
            
            /*
            switch (data.Substring(0,2))
            {
                case "01":
                    process01(data); //we now go off to decipher the data
                    break;
                case "02":
                    / process02(data); //we now go off to decipher the data
                    break;
                default:
                    //add a default catch
                    break;
            }
            */
        }
    }
}
