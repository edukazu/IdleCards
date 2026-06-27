# Estado Atual do Projeto

## Identificação

- Projeto: Idle Cards
- Engine: Unity 6.5
- Versão exata: 6000.5.1f1
- Linguagem: C#
- Plataforma inicial: Android
- Editor: Visual Studio Code
- Diretor e revisor: Eduardo
- Programador principal: GPT-5.5 Thinking

## Fase atual

Fundação e configuração inicial.

O projeto Unity foi criado e o Editor abriu corretamente. Os módulos Android Build Support, Android SDK & NDK Tools, OpenJDK e Web Build Support estão instalados.

Ainda não há código de gameplay.

## Decisões aprovadas

1. Desenvolver diretamente em Unity.
2. Não criar uma segunda implementação do jogo em HTML, CSS e JavaScript.
3. Usar build Web da Unity para revisões rápidas.
4. Desenvolver por pequenas entregas verticais.
5. Separar lógica, dados e interface.
6. Usar orientação vertical.
7. Exibir inimigos de PvE na parte superior.
8. Exibir quatro cartas do jogador na parte inferior.
9. Organizar as cartas em cruz: norte, sul, leste e oeste.
10. Permitir qualquer carta em qualquer slot.
11. Deixar buffs, debuffs e prioridade de alvo por posição para uma fase futura.

## Direção inicial da batalha

```text
┌─────────────────────────┐
│      INIMIGOS / PvE     │
├─────────────────────────┤
│          [N]            │
│     [O]       [L]       │
│          [S]            │
└─────────────────────────┘
```

## Próxima tarefa

Integrar esta documentação à raiz do projeto Unity e confirmar que a pasta correta está aberta no Visual Studio Code.
