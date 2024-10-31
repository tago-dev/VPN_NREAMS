# Estudo de VPN em C#

Este repositório contém um código C# que implementa um servidor TCP simples. Ele serve como base para estudos sobre a criação de VPNs, explorando conceitos como comunicação cliente-servidor, transferência de dados e segurança.

## Funcionalidades:

* **Escuta por conexões:** O servidor escuta na porta 1194 (comumente usada para OpenVPN) em todas as interfaces de rede disponíveis (`IPAddress.Any`).
* **Aceita conexões:**  Aceita a conexão de um cliente e estabelece um fluxo de dados.
* **Recebe dados:** Lê os dados enviados pelo cliente.
* **Processa dados:**  (em desenvolvimento) -  Pretende-se adicionar lógica para processar os dados recebidos do cliente, simulando o comportamento de uma VPN.
* **Envia resposta:** Envia uma mensagem de resposta para o cliente.
* **Tratamento de erros:** Inclui um bloco `try-catch` para lidar com exceções.
* **Fecha conexão:** Encerra a conexão e para de escutar por novas conexões.

## Objetivo do estudo:

* Compreender os fundamentos da comunicação TCP.
* Implementar um servidor que aceite conexões e troque dados com clientes.
* Explorar conceitos básicos de segurança em redes.
* Pesquisar e implementar algoritmos de criptografia para proteger a comunicação.
* (Opcional) Integrar com bibliotecas OpenVPN para criar uma VPN funcional.

## Próximos passos:

* Implementar criptografia na comunicação cliente-servidor.
* Adicionar autenticação para garantir que somente clientes autorizados possam se conectar.
* Implementar roteamento de tráfego para simular o funcionamento de uma VPN.
* Criar um cliente que se conecte ao servidor e envie/receba dados.


## Observações:

* Este código é um ponto de partida para estudos e  requer  desenvolvimento adicional para se tornar uma VPN completa.
* A porta 1194 pode ser alterada, se necessário.

**Contribuições são bem-vindas!**
