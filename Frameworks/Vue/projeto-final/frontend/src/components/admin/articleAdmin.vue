<template>
  <div class="article-admin">
    <b-form>
      <input type="hidden" id="article-id" v-model="article.id" />
      <b-form-group label="Nome: " label-for="article-name">
        <b-form-input
          id="article-name"
          type="text"
          v-model="article.name"
          required
          placeholder="Informe o nome do artigo"
          :readonly="mode === 'remove'"
        ></b-form-input>
      </b-form-group>
      <b-form-group label="Descrição: " label-for="article-description">
        <b-form-input
          id="article-description"
          type="text"
          v-model="article.description"
          required
          placeholder="Informe a descrição do artigo"
          :readonly="mode === 'remove'"
        ></b-form-input>
      </b-form-group>
      <b-form-group label="Imagem (URL): " label-for="article-imageUrl">
        <b-form-input
          id="article-imageUrl"
          type="text"
          v-model="article.imageUrl"
          required
          placeholder="Informe a url da imagem"
          :readonly="mode === 'remove'"
        ></b-form-input>
      </b-form-group>
      <b-form-group label="Categoria: " label-for="article-categoryId">
        <b-form-select
          id="article-categoryId"
          :options="categories"
          v-model="article.categoryId"
        />
      </b-form-group>
      <b-form-group label="Autor: " label-for="article-userId">
        <b-form-select
          id="article-userId"
          :options="users"
          v-model="article.userId"
        />
      </b-form-group>
      <b-form-group
        v-if="mode === 'save'"
        label="Conteúdo: "
        label-for="article-content"
      >
        <b-form-group>
          <VueEditor
            v-model="article.content"
            placeholder="Informe o Conteúdo do Artigo..."
          />
        </b-form-group>
      </b-form-group>
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
    </b-form>
    <b-table hover striped :items="articles" :fields="fields" class="mt-5">
      <template slot="actions" slot-scope="data">
        <b-button
          variant="warning"
          @click="loadArticle(data.item)"
          class="mr-2"
        >
          <i class="fa fa-pencil"></i>
        </b-button>
        <b-button
          variant="danger"
          @click="loadArticle(data.item, 'remove')"
          class="mr-2"
        >
          <i class="fa fa-trash"></i>
        </b-button>
      </template>
    </b-table>
    <b-pagination
      size="md"
      v-model="page"
      :total-rows="count"
      :per-page="limit"
    />
  </div>
</template>

<script>
import { VueEditor } from "vue2-editor";
import { baseApiUrl, showError } from "@/global";
import axios from "axios";

export default {
  name: "ArticleAdmin",
  components: { VueEditor },
  data: function () {
    return {
      mode: "save",
      article: {},
      articles: [],
      categories: [],
      users: [],
      page: 1,
      limit: 0,
      count: 0,
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
          key: "description",
          label: "Descrição",
          sortable: true,
        },
        {
          key: "actions",
          label: "Ações",
        },
      ],
    };
  },
  methods: {
    loadArticles() {
      const url = `${baseApiUrl}/articles?page=${this.page}`;
      axios.get(url).then((res) => {
        this.articles = res.data.data;
        this.count = res.data.count;
        this.limit = res.data.limit;
      });
    },
    reset() {
      (this.mode = "save"), (this.article = {}), this.loadArticles();
    },
    save() {
      const method = this.article.id ? "put" : "post";
      const id = this.article.id ? `/${this.article.id}` : "";
      axios[method](`${baseApiUrl}/articles${id}`, this.article)
        .then(() => {
          this.$toasted.global.defaultSuccess();
          this.reset();
        })
        .catch(showError);
    },
    remove() {
      const id = this.article.id;
      axios
        .delete(`${baseApiUrl}/articles/${id}`)
        .then(() => {
          this.$toasted.global.defaultSuccess();
          this.loadArticles();
        })
        .catch(showError);
    },
    loadArticle(article, mode = "save") {
      this.mode = mode;
      axios
        .get(`${baseApiUrl}/articles/${article.id}`)
        .then((res) => (this.article = res.data));
    },
    loadCategories() {
      const url = `${baseApiUrl}/categories`;
      axios.get(url).then((res) => {
        this.categories = res.data.map((category) => {
          return { value: category.id, text: category.path };
        });
      });
    },
    loadUsers() {
      const url = `${baseApiUrl}/users`;
      axios.get(url).then((res) => {
        this.users = res.data.map((user) => {
          return { value: user.id, text: `${user.name} - ${user.email}` };
        });
      });
    },
  },
  watch: {
    page() {
      this.loadArticles();
    },
  },
  mounted() {
    this.loadArticles();
    this.loadUsers();
    this.loadCategories();
  },
};
</script>

<style>
</style>