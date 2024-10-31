namespace IntegracaoGemini.Domain.Models;

public static class Text
{
    public const string Base = @"Faça duas perguntas com 4 alternativas e um texto correto usando esse JSON schema:Exercicio = {'pergunta': string, 'alternativa1': string, 'alternativa2': string, 'alternativa3': string, 'alternativa4': string, 'resposta': string} Return: list[Exercicio]. Responda somente com o JSON e não adicione nenhuma quebra de linha a resposta.";

    public const string Explanation = "Dê uma explicação sucinta do porque a resposta para essa pergunta: \n{0}\n Tem como resposta: {1} e não {2}";

    public const string IntProg = @"Introdução à Programação
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

    public const string SOeRC = @"Sistemas Operacionais e Redes de Computadores

Um sistema operacional (SO) é o principal software do computador, responsável por gerenciar todos os recursos e permitir que você interaja com a máquina. Ele organiza e controla o funcionamento do processador, da memória, dos arquivos e de todos os dispositivos conectados. Cada sistema operacional, como Windows, Linux e macOS, tem características próprias. O Windows, por exemplo, é fácil de usar e muito popular, enquanto o Linux é conhecido por sua segurança e é amplamente usado em servidores e ambientes de programação.

O sistema operacional atua como um ""gerente"" que garante que cada programa funcione sem interferir nos outros. Quando você abre um aplicativo ou programa, o SO cuida para que o processador e a memória sejam utilizados da melhor maneira possível, sem que um aplicativo sobrecarregue o computador.

Redes de Computadores
As redes de computadores conectam vários dispositivos para que possam trocar informações. A internet, por exemplo, é uma enorme rede que conecta computadores do mundo inteiro. Dentro de uma rede, cada computador tem um identificador único chamado endereço IP, que permite que ele ""converse"" com outros dispositivos. O DNS (Domain Name System) ajuda a traduzir os nomes dos sites em endereços IP, o que facilita a navegação na internet. Assim, em vez de lembrar o número IP de um site, basta digitar o nome dele.

As redes podem ser pequenas, como uma rede local (LAN), que conecta computadores dentro de uma escola ou empresa, ou muito grandes, como a internet (rede WAN). Em redes menores, é comum o compartilhamento de arquivos e dispositivos, como impressoras, de forma mais prática e rápida.

Segurança em Redes
Quando acessamos a internet, precisamos tomar cuidados com a segurança de rede para proteger nossas informações. Ferramentas como firewall e antivírus ajudam a proteger os computadores contra ataques de hackers e vírus. A segurança é importante para garantir que nossos dados estejam protegidos e que ninguém tenha acesso sem permissão.

Resumo
Sistemas operacionais e redes de computadores são fundamentais para o funcionamento da tecnologia moderna. O SO permite que você use o computador de forma eficiente, enquanto as redes permitem a comunicação entre dispositivos, possibilitando o uso da internet e a troca de informações. Conhecer esses conceitos ajuda a entender como a tecnologia que usamos diariamente funciona e a manter os dados seguros.";

