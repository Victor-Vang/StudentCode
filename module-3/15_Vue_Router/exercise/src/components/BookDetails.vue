<template>
  <div>
    <h2>{{ book.title }}</h2>
    <h3>{{ book.author }}</h3>
    <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
  </div>
</template>

<script>
export default {
  name: "book-details",
  // computed: {
  //     book() {
  //         return this.$store.state.books.find((book) => {
  //             book.isbn == this.$route.params.isbn
  //         });
  //     }
  // }

  // second attempt
  props: ["book"],

  

};
</script>
