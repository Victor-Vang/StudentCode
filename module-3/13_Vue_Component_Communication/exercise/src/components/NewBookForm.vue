<template>
  <div>
    <form class="new-book-form" v-on:submit.prevent="addNewBook">
      <div>
        <label for="title" class="title-input">Name: </label>
        <input id="title" name="title" type="text" v-model="newBook.title" />
      </div>
      <div>
        <label for="author" class="author-input">Author: </label>
        <input id="author" name="author" type="text" v-model="newBook.author" />
      </div>
      <div>
        <label for="isbn" class="isbn-input">ISBN: </label>
        <input id="isbn" name="isbn" type="text" v-model="newBook.isbn" />
      </div>
      <input type="submit" />
    </form>
  </div>
</template>

<script>
export default {
  name: "new-book-form",
  data() {
    return {
      newBook: {
        read: true,
      },
    };
  },
  methods: {
    addNewBook() {
      this.$store.commit("ADD_NEW_BOOK", this.newBook);
      this.newBook = {};
    },
  },
};
</script>

<style>
</style>
