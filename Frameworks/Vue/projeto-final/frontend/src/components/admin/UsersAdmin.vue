<template>
  <div class="users-admin">
    <b-form>
      <input type="hidden" id="user-id" v-model="user.id" />
      <b-row>
        <b-col md="6" sm="12">
          <b-form-group label="Nome: " label-for="user-name">
            <b-form-input
              id="user-name"
              type="text"
              v-model="user.name"
              required
              placeholder="Informe o nome do usuário"
              :readonly="mode === 'remove'"
            ></b-form-input>
          </b-form-group>
        </b-col>
        <b-col md="6" sm="12">
          <b-form-group label="E-mail: " label-for="user-email">
            <b-form-input
              id="user-email"
              type="text"
              v-model="user.email"
              required
              placeholder="Informe o e-mail do usuário"
              :readonly="mode === 'remove'"
            ></b-form-input>
          </b-form-group>
        </b-col>
      </b-row>
      <b-row v-show="mode === 'save'">
        <b-col md="6" sm="12">
          <b-form-group label="Senha: " label-for="user-password">
            <b-form-input
              id="user-password"
              type="password"
              v-model="user.password"
              required
              placeholder="Informe a senha do usuário"
            ></b-form-input>
          </b-form-group>
        </b-col>
        <b-col md="6" sm="12">
          <b-form-group
            label="Confirmação de senha: "
            label-for="user-confirm-email"
          >
            <b-form-input
              id="user-confirm-email"
              type="password"
              v-model="user.confirmPassword"
              required
              placeholder="Confirme a senha do usuário"
            ></b-form-input>
          </b-form-group>
        </b-col>
      </b-row>
      <b-form-checkbox id="user-admin" v-model="user.admin" class="mb-3 ml-1" v-show="mode === 'save'"
        >Administrador</b-form-checkbox
      >
      <b-row>
        <b-col xs="12">
          <b-button
            variant="primary"
            v-if="mode === 'save'"
            @click="save()"
            class="mb-1"
            >Salvar</b-button
          >
          <b-button
            variant="danger"
            v-if="mode === 'remove'"
            @click="remove"
            class="mb-1"
            >Excluir</b-button
          >
          <b-button @click="reset()" class="ml-1 mb-1">Cancelar</b-button>
        </b-col>
      </b-row>
    </b-form>
    <b-table hover striped :items="users" :fields="fields" class="mt-5">
      <template slot="actions" slot-scope="data">
        <b-button variant="warning" @click="loadUser(data.item)" class="mr-2">
          <i class="fa fa-pencil"></i>
        </b-button>
        <b-button
          variant="danger"
          @click="loadUser(data.item, 'remove')"
          class="mr-2"
        >
          <i class="fa fa-trash"></i>
        </b-button>
      </template>
    </b-table>
  </div>
</template>

<script>
import { baseApiUrl, showError } from "@/global";
import axios from "axios";

export default {
  name: "UsersAdmin",
  data: function () {
    return {
      mode: "save",
      user: {},
      users: [],
      fields: [
        {
          key: "id",
          label: "Código",
          sortable: true,
        },
        {
          key: "name",
          label: "Nome",
          sortable: true,
        },
        {
          key: "email",
          label: "E-mail",
          sortable: true,
        },
        {
          key: "admin",
          label: "Administrador",
          sortable: true,
          formatter: (value) => (value ? "Sim" : "Não"),
        },
        {
          key: "actions",
          label: "Ações",
        },
      ],
    };
  },
  methods: {
    loadUsers() {
      const url = `${baseApiUrl}/users`;
      axios.get(url).then((res) => {
        this.users = res.data;
      });
    },
    reset() {
      (this.mode = "save"), (this.user = {}), this.loadUsers();
    },
    save() {
      const method = this.user.id ? "put" : "post";
      const id = this.user.id ? `${this.user.id}` : "";
      axios[method](`${baseApiUrl}/users/${id}`, this.user)
        .then(() => {
          this.$toasted.global.defaultSuccess();
          this.loadUsers();
        })
        .catch(showError);
    },
    remove() {
      const id = this.user.id;
      axios
        .delete(`${baseApiUrl}/users/${id}`)
        .then(() => {
          this.$toasted.global.defaultSuccess();
          this.loadUsers();
        })
        .catch(showError);
    },
    loadUser(user, mode = "save") {
      this.mode = mode;
      this.user = { ...user };
    },
  },
  mounted() {
    this.loadUsers();
  },
};
</script>

<style>
</style>