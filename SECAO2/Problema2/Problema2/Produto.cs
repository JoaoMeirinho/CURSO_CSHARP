﻿using System;
using System.Globalization;

namespace Problema2
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarQuantidadeAoEstoque(int qte)
        {
            Quantidade += qte;
        }

        public void RemoverQuantidadeAoEstoque(int qte)
        {
            Quantidade -= qte;
        }
        public override string ToString()
        {
            return $"{Nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
