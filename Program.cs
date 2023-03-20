// See https://aka.ms/new-console-template for more information

internal class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void addNewData_1302213038(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData_1302213038()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] 
                + ", yang tersimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

class MainProgram
{
    static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.addNewData_1302213038(13);
        data.addNewData_1302213038(02);
        data.addNewData_1302213038(21);
        data.printAllData_1302213038();
    }
}