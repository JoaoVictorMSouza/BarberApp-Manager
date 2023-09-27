namespace BarberApp_Manager.Entity.Cabeleireiro
{
    public class CabeleireiroAutenticadoEntity
    {
        public CabeleireiroAutenticadoEntity(int id, string nome, string role)
        {
            if (id < 1)
                throw new ArgumentException($"'{nameof(id)}' não pode menor que 1.", nameof(id));

            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException($"'{nameof(nome)}' não pode ser nulo nem vazio.", nameof(nome));

            if (string.IsNullOrEmpty(role))
                throw new ArgumentException($"'{nameof(role)}' não pode ser nulo nem vazio.", nameof(role));

            this.Id = id;
            this.Nome = nome;
            this.Role = role;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Role { get; set; }
    }
}
