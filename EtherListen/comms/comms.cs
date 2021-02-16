using System;
using System.Text;
using System.Text.RegularExpressions;
using convert_all;

namespace EtherListen
{
    public partial class Form1
    {
        // this is where you can add replies to various sends.
        private byte[] decypher(byte[] data)
        {
            string ascii_string = "";

            if (!chkbx_hex.Checked)
                ascii_string = Encoding.ASCII.GetString(data, 0, data.Length);

            //get byte[]  convert to string and remove spaces.
            string sdata = Regex.Replace(convert.ByteArrayToHexString(data), @"\s+", "");

            Invoke(new Action(() =>
            {
                rchtxtbx_data.AppendText("Received:" + sdata + "\r");

                if (!chkbx_hex.Checked)
                   rchtxtbx_data.AppendText("ASCII Received:" + ascii_string + "\r");


                rchtxtbx_data.ScrollToCaret();
            }));





            
            //we now send the hex string back as array.
            return convert.HexStringToByteArray(sdata);
        }



    }
}
