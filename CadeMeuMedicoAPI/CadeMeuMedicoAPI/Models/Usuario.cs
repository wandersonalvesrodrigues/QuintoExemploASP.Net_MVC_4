﻿namespace CadeMeuMedicoAPI.Models
{
    public class Usuario
    {
        public long IDUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}