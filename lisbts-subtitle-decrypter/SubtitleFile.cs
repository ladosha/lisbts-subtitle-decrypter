using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lisbts_subtitle_decrypter
{
    class SubtitleFile
    {
        public Dictionary<string, string> subtitles = new Dictionary<string, string>();

        public bool editsSaved = true;
        public bool badLSB = false;

        public void Read_Lsbfile (string path)
        {
            badLSB = false;
            subtitles.Clear();
            FileStream stream = File.OpenRead(path);

            //header
            ushort keyValCount = ReadUShort(stream);
            uint value_offset = ReadUInt(stream);

            //key-lengths
            byte[] key_lengths = new byte[keyValCount];
            stream.Read(key_lengths, 0, keyValCount);

            //value-lengths
            List<ushort> value_lengths = new List<ushort>();
            for (int i = 0; i < keyValCount; i++)
            {
                value_lengths.Add(ReadUShort(stream));
            }

            //data
            byte[] raw_data = new byte[stream.Length - stream.Position];
            stream.Read(raw_data, 0, raw_data.Length);
            byte[] decrypted = XOR_Crypt(raw_data);

            int key_offset = 0;

            try
            {
                for (int i = 0; i < keyValCount; i++)
                {
                    byte[] key = new byte[key_lengths[i]];
                    byte[] value = new byte[value_lengths[i]];
                    Array.Copy(decrypted, key_offset, key, 0, key_lengths[i]);
                    key_offset += key_lengths[i];
                    Array.Copy(decrypted, value_offset, value, 0, value_lengths[i]);
                    value_offset += value_lengths[i];
                    subtitles.Add(Encoding.UTF8.GetString(key), Encoding.UTF8.GetString(value));
                }
            }
            catch
            {
                badLSB = true;
            }
            
            stream.Close();
        }

        public void Read_Txtfile (string path)
        {
            subtitles.Clear();
            string[] file = File.ReadAllLines(path);

            foreach(string line in file)
            {
                string[] keyval = line.Split(new char[] { '=' }, 2);
                try
                {
                    subtitles.Add(keyval[0], keyval[1]);
                }
                catch
                {

                }
            }
        }

        public void Write_Lsbfile (string dest_path)
        {
            MemoryStream memstream = new MemoryStream();
            List<byte> key_lengths = new List<byte>();
            List<ushort> value_lengths = new List<ushort>();
            string keys_concat = "";
            string values_concat = "";

            //header
            WriteUShort(memstream, Convert.ToUInt16(subtitles.Count));
            
            foreach(string key in subtitles.Keys)
            {
                keys_concat += key;
                values_concat += subtitles[key];
                key_lengths.Add((byte)Encoding.UTF8.GetBytes(key).Length);
                value_lengths.Add((ushort)Encoding.UTF8.GetBytes(subtitles[key]).Length);
            }
            WriteUInt(memstream, Convert.ToUInt32(keys_concat.Length));

            //key-lengths
            memstream.Write(key_lengths.ToArray(), 0, key_lengths.Count);

            //value-lengths
            foreach(ushort number in value_lengths)
            {
                WriteUShort(memstream, number);
            }

            //data
            byte[] data = Encoding.UTF8.GetBytes(keys_concat + values_concat);
            byte[] enc_data = XOR_Crypt(data);
            memstream.Write(enc_data, 0, enc_data.Length);

            dest_path = Path.ChangeExtension(dest_path, ".lsb");

            if (File.Exists(dest_path) && !File.Exists(dest_path + @".bkp"))
            {
                File.Copy(dest_path, dest_path + @".bkp", false);
            }

            byte[] file_bytes = memstream.ToArray();
            File.WriteAllBytes(dest_path, file_bytes);
            editsSaved = true;
        }

        public void Write_Txtfile (string dest_path, bool isUnix)
        {
            dest_path = Path.ChangeExtension(dest_path, ".txt");

            if (File.Exists (dest_path) && !File.Exists(dest_path + @".bkp"))
            {
                File.Copy(dest_path, dest_path + @".bkp", false);
            }

            StreamWriter stream = new StreamWriter(dest_path);

            if (isUnix)
            {
                stream.NewLine = "\n";
            }
            foreach(string key in subtitles.Keys)
            {
                stream.WriteLine(key + "=" + subtitles[key]);
            }
            stream.Close();
            editsSaved = true;
        }

        private uint ReadUInt(Stream stream)
        {
            var rawBytes = new byte[4];
            stream.Read(rawBytes, 0, 4);

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(rawBytes);
            }

            return BitConverter.ToUInt32(rawBytes, 0);
        }

        private ushort ReadUShort(Stream stream)
        {
            var rawBytes = new byte[2];
            stream.Read(rawBytes, 0, 2);

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(rawBytes);
            }

            return BitConverter.ToUInt16(rawBytes, 0);
        }

        private void WriteUInt(Stream stream, uint number)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            stream.Write(bytes, 0, bytes.Length);
        }

        private void WriteUShort(Stream stream, ushort number)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            stream.Write(bytes, 0, bytes.Length);
        }

        private byte[] s_key = new byte[] { 170, 17, 35, 52, 50, 33, 232, 59, 186, 18, 36, 53, 66, 49, 248, 91, 202, 19, 37, 54, 82, 161, 8, 123, 218, 20, 38, 55, 98, 193, 120, 155 };

        public byte[] XOR_Crypt(byte[] encoded)
        {
            byte[] content = new byte[encoded.Length];

            // simple xor encryption
            for (int i = 0; i < content.Length; i++)
            {
                content[i] = (byte)(encoded[i] ^ s_key[i % s_key.Length]);
            }

            return content;
        }
    }
}