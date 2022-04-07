<template>
  <div>
    <pet-view />
    <pet-add />
  </div>
</template>

<script>
import PetAdd from "../components/PetAdd.vue";
import PetView from "../components/PetView.vue";

export default {
  components: {
    PetView,
    PetAdd,
  },
};
</script>

<style>
</style>