using Empresa2XAOficial;
using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;

public class Empresa
{
    private string _id;
    private string razaosocial;
    private string nomefantasia;
    private string situacaocadastral;
    private string regimetributario;
    private DateTime datainicioatv;
    private string telefone;
    private double capitalsocial;
    private string estado;
    private string cidade;
    private string endereco;
    private string tipo;
    private string porte;
    private string naturezajuridica;
    private string nomeproprietario;
    private string cpfproprietario;
    private string cnpj;

    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string RazaoSocial
    {
        get { return razaosocial; }
        set { razaosocial = value; }
    }

    public string NomeFantasia
    {
        get { return nomefantasia; }
        set { nomefantasia = value; }
    }

    public string SituacaoCadastral
    {
        get { return situacaocadastral; }
        set { situacaocadastral = value; }
    }

    public string RegimeTributario
    {
        get { return regimetributario; }
        set { regimetributario = value; }
    }

    public DateTime DataInicioAtv
    {
        get { return datainicioatv; }
        set { datainicioatv = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public double CapitalSocial
    {
        get { return capitalsocial; }
        set { capitalsocial = value; }
    }

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public string Cidade
    {
        get { return cidade; }
        set { cidade = value; }
    }

    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }

    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }


    public string Porte
    {
        get { return porte; }
        set { porte = value; }
    }

    public string NaturezaJuridica
    {
        get { return naturezajuridica; }
        set { naturezajuridica = value; }
    }

    public string NomeProprietario
    {
        get { return nomeproprietario; }
        set { nomeproprietario = value;}
    }
    
    public string CpfProprietario
    {
        get { return cpfproprietario; }
        set { cpfproprietario = value;}
    }
    
    public string Cnpj
    {
        get { return cnpj; }
        set { cnpj = value;}
    }


    public Empresa()
    {
        GerarId();
    }

    public Empresa(string razaosocial, string nomefantasia, string situacaocadastral, string regimetributario, DateTime datainicioatv,
        string telefone, double capitalsocial, string estado, string cidade, string endereco, string tipo, string porte,
        string naturezajuridica, string nomeproprietario, string cpfproprietario, string cnpj)
    {
        RazaoSocial = razaosocial;
        NomeFantasia = nomefantasia;
        SituacaoCadastral = situacaocadastral;
        RegimeTributario = regimetributario;
        DataInicioAtv = datainicioatv;
        Telefone = telefone;
        CapitalSocial = capitalsocial;
        Estado = estado;
        Cidade = cidade;
        Endereco = endereco;
        Tipo = tipo;
        Porte = porte;
        NaturezaJuridica = naturezajuridica;
        NomeProprietario = nomeproprietario;
        CpfProprietario = cpfproprietario;
        Cnpj = cnpj;
    }

    private void GerarId()
    {
        this._id = Guid.NewGuid().ToString();
    }
}