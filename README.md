# Analizador-de-codigo

[![NPM](https://img.shields.io/npm/l/react)](https://github.com/LucasKalil-Programador/Analizador-de-codigo/blob/5d065ea49c6e218d406ab51f9bb0e8fac1a103b0/Licence)

[Video de apresentação](https://www.youtube.com/watch?v=_ITKZamo9j0)

# Sobre o projeto

Esse projeto teve como objetivo principal servir para a matéria de compiladores do curso de ciências da computação, o objetivo era criar um analisador léxico que com base em uma sequencia de caracteres, extrairia cada token e seu devido tipo caso o software encontrasse algum problema era necessário informar isso para o usuário.

Como o objetivo era criar um compilador o orientador deixou que personalizar a linguagem por isso adotamos nomes diferentes do usual exemplo.

código valido na linguagem criada.

```java

// exemplo de importação
GBuy collections;

// exemplo de declaração tipo inteiro
GRNint variavel1 = 90;
```

código invalido na linguagem criada.

```java

// violação da regra "variáveis nao podem iniciar com 'G'"
GRNint Gvariavel1 = 90;
```

## Usabilidade do software

O software é basicamente composto de uma caixa de texto onde o usuário escreveria o código e uma tabela de tokens e de tokens inválidos e um botão para iniciar o processamento do analisador.

## Exemplos

![Janela do analisador léxico](https://user-images.githubusercontent.com/82661706/219378430-0946b9bc-3e8c-482c-ab3d-79f057959c5d.png)

![Janela do analisador sintático](https://user-images.githubusercontent.com/82661706/219378444-3c905ca6-1152-46c2-b18c-832746adc148.png)

# Como executar

### 1ª forma

Baixe o .exe do projeto ele esta presente em [bin/Debug/Analizador.exe](https://github.com/LucasKalil-Programador/Analizador-de-codigo/blob/5d065ea49c6e218d406ab51f9bb0e8fac1a103b0/bin/Debug/Analizador.exe) dessa forma nao sera possível ver o código C#.

### 2ª forma

Faça download desse repositório depois importe esse projeto com o [Visual Studio](https://visualstudio.microsoft.com) e execute ele normalmente.

# Tecnologias usadas

Para esse projeto foi necessário os seguintes conhecimentos.

- C# (linguagem)
- Regex (reconhecimento de padrões de texto)
- Windows Forms (Janela de interação com o usuário)

# Outras informações

Criador: Lucas Guimarães Kalil - desenvolvedor full stack

Linkedin: https://www.linkedin.com/in/lucas-kalil-436a6220a/<br>
Contato: lucas.prokalil2020@outlook.com
