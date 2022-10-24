# Commit Type

* ***test***: indica qualquer tipo de criação ou alteração de códigos de teste. <br>
Exemplo: Criação de testes unitários.

* ***feat***: indica o desenvolvimento de uma nova feature ao projeto. <br>
Exemplo: Acréscimo de um serviço, funcionalidade, endpoint, etc.

* ***refactor***: usado quando houver uma refatoração de código que não tenha qualquer tipo de impacto na lógica/regras de negócio do sistema.<br>
Exemplo: Mudanças de código após um code review

* ***style***: empregado quando há mudanças de formatação e estilo do código que não alteram o sistema de nenhuma forma.<br>
Exemplo: Mudar o style-guide, mudar de convenção lint, arrumar indentações, remover espaços em brancos, remover comentários, etc..

* ***fix***: utilizado quando há correção de erros que estão gerando bugs no sistema.<br>
Exemplo: Aplicar tratativa para uma função que não está tendo o comportamento esperado e retornando erro.

* ***chore***: indica mudanças no projeto que não afetem o sistema ou arquivos de testes. São mudanças de desenvolvimento.<br>
Exemplo: Mudar regras do eslint, adicionar prettier, adicionar mais extensões de arquivos ao .gitignore

* ***docs***: usado quando há mudanças na documentação do projeto.<br>
Exemplo: adicionar informações na documentação da API, mudar o README, etc.

* ***build***: utilizada para indicar mudanças que afetam o processo de build do projeto ou dependências externas.
Exemplo: Gulp, adicionar/remover dependências do npm, etc.

* ***perf***: indica uma alteração que melhorou a performance do sistema.<br>
Exemplo: alterar ForEach por while, melhorar a query ao banco, etc.

* ***ci***: utilizada para mudanças nos arquivos de configuração de CI.<br>
Exemplo: Circle, Travis, BrowserStack, etc.

* ***revert***: indica a reverão de um commit anterior.

* ***dep***: adicionado ou alterada alguma dependência.