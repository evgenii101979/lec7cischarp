
// узнать инфо по папкам. время созд и т.д.

// string path = "D:/учеба 2/WSC/lec7cischarp/lec7z1"; //поменять на обратный слеш
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();
// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

// метод хождения по папкам и просмотр данных папок

// void CatalogInfo(string path, string indent="")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         System.Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent +" ");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for (int i = 0; i < files.Length; i++)
//     {
//         System.Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }
// string path = @"D:\учеба 2\WSC\lec7cischarp\lec7z1";
// CatalogInfo(path);

// игра в пирамиды

// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     System.Console.WriteLine($"{with}>>{on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();

// задача 8 обход разных структур ((4-2)*(1+3))/10
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4     5    6    7    8    9   10   11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        System.Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();
