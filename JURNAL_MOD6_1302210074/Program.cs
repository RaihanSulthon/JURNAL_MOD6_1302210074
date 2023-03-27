// See https://aka.ms/new-console-template for more information
namespace JURNAL_MOD6_1302210074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("R34 Pure Sound");
            SayaTubeVideo video2 = new SayaTubeVideo("John Wick");
            SayaTubeVideo video3 = new SayaTubeVideo("Star Wars");
            SayaTubeVideo video4 = new SayaTubeVideo("Naruto");
            SayaTubeVideo video5 = new SayaTubeVideo("Mr.Bean");
            SayaTubeVideo video6 = new SayaTubeVideo("Lorax");
            SayaTubeVideo video7 = new SayaTubeVideo("Power Rangers");
            SayaTubeVideo video8 = new SayaTubeVideo("Tron");
            SayaTubeVideo video9 = new SayaTubeVideo("Indiana Jones");
            SayaTubeVideo video10 = new SayaTubeVideo("Sonic");

            SayaTubeUser user = new SayaTubeUser("Raihan Sulthon Y");
            video1.IncreasePlayCount(1);
            video2.IncreasePlayCount(100);
            video3.IncreasePlayCount(252);
            video4.IncreasePlayCount(64);
            video5.IncreasePlayCount(123);
            video6.IncreasePlayCount(34);
            video7.IncreasePlayCount(45);
            video8.IncreasePlayCount(23);
            video9.IncreasePlayCount(14);
            video10.IncreasePlayCount(18);

            user.AddVideo(video1);
            user.AddVideo(video2);
            user.AddVideo(video3);
            user.AddVideo(video4);
            user.AddVideo(video5);
            user.AddVideo(video6);
            user.AddVideo(video7);
            user.AddVideo(video8);
            user.AddVideo(video9);
            user.AddVideo(video10);

            video1.PrintVideoDetails();
            video2.PrintVideoDetails();
            video3.PrintVideoDetails();
            video4.PrintVideoDetails();
            video5.PrintVideoDetails();
            video6.PrintVideoDetails();
            video7.PrintVideoDetails();
            video8.PrintVideoDetails();
            video9.PrintVideoDetails();
            video10.PrintVideoDetails();

            user.PrintAllVideoPlayCount();
        }
    }
}