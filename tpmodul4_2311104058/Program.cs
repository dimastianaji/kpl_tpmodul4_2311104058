using tpmodul4_2311104058;

class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();

        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();

        string hasil = kodePos.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos dari {kelurahan} adalah {hasil}");

        DoorMachine pintu = new DoorMachine(); // State awal: Terkunci

        pintu.BukaPintu(); // Mengubah state ke Terbuka
        pintu.KunciPintu(); // Mengubah state ke Terkunci
    }
}