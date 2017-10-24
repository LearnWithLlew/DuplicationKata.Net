namespace DuplicationKata
{
    public class Lesson31 : Song
    {
        public void SingSong(int style, string[] names)
        {
            switch (style)
            {
                case 1:
                    foreach (var name in names)
                    {
                        if (name.StartsWith("L"))
                        {
                            Sing("Hip Hip Horray! For " + name);
                        }
                        else
                        {
                            Sing("Hello " + name + ", it's nice to meet you.");
                        }
                    }
                    break;
                case 2:
                    foreach (var name in names)
                    {
                        if (name.Contains("a"))
                        {
                            Sing(name.ToUpperInvariant() + "! Yay " + name + "!");
                        }
                        else
                        {
                            Sing("Hello " + name + ", it's nice to meet you.");
                        }
                    }
                    break;
                case 3:
                    foreach (var name in names)
                    {
                        Sing("Hello " + name + ", it's nice to meet you.");
                    }
                    break;
            }
        }
    }
}