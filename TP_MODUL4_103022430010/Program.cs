public class KodePos
{
    public Dictionary<string, string> kelPos = new Dictionary<string, string>()
    {
        {"Batununggal", "40266"},
        {"Kujangsari",  "40287"},
        {"Mengger",     "40267"},
        {"Wates",       "40256"},
        {"Cijaura",     "40287"},
        {"Jatisari",    "40286"},
        {"Margasari",   "40286"},
        {"Sekejati",    "40286"},
        {"Kebonwaru",   "40272"},
        {"Maleer",      "40274"}
    };

    public string getKodePos(string kelurahan)
    {
        if (kelPos.ContainsKey(kelurahan))
        {
            return kelPos[kelurahan];
        }
        return "Data tidak ditemukan";
    }
}
class Program
{
    static void Main(string[] args)
    {
        KodePos kodePosObj = new KodePos();

        Console.WriteLine("Masukkan Nama Kelurahan:");

        Console.Write("Input Kelurahan: ");
        string kelPilihan = Console.ReadLine();

        string hasil = kodePosObj.getKodePos(kelPilihan);

        Console.WriteLine("Hasil Pencarian:");
        Console.WriteLine("Kelurahan: " + kelPilihan);
        Console.WriteLine("Kode Pos : " + hasil);
    }
}