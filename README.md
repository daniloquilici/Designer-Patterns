# Designer-Patterns
Projeto para relembrar/praticar os mais conhecidos Designer Patterns.

Designer Patterns:
<h2>Strategy</h2>
  <p>
    O padrão Strategy é muito útil quando temos um conjunto de algoritmos similares, e precisamos alternar entre eles em diferentes pedaços da aplicação. No exemplo do vídeo,      temos diferentes maneira de calcular o imposto, e precisamos alternar entre elas.
O Strategy nos oferece uma maneira flexível para escrever diversos algoritmos diferentes, e de passar esses algoritmos para classes clientes que precisam deles. Esses clientes desconhecem qual é o algoritmo "real" que está sendo executado, e apenas manda o algoritmo rodar. Isso faz com que o código da classe cliente fique bastante desacoplado das implementações concretas de algoritmos, possibilitando assim com que esse cliente consiga trabalhar com N diferentes algoritmos sem precisar alterar o seu código.
  </p>
  
- Chain of Responsibility
- Template Method
- Decorator
- State
- Builder

<h1>Observer</h1>
<p>
  Quando devemos aplicar o padrão Observer?
  Quando o acoplamento da nossa classe está crescendo, ou quando temos diversas ações diferentes a serem executadas após um determinado processo, podemos implementar o Observer.
  Ele permite que diversas ações sejam executadas de forma transparente à classe principal, reduzindo o acoplamento entre essas ações, facilitando a manutenção e evolução do código.
</p>
