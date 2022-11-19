namespace Blazor_Proyecto
{
    public class Config
    {
        public string CadenaConexion { get; set; }

        public Config(string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }
    }
}
