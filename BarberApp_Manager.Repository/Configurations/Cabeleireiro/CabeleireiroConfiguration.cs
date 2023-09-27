using BarberApp_Manager.Entity.Cabeleireiro;
using BarberApp_Manager.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp_Manager.Repository.Configurations.Cabeleireiro
{
    internal class CabeleireiroConfiguration : EntityTypeConfigurationKeyIdIntBase<CabeleireiroEntity>
    {
        public CabeleireiroConfiguration() : base(tableName: "TB_CABELEIREIRO")
        {
        }

        public override void OnConfigure(EntityTypeBuilder<CabeleireiroEntity> builder)
        {
            builder.Property(x => x.Nome).HasColumnName("DS_NOME");
            builder.Property(x => x.Permisao).HasColumnName("DS_PERMISAO");
            builder.Property(x => x.Login).HasColumnName("DS_LOGIN");
            builder.Property(x => x.Senha).HasColumnName("DS_SENHA");
            builder.Property(x => x.IsAceitandoServico).HasColumnName("TG_ACEITANDO_SERVICO");
            builder.Property(x => x.LimiteServicoInicio).HasColumnName("DH_LIMITE_SERVICO_INICIO");
            builder.Property(x => x.LimiteServicoFim).HasColumnName("DH_LIMITE_SERVICO_FIM");
            builder.Property(x => x.Cpf).HasColumnName("DS_CPF");
            builder.Property(x => x.Email).HasColumnName("DS_EMAIL");
        }
    }
}
