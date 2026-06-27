# Arquitetura Técnica

## Princípios

- Separar lógica, dados e apresentação.
- Evitar dependência direta entre regras de batalha e interface.
- Criar conteúdo orientado por dados.
- Usar identificadores permanentes.
- Preparar save versionado.
- Manter serviços externos substituíveis.
- Tornar a lógica central testável sem depender de cenas.

## Regra para os slots

A estrutura deverá permitir propriedades individuais por slot no futuro, mas a primeira versão não implementará buffs, debuffs ou prioridade de alvo.
