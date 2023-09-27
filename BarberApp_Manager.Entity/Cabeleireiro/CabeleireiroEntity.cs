namespace BarberApp_Manager.Entity.Cabeleireiro
{
    public class CabeleireiroEntity : DefaultKeyIntIdEntity
    {
        public string? Nome { get; set; }
        public string? Permisao { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public bool IsAceitandoServico { get; set; }
        public DateTime? LimiteServicoInicio { get; set; }
        public DateTime? LimiteServicoFim { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
    }
}
