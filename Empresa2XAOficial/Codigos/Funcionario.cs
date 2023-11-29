using Empresa2XAOficial;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;

public class Funcionario
{
    private string _id;
    private string nome;
    private DateTime datanasc;
    private string cpf;
    private string rg;
    private string telefone;
    private string email;
    private string estado;
    private string cidade;
    private string endereco;
    private string estadocivil;
    private string funcao;
    private double salario;

    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }    
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public DateTime Datanasc
    {
        get { return datanasc; }
        set { datanasc = value; }
    }

    public string Cpf
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public string Rg
    {
        get { return rg; }
        set { rg = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
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

    public string Estadocivil
    {
        get { return estadocivil; }
        set { estadocivil = value; }
    }


    public string Funcao
    {
        get { return funcao; }
        set { funcao = value; }
    }

    public double Salario
    {
        get { return salario; }
        set { salario = value; }
    }


    public Funcionario()
    {
        GerarId();
    }

    public Funcionario(string nome, DateTime datanasc, string cpf, string rg, string telefone, string email, string estado, string cidade, string endereco, string estadocivil, string funcao, double salario)
    {
        Nome = nome;
        Datanasc = datanasc;
        Cpf = cpf;
        Rg = rg;
        Telefone = telefone;
        Email = email;
        Estado = estado;
        Cidade = cidade;
        Endereco = endereco;
        Estadocivil = estadocivil;
        Funcao = funcao;
        Salario = salario;
    }

    private void GerarId()
    {
        this._id = Guid.NewGuid().ToString();
    }
}