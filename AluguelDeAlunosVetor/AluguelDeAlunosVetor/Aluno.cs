﻿

namespace AluguelDeAlunosVetor
{
     class Aluno
    {

        public string Name { get; set; }
        public string Email { get; set; }

        public Aluno()
        {
        }

        public Aluno(string name, string email)
        {
            Name = name;
            Email = email;
         
        }

        public override string ToString()
        {
            return " Nome: " + Name
                + " , Email: " + Email;
        }
    }
}
