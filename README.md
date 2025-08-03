# Sobre
Api de cadastro de proprietarios e imoveis \
Tecnologias utilizadas : 
- .NET 9
- PostgreSql
- Docker

---

### Pr�-Requisitos
 #### Voc� tem duas maneiras de executar a api, via **Docker** ou **Local**

 #### Docker
- **Docker Engine**: Certifique-se de que o Docker Engine esteja instalado e em execu��o no seu sistema (por meio do WSL ou de outro ambiente).

#### Local
- .NET
- Visual Studio
- Banco PostgreSql

---

### Instala��o

1. **Clone o reposit�rio**:
   ```bash
   git clone https://github.com/Olivergms/Imoveis.git
   cd [Imoveis]
   ```

2. **Para executar o projeto** certifique-se de estar rodando o wsl.
   ```bash
   docker compose up -d
   ```

3. **Abrindo o servi�o** 
    - Abra o seu navegador
    - Acesse **https://localhost:8080/swagger**




> **Note**: Para rodar local voc� ter� que abrir o visual studio e selecionar o perfil `local`. Se o banco n�o estiver rodando na sua maquina, altere a string de conex�o na linha 10 do arquivo `appsettings.json` no projeto `Imoveis-api`. 