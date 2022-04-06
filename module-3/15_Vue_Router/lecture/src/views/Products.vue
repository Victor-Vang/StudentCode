<template>
  <div class="products">
    <products-list />
  </div>
</template>

<script>

import ProductsList from "../components/ProductsList.vue";

export default {
  name: "Products",
  components: {
    ProductsList,
  },
};
</script>
