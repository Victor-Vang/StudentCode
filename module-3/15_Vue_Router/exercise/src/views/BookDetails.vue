<template>
  <book-details />
</template>

<script>
import BookDetails from "../components/BookDetails.vue";

export default {
  components: {
    BookDetails,
  },
  computed: {
    book() {
      return this.$store.state.books.find((book) => {
        book.isbn == this.$route.params.isbn;
      });
    },
  },
};
</script>
