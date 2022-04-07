<template>
  <book-details v-bind:book="book"/>
  <!-- book is the prop passed to child/ "book" is the computed value that we want -->
</template>

<script>
import BookDetails from "../components/BookDetails.vue";

export default {
  name: "details-of-book",
  components: {
    BookDetails,
  },
  computed: {
    book() {
      let testBook = this.$store.state.books.find((book) => book.isbn == this.$route.params.isbn);
      if (testBook == undefined) {
        testBook = this.$store.state.popularBooks.find((book) => book.isbn == this.$route.params.isbn)
      }
      // console.log(this.$route.params.isbn)
      // console.log(testBook);
      return testBook;
    },
  },

  // second attempt
  // data() {
  //   return {
  //     isbnNumber: 0,
  //   }
  // },

  // created() {
  //   this.isbnNumber = this.$route.params.isbn;
  // },

};
</script>
