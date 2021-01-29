using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEPROM_Decoder_Tool
{
    class EEPROM_decoder
    {
        public EEPROM_decoder()
        {

        }
        private List<string> List_DecodeOutputStr = new List<string>();
        public bool OpenHex(string path)
        {
            List_DecodeOutputStr.Clear();
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(path);
            
            while ((line = file.ReadLine()) != null)
            {
                if (!Decode_process(line))
                    return false;
            }
            file.Close();
            return true;
        }
        public bool SaveHex(string path)
        {
            try
            {
                StreamWriter file;
                if (!File.Exists(path))
                {
                    file = File.CreateText(path);
                }
                else
                {
                    file = new System.IO.StreamWriter(path);
                }

                foreach (string str in List_DecodeOutputStr)
                {
                    file.WriteLine(str);
                }
                file.Close();
                
            }
            catch(Exception xx)
            {
                return false;
            }
            return true;
        }
        private bool Decode_process(string input)
        {
            int datalen, offset, type;
            string data;
            try
            {
                datalen = Convert.ToInt32(input.Substring(1, 2), 16);
                offset = Convert.ToInt32(input.Substring(3, 4), 16);
                type = Convert.ToInt32(input.Substring(7, 2), 16);
                data = input.Substring(9, datalen * 2);
            }
            catch (Exception xx)
            {
                return false;
            }

            if(type==0)
            {
                List_DecodeOutputStr.Add(offset.ToString("X").PadLeft(4, '0') + ": ");
                for (int idx=0;idx<data.Length;idx+=2)
                {
                    List_DecodeOutputStr[List_DecodeOutputStr.Count-1] += data.Substring(idx, 2) + " ";
                }
            }
            return true;
            
        }
    }
}
