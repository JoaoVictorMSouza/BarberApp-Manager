namespace BarberApp_Manager.Entity
{
    public abstract class DefaultKeyIntIdEntity : DefaultEntity<int>
    {
    }

    public abstract class DefaultEntity<TypeId> : DefaultEntityNoKey
    {
        public TypeId Id { get; set; }
    }

    public abstract class DefaultEntityNoKey
    {
        public bool IsInativo { get; set; }
        public DateTime? DhInclusao { get; set; }
        public DateTime? DhAlteracao { get; set; }
    }
}