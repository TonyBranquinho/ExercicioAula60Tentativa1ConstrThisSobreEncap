using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula60Tentativa1ConstrutoresThisSobrecargaEncapsulamento {
    internal class Cliente {

        CultureInfo CI = CultureInfo.InvariantCulture;

        private int _numeroConta;
        private string _titularConta;
        private char _haveraDeposito;
        private double _depositoInicial;
        private double _saldo;

        public Cliente (int numeroConta, string titularConta, char haveraDeposito, double depositoInicial, double saldo) {
            _numeroConta = numeroConta;
            _titularConta = titularConta;
            _haveraDeposito = haveraDeposito;
            _depositoInicial = depositoInicial;
            _saldo = saldo;
        }
        
        
        public void Deposito(double deposito) {
            _saldo = _saldo + deposito;
        }
        public void Saque(double saque) {
            _saldo = _saldo - saque - 5.00;
        }

        public override string ToString() {
            return "Conta "
                + _numeroConta
                + ", Titular: "
                + _titularConta
                + ", Saldo: $ "
                + _saldo.ToString("F2", CI);
        }

    }
}
