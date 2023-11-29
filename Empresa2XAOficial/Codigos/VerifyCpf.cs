using Empresa2XAOficial;
using System;

public class VerifyCpf
{
    public string cpf;

    public string Cpf { get { return cpf; } set { cpf = value; } }

    public VerifyCpf(string cpf) { }

    public VerifyCpf() { }

    public bool Digitos(string cpf)
    {

        cpf = cpf.Replace(",", "");
        cpf = cpf.Replace("-", "");

        int soma = 0;
        int digito = 0;
        int resto = 0;
        int digito1 = 0;
        int digito2 = 0;

        if (cpf.Length == 11)
        {

            for (int i = 0; i < 9; i++)
            {
                digito = Convert.ToInt32(cpf[i].ToString());

                soma = soma + digito * (10 - i);
            }

            resto = soma % 11;

            if (resto < 2)
            {
                digito1 = 0;
            }

            else
            {
                digito1 = 11 - resto;
            }

            if (digito1.ToString() != cpf[9].ToString())
            {
                return false;
            }


            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                digito = Convert.ToInt32(cpf[i].ToString());
                soma = soma + digito * (11 - i);
            }

            resto = soma % 11;

            if (resto < 2)
            {
                digito2 = 0;
            }

            else
            {
                digito2 = 11 - resto;
            }

            if (digito2.ToString() != cpf[10].ToString())
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        else
        {
            return false;
        }
    }
}
