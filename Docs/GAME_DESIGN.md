# Game Design

## Visão geral

Idle Cards será um jogo mobile idle de cartas com estética de fantasia anime e liberdade para explorar múltiplos universos.

A estrutura de universos permitirá usar diferentes temáticas, como fantasia, tecnologia, cidades modernas, mundos espirituais, ruínas, ficção científica e outras, mantendo uma identidade visual comum.

## Referência

Epic Seven será usado como referência para:

- Qualidade visual.
- Personagens em estilo anime.
- Identidade individual das cartas.
- Formação de equipe.
- Estrutura de conteúdo PvE.
- Clareza de interface.

Não serão copiados personagens, história, interface ou sistemas específicos.

## Papel do jogador

O jogador é o próprio protagonista: um Viajante Dimensional.

Esse personagem será também a primeira carta recebida no início do jogo.

## Premissa

Uma fenda dimensional leva a irmã do protagonista.

Durante a tentativa de impedir o desaparecimento, ele toca a fenda e passa a possuir a capacidade de perceber e interagir com rupturas dimensionais.

Ele começa sua jornada para encontrá-la.

Com o avanço entre universos, descobre que o incidente está ligado a uma ameaça ou propósito maior.

## Estrutura narrativa

A narrativa será leve e não interromperá constantemente o loop idle.

Ela deverá:

- Justificar as viagens entre universos.
- Apresentar personagens e ameaças.
- Dar contexto a chefes e mundos.
- Desenvolver gradualmente o mistério das fendas.
- Manter o objetivo pessoal do protagonista.

## Tela de batalha

Orientação vertical.

### Parte superior

- Monstros.
- NPCs hostis.
- Chefes.
- Outros inimigos de PvE.

### Parte inferior

Quatro cartas do jogador organizadas em cruz:

```text
          [Norte]

[Oeste]             [Leste]

           [Sul]
```

## Slots

- Qualquer carta pode ocupar qualquer posição.
- Slots não serão limitados por classe.
- No futuro, posições poderão aplicar efeitos próprios.
- Esses efeitos poderão incluir buffs, debuffs e prioridade de alvo.
- O sistema posicional não faz parte do primeiro protótipo funcional.

## Limite da primeira implementação

A primeira cena deverá validar apenas:

- Orientação vertical.
- Área de inimigos.
- Quatro slots em cruz.
- Escala da interface em diferentes resoluções.
- Estrutura visual provisória.

Ainda não deverá validar balanceamento ou combate completo.
