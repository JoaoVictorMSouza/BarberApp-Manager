using BarberApp_Manager.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp_Manager.Repository.Base
{
    public abstract class EntityTypeConfigurationKeyIdIntBase<TEntity> : EntityTypeConfigurationBase<int, TEntity>
        where TEntity : DefaultKeyIntIdEntity
    {
        protected EntityTypeConfigurationKeyIdIntBase(string tableName) : base(tableName)
        {
        }

        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn();

            base.Configure(builder);
        }
    }


    public abstract class EntityTypeConfigurationBase<TypeId, TEntity> : EntityTypeConfigurationNoKeyBase<TEntity>
        where TEntity : DefaultEntity<TypeId>
    {
        protected EntityTypeConfigurationBase(string tableName) : base(tableName)
        {
        }

        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("PK_ID");

            base.Configure(builder);
        }
    }

    public abstract class EntityTypeConfigurationNoKeyBase<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : DefaultEntityNoKey
    {
        private readonly string TableName;
        public EntityTypeConfigurationNoKeyBase(string tableName)
        {
            this.TableName = tableName;
        }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(this.TableName);

            builder.Property(x => x.DhInclusao).HasColumnName("DH_INCLUSAO");
            builder.Property(x => x.DhAlteracao).HasColumnName("DH_ALTERACAO");
            builder.Property(x => x.IsInativo).HasColumnName("TG_INATIVO");

            this.OnConfigure(builder);
        }

        public abstract void OnConfigure(EntityTypeBuilder<TEntity> builder);
    }
}
