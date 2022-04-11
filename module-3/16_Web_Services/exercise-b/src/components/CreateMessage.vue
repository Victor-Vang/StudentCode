<template>
  <form v-on:submit.prevent="saveMessage">
    <div class="field">
      <label for="title">Title</label>
      <input type="text" name="title" v-model="message.title" />
    </div>
    <div class="field">
      <label for="messageText">Message</label>
      <input type="text" name="messageText" v-model="message.messageText" />
    </div>
    <div class="actions">
      <button type="submit">Save Message</button>
    </div>
  </form>
</template>

<script>
import messageService from "../services/MessageService";

export default {
  name: "create-message",
  props: ["topicId"],
  data() {
    return {
      message: {
        id: Math.floor(Math.random() * (1000 - 100) + 100),
        topicId: this.topicId,
        title: "",
        messageText: ""
      }
    };
  },
  methods: {
    saveMessage() {
      console.log(this.message);
      messageService.create(this.message).then(response => {
        if (response.status === 201) {
          this.$router.push({ name: 'Messages', params: { id: this.message.topicId } })
        }
      })
    }
  }
};
</script>

<style>
</style>
