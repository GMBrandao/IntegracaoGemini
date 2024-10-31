namespace IntegracaoGemini.Domain.Models;

public static class Text
{
    public const string Base = @"Faça duas perguntas com 4 alternativas e um texto correto usando esse JSON schema:Exercicio = {'pergunta': string, 'alternativa1': string, 'alternativa2': string, 'alternativa3': string, 'alternativa4': string, 'resposta': string} Return: list[Exercicio]. Responda somente com o JSON e não adicione nenhuma quebra de linha a resposta.";

    public const string Explanation = "Dê uma explicação sucinta do porque a resposta para essa pergunta: \n{0}\n Tem como resposta: {1} e não {2}";

    public const string Programming = @"Introdução à Programação
Programação é o processo de criar instruções que dizem ao computador como realizar determinadas tarefas. No mundo moderno, praticamente tudo ao nosso redor depende de software, desde celulares e aplicativos até sistemas complexos de gerenciamento de empresas e inteligência artificial. Com a programação, podemos transformar ideias em soluções, automatizar processos e resolver problemas de maneira eficiente.


O que é um Programa?
Um programa é um conjunto de instruções escritas em uma linguagem que o computador entende. Essas instruções são executadas sequencialmente para realizar ações como cálculos matemáticos, processamento de dados ou exibição de informações. No início, um programador escreve o código-fonte em uma linguagem de programação, como Python, Java, ou C#, e, em seguida, esse código é transformado em algo que o computador possa executar.


Linguagens de Programação
Linguagens de programação são a ponte entre o programador e o computador. Existem diversas linguagens, e cada uma é adequada para diferentes tipos de tarefas. Algumas das mais populares incluem:

Python: Simples e fácil de aprender, muito utilizada em ciência de dados e desenvolvimento web.

JavaScript: Amplamente usada para desenvolvimento de sites e aplicativos web.

Java: Comumente utilizada em sistemas grandes, como o Android e em sistemas empresariais.

C: Usada para sistemas de baixo nível e desenvolvimento de software de alto desempenho.

Cada linguagem tem suas próprias regras (sintaxe) e modos de execução, mas todas seguem a lógica básica da programação.

Pensamento Computacional
Antes de começar a programar, é essencial desenvolver o pensamento computacional, que envolve a capacidade de pensar em termos de etapas lógicas e soluções de problemas. Isso inclui:

Decomposição: Dividir problemas complexos em partes menores e mais gerenciáveis.

Reconhecimento de padrões: Identificar padrões em problemas semelhantes e aplicar soluções já conhecidas.

Abstração: Focar nos detalhes mais importantes e ignorar aspectos irrelevantes.

Algoritmos: Criar um conjunto de instruções claras para resolver problemas.


Estruturas Básicas de Programação
Toda linguagem de programação oferece três estruturas básicas que permitem criar programas:

Sequência: Execução de comandos em ordem, um após o outro.

Decisão (Condicional): Escolher entre diferentes caminhos com base em uma condição. Exemplo: Se a condição for verdadeira, faça isso; se for falsa, faça aquilo.

Repetição (Laços): Executar o mesmo bloco de código várias vezes enquanto uma condição for verdadeira.

Por que Aprender a Programar?

Aprender a programar oferece uma série de benefícios, como desenvolver a capacidade de resolver problemas de forma lógica, além de abrir portas para uma ampla variedade de carreiras em tecnologia, ciência, engenharia e até áreas criativas, como design de jogos. Além disso, com o crescimento da tecnologia, há uma demanda crescente por profissionais com habilidades de programação em diversos setores.


Conclusão
A programação não é apenas sobre aprender a usar uma linguagem de computador. É sobre entender como usar o computador como uma ferramenta poderosa para resolver problemas e criar soluções inovadoras. Ao começar a programar, você estará desenvolvendo habilidades que podem transformar a maneira como você interage com o mundo digital.";
}