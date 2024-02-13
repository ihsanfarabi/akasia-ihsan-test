public int perkalianSederhana(int j, int k)
{
    int hasil = 0;
    while (j>0)
    {
        hasil += k; // variable "total" diganti dengan variable "hasil"
        j--;
    }
    return hasil;
}