using Microsoft.EntityFrameworkCore;
using LoanPayer.domain;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Beneficiario> Beneficiario { get; set; }

    public DbSet<Cliente> Cliente { get; set; }

    public DbSet<ClienteBeneficiario> ClienteBeneficiario { get; set; }

     public DbSet<Comprador> Comprador { get; set; }

    public DbSet<ContaBancaria> ContaBancaria { get; set; }

    public DbSet<Contato> Contato { get; set; }

    public DbSet<DetalheVenda> DetalheVenda { get; set; }

    public DbSet<DetalheVendaClienteBenefic> DetalheVendaClienteBenefic { get; set; }

    public DbSet<Empreendimento> Empreendimento { get; set; }

    public DbSet<Endereco> Endereco { get; set; }

    public DbSet<FormaPagamento> FormaPagamento { get; set; }

    public DbSet<StatusPagamento> StatusPagamento { get; set; }

     public DbSet<StatusVenda> StatusVenda { get; set; }

    public DbSet<TipoConta> TipoConta { get; set; }

    public DbSet<Torre> Torre { get; set; }

    public DbSet<Unidade> Unidade { get; set; }

    public DbSet<Usuario> Usuario { get; set; }

    public DbSet<Venda> Venda { get; set; }


}