    public const string HtmleBD = @"Introdução ao Desenvolvimento Web e Banco de Dados

O desenvolvimento web é o processo de criar sites e aplicações que podem ser acessados pela internet. Ele envolve várias tecnologias, mas as duas principais são o HTML (HyperText Markup Language) e o CSS (Cascading Style Sheets).

HTML e CSS
HTML é a linguagem de marcação usada para estruturar o conteúdo das páginas web. Com HTML, você define elementos como cabeçalhos, parágrafos, listas, links e imagens. Cada um desses elementos é representado por uma ""tag"" específica. Por exemplo, a tag <h1> é usada para criar um cabeçalho de nível 1, enquanto a tag <p> é usada para parágrafos. A estrutura básica de uma página HTML inclui as tags <html>, <head> e <body>.

CSS, por outro lado, é utilizado para estilizar e formatar a aparência dos elementos HTML. Com CSS, você pode definir cores, fontes, tamanhos e layout da página. Isso permite que você crie uma interface atraente e fácil de usar. As regras de estilo são aplicadas a elementos HTML usando seletores, como classes e IDs, para que você possa controlar exatamente como cada parte da sua página será exibida.

Introdução a Banco de Dados
Os bancos de dados são sistemas que armazenam, organizam e gerenciam informações. Eles são essenciais para aplicações web que precisam manipular grandes volumes de dados, como sites de e-commerce e redes sociais. A linguagem utilizada para interagir com bancos de dados é o SQL (Structured Query Language). Com o SQL, você pode criar, ler, atualizar e excluir dados em um banco de dados.

Um banco de dados é composto por tabelas, que armazenam dados em formato de linhas e colunas. Cada coluna representa um atributo (ou campo) e cada linha representa um registro (ou entrada). Por exemplo, em uma tabela de ""Usuários"", você pode ter colunas para nome, email e idade, e cada linha seria um usuário diferente com essas informações.

Prática: Projeto Web Simples
Para aplicar esses conceitos, é comum desenvolver um projeto simples, como uma página de portfólio pessoal. Nela, você pode usar HTML para estruturar a página e CSS para estilizar. Durante o desenvolvimento, também pode ser introduzida a criação de um banco de dados básico onde você armazena informações sobre projetos, hobbies ou experiências. Isso permite que você veja como os dados podem ser manipulados e apresentados em uma página web.

Importância para o Mercado de Trabalho
Entender desenvolvimento web e bancos de dados é fundamental no mercado de trabalho atual, pois essas habilidades são amplamente demandadas. A capacidade de criar sites e gerenciar dados é valiosa em várias áreas, desde marketing digital até engenharia de software. Além disso, esses conhecimentos servem como base para aprender tecnologias mais avançadas, como frameworks JavaScript e sistemas de gerenciamento de banco de dados mais complexos.

Resumo
O desenvolvimento web e o uso de bancos de dados são essenciais para a criação de aplicações modernas. O HTML e CSS formam a base para o design de sites, enquanto o SQL é fundamental para gerenciar dados. Ao aprender essas habilidades, você se prepara para explorar oportunidades na área de tecnologia e contribuir para o desenvolvimento de soluções inovadoras.";

    public const string AlgeLogProg = @"A lógica de programação é a base para resolver problemas de forma estruturada e eficiente por meio da criação de algoritmos. Um algoritmo é um conjunto de instruções passo a passo que descrevem como realizar uma tarefa ou resolver um problema. É como uma receita de culinária, onde você precisa seguir uma sequência específica de etapas para alcançar o resultado desejado.

Estrutura de um Algoritmo
Um algoritmo geralmente inclui as seguintes etapas:

Entrada: Dados ou informações que serão processados.
Processamento: As operações que o algoritmo realizará com os dados de entrada.
Saída: Os resultados gerados após o processamento.
Os algoritmos podem ser representados de várias maneiras, como em pseudocódigo ou diagramas de fluxo. O pseudocódigo utiliza uma linguagem simples e descritiva para ilustrar a lógica, enquanto os diagramas de fluxo representam visualmente as etapas do algoritmo com símbolos, como losangos para decisões e retângulos para processos.

Estruturas de Controle
Para construir algoritmos eficazes, é importante entender as estruturas de controle, que permitem que o algoritmo tome decisões ou repita ações. As principais estruturas de controle incluem:

Condicionais: Permitem que o algoritmo execute diferentes instruções com base em condições específicas. Por exemplo, a instrução ""se... então"" permite que você defina ações diferentes dependendo de um resultado (por exemplo, se a nota for maior que 7, o aluno é aprovado).

Laços de repetição: Executam um bloco de código várias vezes. Os laços mais comuns são o ""enquanto"" (while) e o ""para"" (for), que repetem ações até que uma condição específica seja atendida.

Exemplos Práticos
Um exemplo clássico de algoritmo é o cálculo da soma de números inteiros. O algoritmo pode ser descrito da seguinte forma:

Inicie a soma como zero.
Para cada número de 1 a N:
Adicione o número atual à soma.
Exiba o resultado da soma.
Outro exemplo é um algoritmo de busca, que pode ser utilizado para encontrar um elemento em uma lista. Um algoritmo simples, chamado de ""busca linear"", verifica cada elemento da lista um por um até encontrar o que está sendo procurado.

Importância na Programação
A lógica de programação e a construção de algoritmos são essenciais para qualquer linguagem de programação. Compreender esses conceitos permite que você escreva códigos mais eficientes e resolva problemas complexos de maneira mais sistemática. Além disso, a prática com algoritmos ajuda a desenvolver o raciocínio lógico, uma habilidade fundamental em muitas áreas da tecnologia e da ciência.

Resumo
Os algoritmos e a lógica de programação são fundamentais para a resolução de problemas e a criação de programas de computador. Aprender a construir algoritmos eficazes e a utilizar estruturas de controle permitirá que você desenvolva soluções robustas e eficientes para uma variedade de desafios. Com o tempo e a prática, você se tornará mais habilidoso em pensar de forma algorítmica, o que é crucial para qualquer aspirante a programador.";
}