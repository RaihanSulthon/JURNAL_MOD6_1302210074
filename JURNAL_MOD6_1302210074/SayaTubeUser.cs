using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL_MOD6_1302210074
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        String username;

        public SayaTubeUser(String username)
        {
            Random random = new Random();
            this.id = random.Next(1, 99999);
            this.uploadedVideos= new List<SayaTubeVideo>();
            this.username = username;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total = total + uploadedVideos[i].GetPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo a)
        {
            uploadedVideos.Add(a);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine(" User :" + username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1)+ " Judul : " + uploadedVideos[i].GetTitle());
            }
        }
    }
}
