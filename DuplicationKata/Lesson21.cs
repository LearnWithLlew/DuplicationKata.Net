namespace DuplicationKata
{
    public class Lesson21 : Song
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
                        if (name.StartsWith("Sam"))
                        {
                            Sing("Say yeah! Say yo! Say " + name);
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