using System.Text;

namespace DuplicationKata
{
    public class Song
    {
        public StringBuilder song = new StringBuilder();
        public void Sing(string line)
        {
            song.Append(line + "\n");
        }
    }
}