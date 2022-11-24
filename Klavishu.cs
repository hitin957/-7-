using System.Diagnostics;

class Klavishu
{
    public int posit_down = 0;
    public int posit_up = 2;
}
class strela
{
    public void strel()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("->");
        int posit = 0;
        do
        {
            string[] array = new string[] { "->", "  " };
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                posit--;
                if (posit < 0)
                {
                    posit = 0;
                }
                Console.SetCursorPosition(0, posit + 1);
                Console.WriteLine(array[1]);
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                posit++;
                if(posit > 3)
                {
                    posit=3;
                }
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
                Console.SetCursorPosition(0, posit - 1);
                Console.WriteLine(array[1]);
            }
            if (key.Key == ConsoleKey.Enter && posit == 0)
            {
                Console.Clear();
                break;
            }

        } while (true);
    }
    public void strel_paper()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("->");
        int posit = 0;
        Files f = new Files();
        do
        {
            string[] array = new string[] { "->", "  " };
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                posit--;
                if (posit < 0)
                {
                    posit = 0;
                }
                Console.SetCursorPosition(0, posit + 1);
                Console.WriteLine(array[1]);
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                posit++;
                if(posit > 3)
                {
                    posit = 3;
                }
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
                Console.SetCursorPosition(0, posit - 1);
                Console.WriteLine(array[1]);
            }
            if (key.Key == ConsoleKey.Enter && posit == 0)
            {
                Console.Clear();
                f.Exseli();
            }
            if (key.Key == ConsoleKey.Enter && posit == 1)
            {
                Console.Clear();
                f.Power();
            }
            if (key.Key == ConsoleKey.Enter && posit == 2)
            {
                Console.Clear();
                f.TxT();
            }
            if (key.Key == ConsoleKey.Enter && posit == 3)
            {
                Console.Clear();
                f.Word();
            }
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                break;
            }
        } while (true);
    }
}
class Files
{
    public void Exseli()
    {
        if (File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel\\Статистика.xlsx") && File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel\\Таблица.xlsx") && File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel\\Цифры.xlsx"))
        {
            string[] allFiles = Directory.GetFiles("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel");
            foreach (string filePath in allFiles)
            {
                Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel"));
            }
        }
        else
        {
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel\\Статистика.xlsx");
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel\\Таблица.xlsx");
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel\\Цифры.xlsx");
            string[] allFiles = Directory.GetFiles("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel");
            foreach (string filePath in allFiles)
            {
                Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel"));
            }
        }
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("->");
        int posit = 0;
        do
        {
            string[] array = new string[] { "->", "  " };
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                posit--;
                if (posit < 0)
                {
                    posit = 0;
                }
                Console.SetCursorPosition(0, posit + 1);
                Console.WriteLine(array[1]);
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                posit++;
                if(posit > 2)
                {
                    posit = 2;
                }
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
                Console.SetCursorPosition(0, posit - 1);
                Console.WriteLine(array[1]);
            }
            if (key.Key == ConsoleKey.Enter && posit == 0)
            {
                Process.Start(new ProcessStartInfo {FileName= "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel\\Статистика.xlsx",UseShellExecute=true});
            }
            if (key.Key == ConsoleKey.Enter && posit == 1)
            {
                Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel\\Таблица.xlsx", UseShellExecute = true });
            }
            if (key.Key == ConsoleKey.Enter && posit == 2)
            {
                Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel\\Цифры.xlsx", UseShellExecute = true });
            }
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        } while (true);
    }
    public void Power ()
    {
        if (File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point\\Доклад.pptx") && File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point\\Презентация.pptx") && File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point\\Реферат.pptx"))
        {
            string[] allFiles = Directory.GetFiles("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point");
            foreach (string filePath in allFiles)
            {
                Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point"));
            }
        }
        else
        {
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point\\Доклад.pptx");
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point\\Презентация.pptx");
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point\\Реферат.pptx");
            string[] allFiles = Directory.GetFiles("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point");
            foreach (string filePath in allFiles)
            {
                Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point"));
            }
        }
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("->");
        int posit = 0;
        do
        {
            string[] array = new string[] { "->", "  " };
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                posit--;
                if (posit < 0)
                {
                    posit = 0;
                }
                Console.SetCursorPosition(0, posit + 1);
                Console.WriteLine(array[1]);
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                posit++;
                if (posit > 2)
                {
                    posit = 2;
                }
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
                Console.SetCursorPosition(0, posit - 1);
                Console.WriteLine(array[1]);
            }
            if (key.Key == ConsoleKey.Enter && posit == 0)
            {
                Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point\\Доклад.pptx", UseShellExecute = true });
            }
            if (key.Key == ConsoleKey.Enter && posit == 1)
            {
                Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point\\Презентация.pptx", UseShellExecute = true });
            }
            if (key.Key == ConsoleKey.Enter && posit == 2)
            {
                Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Power.Point\\Реферат.pptx", UseShellExecute = true });
            }
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        } while (true);
    }
    public void TxT()
    {
        if (File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT\\Блокнот.txt") && File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT\\Заметки.txt") && File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT\\Текст.txt"))
        {
            string[] allFiles = Directory.GetFiles("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT");
            foreach (string filePath in allFiles)
            {
                Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT"));
            }
        }
        else
        {
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT\\Блокнот.txt");
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT\\Заметки.txt");
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT\\Текст.txt");
            string[] allFiles = Directory.GetFiles("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT");
            foreach (string filePath in allFiles)
            {
                Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT"));
            }
        }
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("->");
        int posit = 0;
        do
        {
            string[] array = new string[] { "->", "  " };
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                posit--;
                if (posit < 0)
                {
                    posit = 0;
                }
                Console.SetCursorPosition(0, posit + 1);
                Console.WriteLine(array[1]);
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                posit++;
                if (posit > 2)
                {
                    posit = 2;
                }
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
                Console.SetCursorPosition(0, posit - 1);
                Console.WriteLine(array[1]);
            }
            if (key.Key == ConsoleKey.Enter && posit == 0)
            {
                Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT\\Блокнот.txt", UseShellExecute = true });
            }
            if (key.Key == ConsoleKey.Enter && posit == 1)
            {
                Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT\\Заметки.txt", UseShellExecute = true });
            }
            if (key.Key == ConsoleKey.Enter && posit == 2)
            {
                Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\TxT\\Текст.txt", UseShellExecute = true });
            }
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        } while (true);
    }
    public void Word()
    {
        if (File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word\\Макросы.docx") && File.Exists("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word\\Отчёт.docx"))
        {
            string[] allFiles = Directory.GetFiles("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word");
            foreach (string filePath in allFiles)
            {
                Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word"));
            }
        }
        else
        {
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word\\Макросы.docx");
            File.Create("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word\\Отчёт.docx");
            string[] allFiles = Directory.GetFiles("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word");
            foreach (string filePath in allFiles)
            {
                Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word"));
            }
        }
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("->");
        int posit = 0;
        do
        {
            string[] array = new string[] { "->", "  " };
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                posit--;
                if (posit < 0)
                {
                    posit = 0;
                }
                Console.SetCursorPosition(0, posit + 1);
                Console.WriteLine(array[1]);
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                posit++;
                if (posit > 1)
                {
                    posit = 1;
                }
                Console.SetCursorPosition(0, posit);
                Console.WriteLine(array[0]);
                Console.SetCursorPosition(0, posit - 1);
                Console.WriteLine(array[1]);
            }
            if (key.Key == ConsoleKey.Enter && posit == 0)
            {
                Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word\\Макросы.docx", UseShellExecute = true });
            }
            if (key.Key == ConsoleKey.Enter && posit == 1)
            {
                Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Word\\Отчёт.docx", UseShellExecute = true });
            }
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        } while (true);
    }
}