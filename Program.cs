void Executar()
{
    string arq = @"C:\Users\2025106346\Documents\arquivo.csv";
    string[] linhas = LerArquivo(arq);

    foreach(string linha in linhas)
    {
        //Console.WriteLine(linha);
        string[] colunas = linha.Split(';');
        //irá retornar as colunas

        //utilizando FOR mostrar colunas

        for(int i = 0;i < colunas.Length; i++)
        {
            Console.Write($"{colunas[i].PadRight(10)}");
        }
        Console.WriteLine();
    }
}


string[] LerArquivo(string arquivo)
{
    try
    {
        string[] linhas = File.ReadAllLines(arquivo);
        return linhas;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao ler arquivo| {ex.ToString()}");
        return new string[] { };
    }
}
Executar();