# Agendador de Salas — Web API

Web API para **agendamento de salas** (faculdade/escola), permitindo cadastrar **Disciplinas**, **Professores**, **Salas** e realizar **Agendamentos** vinculando sala + professor + disciplina.

A API pode ser executada **localmente** com **Swagger** e também em **Docker**.

---

## ✅ Funcionalidades

- Cadastro completo (CRUD) de:
  - **Sala**
  - **Professor**
  - **Disciplina**
  - **Agendamento**
- Documentação e testes via **Swagger UI**
- Estrutura ideal para uso em **ambiente acadêmico**, evitando bagunça na reserva de salas

---

## 🧩 Entidades (conceito)

- **Sala**: local onde a aula acontece (ex.: laboratório 01, sala 12)
- **Professor**: responsável pela aula
- **Disciplina**: matéria/curso (ex.: Matemática, Redes, Banco de Dados)
- **Agendamento**: reserva que relaciona **Sala + Professor + Disciplina** em um **dia/horário**

---

## 🔗 Endpoints (principais)

### Agendamento
- `GET    /api/Agendamento`
- `POST   /api/Agendamento`
- `GET    /api/Agendamento/{id}`
- `PUT    /api/Agendamento/{id}`
- `DELETE /api/Agendamento/{id}`

### Disciplina
- `GET    /api/Disciplina`
- `POST   /api/Disciplina`
- `GET    /api/Disciplina/{id}`
- `PUT    /api/Disciplina/{id}`
- `DELETE /api/Disciplina/{id}`

### Professor
- `GET    /api/Professor`
- `POST   /api/Professor`
- `GET    /api/Professor/{id}`
- `PUT    /api/Professor/{id}`
- `DELETE /api/Professor/{id}`

### Sala
- `GET    /api/Sala`
- `POST   /api/Sala`
- `GET    /api/Sala/{id}`
- `PUT    /api/Sala/{id}`
- `DELETE /api/Sala/{id}`
