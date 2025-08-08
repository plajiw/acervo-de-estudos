# Testes para o Serviço de Inatividade da Ivi

### **Cenários de Teste**

- [x] **Processar Conversa Não Finalizada**

- **Descrição**: Verifica se uma conversa com `StatusDoFluxo != Finalizado` é finalizada e marcada como `Finalizado` no banco.



- [x] **Ignorar Conversa Já Finalizada**

- **Descrição**: Garante que uma conversa com `StatusDoFluxo: Finalizado` não é processada.



- [x] **Processar Múltiplas Conversas Não Finalizadas**

- **Descrição**: Testa o processamento em lote de vários usuários que apresentam conversas com `StatusDoFluxo != Finalizado`.

  <img src="C:\Users\PabloRibeiroRamos\AppData\Roaming\Typora\typora-user-images\image-20250804095325982.png" alt="image-20250804095325982" style="zoom:50%;" />



- [x] **Índice Retorna Registro Mais Recente**

- **Descrição**: Valida se o índice `Conversas_PorUltimaMensagem` retorna o registro mais recente de um usuário.

<img src="C:\Users\PabloRibeiroRamos\AppData\Roaming\Typora\typora-user-images\image-20250804095915126.png" alt="image-20250804095915126" style="zoom:50%;" />

<img src="C:\Users\PabloRibeiroRamos\AppData\Roaming\Typora\typora-user-images\image-20250804095940307.png" alt="image-20250804095940307" style="zoom:50%;" />

- [x] **Conversa com Menos de 24 Horas de Inatividade**

- **Descrição**: Verifica se uma conversa com menos de 24 horas não é processada.

<img src="C:\Users\PabloRibeiroRamos\AppData\Roaming\Typora\typora-user-images\image-20250804100301210.png" alt="image-20250804100301210" style="zoom:50%;" />

- [x] **Conversa com Mais de 30 Dias de Inatividade**

- **Descrição**: Garante que uma conversa com mais de 30 dias não é processada.

<img src="C:\Users\PabloRibeiroRamos\OneDrive - INVENT\Documentos\Pessoal\Proj\acervo-de-estudos\00_Base\assets\image-20250804100755651.png" alt="image-20250804100755651" style="zoom:50%;" />

- [x]  **Conversa de Usuário sem Histórico Prévio**

- **Descrição**: Testa o processamento de uma conversa de um usuário com apenas um registro não finalizado e garante um novo registro com `Status: Finalizado`.