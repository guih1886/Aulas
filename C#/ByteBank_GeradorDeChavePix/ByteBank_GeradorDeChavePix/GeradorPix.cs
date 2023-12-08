namespace ByteBank_GeradorDeChavePix;

/// <summary>
/// Classe para gerar chaves pix usando o formato guid.
/// </summary>
public static class GeradorPix
{
    /// <summary>
    /// Metodo que retorna uma chave pix.
    /// </summary>
    /// <returns> Retorna uma chave pix no formato string </returns>
    public static string GetChavePix()
    {
        return Guid.NewGuid().ToString();
    }

    /// <summary>
    /// Metodo que retorna uma lista de chaves pix.
    /// </summary>
    /// <param name="numeroChaves">A quantidade de chaves geradas para a lista.</param>
    /// <returns>Retorna a lista de string de chave pix com a quantidadae informada.</returns>
    public static List<string> GetChavesPix(int numeroChaves)
    {
        if (numeroChaves <= 0)
        {
            return null;
        }
        else
        {
            var chaves = new List<string>();
            for (int i = 0; i < numeroChaves; i++)
            {
                chaves.Add(GetChavePix());
            }
            return chaves;
        }

    }
}
