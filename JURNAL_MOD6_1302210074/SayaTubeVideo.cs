using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL_MOD6_1302210074
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Random random = new Random();
            this.id = random.Next(1, 99999);
            if(title == null)
            {
                throw new NullReferenceException("Judul tidak boleh kosong");
            }
            if(title.Length >= 200)
            {
                throw new Exception("Maximal panjang dari teks adalah 200");
                this.title = title;
            }
            this.playCount = 0;
            this.title = title;
        }

        public void IncreasePlayCount(int x)
        {
          Debug.Assert(x >= 0);
          this.playCount = this.playCount + x;
        }

        public int GetPlayCount()
        {
            return this.playCount;
        }

        public String GetTitle()
        {
            return this.title;
        }

        public void PrintVideoDetails()
        {
                Console.WriteLine("ID :" + this.id);
                Console.WriteLine("Title :" + this.title);
                Console.WriteLine("PlayCount : " + playCount);
        }
    }
}
