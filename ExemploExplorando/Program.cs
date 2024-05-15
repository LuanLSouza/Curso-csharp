using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "João";
p1.Sobrenome = "Silva";

Pessoa p2 = new Pessoa();
p2.Nome = "Maria";
p2.Sobrenome = "Santos";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

